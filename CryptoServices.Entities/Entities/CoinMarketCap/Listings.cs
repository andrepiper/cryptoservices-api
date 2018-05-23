using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace CryptoServices.Entities.Entities.CoinMarketCap
{
    public class Listings
    {
        [JsonProperty("data")]
        public List<ListingResponse> Response { get; set; }
    }
    public class ListingResponse
    {
        public int id { get; set; }
        public string name { get; set; }
        public string symbol { get; set; }
        public string website_slug { get; set; }
    }
}
