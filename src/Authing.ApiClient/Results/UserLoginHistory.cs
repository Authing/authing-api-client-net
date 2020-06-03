using System;
using System.Collections.Generic;
using System.Text;

namespace Authing.ApiClient.Results
{
    public class UserLoginHistory
    {
        public int TotalCount { get; set; }

        public List<LoginRecord> List { get; set; }
    }
}
