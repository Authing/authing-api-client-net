using System;
using System.Collections.Generic;
using System.Text;

namespace Authing.ApiClient
{
    public class AuthingException : Exception
    {
        /// <summary>
        /// The returned status code
        /// </summary>
        public int StatusCode { get; }

        public AuthingException()
        {
        }

        public AuthingException(string message) : base($"The API request failed: {message}")
        {
        }

        public AuthingException(string message, Exception innerException) : base($"The API request failed: {message}", innerException)
        {
        }

        public AuthingException(string message, int statusCode) : base($"The API request failed with code {statusCode}: {message}")
        {
            StatusCode = statusCode;
        }

    }
}
