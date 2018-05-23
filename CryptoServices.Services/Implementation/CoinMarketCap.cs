using CryptoServices.Common;
using CryptoServices.Entities;
using CryptoServices.Entities.Entities.CoinMarketCap;
using CryptoServices.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CryptoServices.Services.Implementation
{
    public class CoinMarketCap : ICoinMarketCap
    {
        private readonly IHttpRequest<ProcessingResponse<Listings>> _listings;
        private readonly IHttpRequest<ProcessingResponse<Ticker>> _ticker;
        private readonly IHttpRequest<ProcessingResponse<Globaldata>> _global;

        public CoinMarketCap(
            IHttpRequest<ProcessingResponse<Listings>> listings,
            IHttpRequest<ProcessingResponse<Ticker>> ticker,
            IHttpRequest<ProcessingResponse<Globaldata>> global
        )
        {
            _listings = listings;
            _ticker = ticker;
            _global = global;
        }

        public async Task<ProcessingResponse<Globaldata>> GetGlobal(string enpoint = "https://api.coinmarketcap.com/v2/global/", string convert = "USD")
        {
            var response = new ProcessingResponse<Globaldata>();
            try
            {
                response = await _global.GetRequest($"{enpoint}?convert={convert}");
            }
            catch (CryptoServicesException ex)
            {
                response.Message = ex.Message;
                response.Success = false;
            }
            return response;
        }

        public async Task<ProcessingResponse<Listings>> GetListings(string enpoint = "https://api.coinmarketcap.com/v2/listings/", string convert = "USD")
        {
            var response = new ProcessingResponse<Listings>();
            try
            {
                response = await _listings.GetRequest($"{enpoint}?convert={convert}");
            }
            catch (CryptoServicesException ex)
            {
                response.Message = ex.Message;
                response.Success = false;
            }
            return response;
        }

        public async Task<ProcessingResponse<Ticker>> GetTicker(int limit, string enpoint = "https://api.coinmarketcap.com/v2/ticker/", string convert = "USD")
        {
            var response = new ProcessingResponse<Ticker>();
            try
            {
                response = await _ticker.GetRequest($"{enpoint}?convert={convert}&limit={limit}");
            }
            catch (CryptoServicesException ex)
            {
                response.Message = ex.Message;
                response.Success = false;
            }
            return response;
        }

        public async Task<ProcessingResponse<Ticker>> GetTicker(int limit, int start, string sortBy, string enpoint = "https://api.coinmarketcap.com/v2/ticker/", string convert = "USD")
        {
            var response = new ProcessingResponse<Ticker>();
            try
            {
                response = await _ticker.GetRequest($"{enpoint}?convert={convert}&limit={limit}&start={start}&sort={sortBy}");
            }
            catch (CryptoServicesException ex)
            {
                response.Message = ex.Message;
                response.Success = false;
            }
            return response;
        }
    }
}
