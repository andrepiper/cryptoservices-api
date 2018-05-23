using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace CryptoServices.Entities.Entities.CoinMarketCap
{
    public class Ticker
    {
        [JsonProperty("data")]
        public Dictionary<string,TickerResponse> Response { get; set; }
    }
    public class TickerResponse
    {
        public int id { get; set; }
        public string name { get; set; }
        public string symbol { get; set; }
        public string website_slug { get; set; }
        public int rank { get; set; }
        public string circulating_supply { get; set; }
        public string total_supply { get; set; }
        public string max_supply { get; set; }
        [JsonProperty("quotes")]
        public Dictionary<string, TickerQuotes> Quotes { get; set; }
        public string last_updated { get; set; }
    }
    public class TickerQuotes
    {
        public double price { get; set; }
        public string volume_24h { get; set; }
        public string market_cap { get; set; }
        public double percent_change_1h { get; set; }
        public double percent_change_24h { get; set; }
        public double percent_change_7d { get; set; }
    }
}
