using System;
using System.Collections.Generic;
using System.Text;

namespace CryptoServices.Entities.Entities.CoinMarketCap
{
    public class Metadata
    {
        public int timestamp { get; set; }
        public int num_cryptocurrencies { get; set; }
        public object error { get; set; }
    }
}
