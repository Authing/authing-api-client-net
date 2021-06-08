using System;
using System.Collections.Generic;
using System.Text;

namespace Authing.ApiClient.Types
{
    public class RestfulResponse<T>
    {
        public int Code { get; set; }

        public string Message { get; set; }

        public T Data { get; set; }
    }

    public class SimpleResponse
    {
        public int Code { get; set; }

        public string Message { get; set; }

    }
}
