using CryptoServices.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CryptoServices.Services.Interfaces
{
    public interface IHttpRequest<T> where T : class
    {
        Task<T> GetRequest(string builtUrl);
    }
}
