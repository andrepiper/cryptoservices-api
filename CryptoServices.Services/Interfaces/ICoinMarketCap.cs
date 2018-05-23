using CryptoServices.Entities;
using CryptoServices.Entities.Entities.CoinMarketCap;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CryptoServices.Services.Interfaces
{
    public interface ICoinMarketCap
    {
        Task<ProcessingResponse<Listings>> GetListings(string enpoint = "https://api.coinmarketcap.com/v2/listings/", string convert = "USD");
        Task<ProcessingResponse<Ticker>> GetTicker(int limit, string enpoint = "https://api.coinmarketcap.com/v2/ticker/", string convert = "USD");
        Task<ProcessingResponse<Ticker>> GetTicker(int limit, int start, string sortBy, string enpoint = "https://api.coinmarketcap.com/v2/ticker/", string convert = "USD");
        Task<ProcessingResponse<Globaldata>> GetGlobal(string enpoint = "https://api.coinmarketcap.com/v2/global/", string convert = "USD");
    }
}
