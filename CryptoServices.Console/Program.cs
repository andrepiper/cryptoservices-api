using CryptoServices.Entities;
using CryptoServices.Entities.Entities.CoinMarketCap;
using CryptoServices.Services.Implementation;
using CryptoServices.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace CryptoServices.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            RunAsync().Wait();
        }
        static async Task RunAsync()
        {
            var serviceProvider = new ServiceCollection()
                        .AddLogging()
                        .AddTransient<IHttpRequest<ProcessingResponse<Listings>>, HttpRequest<Listings>>()
                        .AddTransient<IHttpRequest<ProcessingResponse<Ticker>>, HttpRequest<Ticker>>()
                        .AddTransient<IHttpRequest<ProcessingResponse<Globaldata>>, HttpRequest<Globaldata>>()
                        .AddSingleton<ICoinMarketCap, CoinMarketCap>()
                        .BuildServiceProvider();

            serviceProvider
            .GetService<ILoggerFactory>();

            var logger = serviceProvider.GetService<ILoggerFactory>().CreateLogger<Program>();

            logger.LogDebug("Application started");

            var coinMarketCap = serviceProvider.GetService<ICoinMarketCap>();

            var listings = await coinMarketCap.GetListings();

            var ticker = await coinMarketCap.GetTicker(100);

            var global = await coinMarketCap.GetGlobal();

            logger.LogDebug("Application ended");
        }
    }
}
