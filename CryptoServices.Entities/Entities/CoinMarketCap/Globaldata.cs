using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace CryptoServices.Entities.Entities.CoinMarketCap
{
    public class Globaldata
    {
        [JsonProperty("data")]
        public GlobaldataResponse Response { get; set; }
    }
    public class GlobaldataResponse
    {
        public string active_cryptocurrencies { get; set; }
        public string active_markets { get; set; }
        public double bitcoin_percentage_of_market_cap { get; set; }
        [JsonProperty("quotes")]
        public Dictionary<string, GlobaldataQuotes> Quotes { get; set; }
        public string last_updated { get; set; }
    }
    public class GlobaldataQuotes
    {
        public string total_market_cap { get; set; }
        public string total_volume_24h { get; set; }
    }
}
