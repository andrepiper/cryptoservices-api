using CryptoServices.Common;
using CryptoServices.Entities;
using CryptoServices.Services.Interfaces;
using Flurl.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CryptoServices.Services.Implementation
{
    public class HttpRequest<T>: IHttpRequest<ProcessingResponse<T>>
    {
        public async Task<ProcessingResponse<T>> GetRequest(string builtUrl)
        {
            try
            {
                var json = await builtUrl.GetStringAsync();
                return new ProcessingResponse<T>()
                {
                    Response = Newtonsoft.Json.JsonConvert.DeserializeObject<T>(json),
                    Message = "Success",
                    Success = true
                };
            }
            catch (FlurlHttpTimeoutException ex)
            {
                throw new CryptoServicesException($"{ex.Message}");
            }
            catch (FlurlHttpException ex)
            {
                throw new CryptoServicesException($"{ex.Message}");
            }
        }
    }
}
