using System;
using System.Collections.Generic;
using System.Text;

namespace Authing.ApiClient
{
    public class AuthingApiException : Exception
    {
        /// <summary>
        /// The returned status code
        /// </summary>
        public int StatusCode { get; }

        public AuthingApiException()
        {
        }

        public AuthingApiException(string message) : base($"The API request failed: {message}")
        {
        }

        public AuthingApiException(string message, Exception innerException) : base($"The API request failed: {message}", innerException)
        {
        }

        public AuthingApiException(string message, int statusCode) : base($"The API request failed with code {statusCode}: {message}")
        {
            StatusCode = statusCode;
        }

    }
}
