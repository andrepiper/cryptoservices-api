using System;

namespace CryptoServices.Common
{
    /// <summary>
    /// CryptoServicesException class
    /// </summary>
    public class CryptoServicesException : Exception
    {

        public CryptoServicesException() : base() { }

        public CryptoServicesException(string message) : base(message) { }

        public CryptoServicesException(string message, Exception innerException) : base(message, innerException) { }
    }
}
