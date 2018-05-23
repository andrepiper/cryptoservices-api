using System;
using System.Collections.Generic;
using System.Text;

namespace CryptoServices.Entities
{
    public class ProcessingResponse<T>
    {
        public bool Success { get; set; }

        public string Message { get; set; }

        public T Response { get; set; }
    }
}
