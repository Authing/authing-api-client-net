using System;
using System.Collections.Generic;
using System.Text;

namespace Authing.ApiClient.Types
{
    /// <summary>
    /// Graphql 端点类型
    /// </summary>
    public enum GraphqlHostType
    {
        /// <summary>
        /// 使用 UserHost
        /// </summary>
        User,

        /// <summary>
        /// 使用 OAuthHost
        /// </summary>
        OAuth,
    }
}
