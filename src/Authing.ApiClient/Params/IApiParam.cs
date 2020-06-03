using Authing.ApiClient.GrqphQL;
using System;
using System.Collections.Generic;
using System.Text;

namespace Authing.ApiClient.Params
{
    interface IApiParam
    {
        GraphQLRequest CreateRequest();
    }
}
