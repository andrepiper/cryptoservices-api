# cryptoservices-api 
.Net core api wrapper to fetch latest crypotcurrency data from exchanges.
# Nuget Package
	CryptoServices.Services
	(https://www.nuget.org/packages/CryptoServices.Services)

# Usage with dependency injection

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

# Contribution
Please fork repository and contribute using pull requests. Any contributions, large or small, major features, bug fixes, additional language translations, unit/integration tests are welcomed and appreciated but will be thoroughly reviewed and discussed.

# License

Copyright 2018 Andre Piper
Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance with the License. You may obtain a copy of the License at

http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the specific language governing permissions and limitations under the License.
