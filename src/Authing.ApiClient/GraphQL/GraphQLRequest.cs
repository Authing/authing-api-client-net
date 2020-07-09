using System;
using System.Collections.Generic;
using System.Text;

namespace Authing.ApiClient.GraphQL
{
    /// <summary>
    /// A GraphQL request
    /// </summary>
    public class GraphQLRequest : Dictionary<string, object>
    {
        public const string OPERATION_NAME_KEY = "operationName";
        public const string QUERY_KEY = "query";
        public const string VARIABLES_KEY = "variables";

        /// The Query
        /// </summary>
        public string Query
        {
            get => ContainsKey(QUERY_KEY) ? (string)this[QUERY_KEY] : null;
            set => this[QUERY_KEY] = value;
        }

        /// <summary>
        /// The name of the Operation
        /// </summary>
        public string OperationName
        {
            get => ContainsKey(OPERATION_NAME_KEY) ? (string)this[OPERATION_NAME_KEY] : null;
            set => this[OPERATION_NAME_KEY] = value;
        }

        /// <summary>
        /// Represents the request variables
        /// </summary>
        public object Variables
        {
            get => ContainsKey(VARIABLES_KEY) ? this[VARIABLES_KEY] : null;
            set => this[VARIABLES_KEY] = value;
        }

        public GraphQLRequest() { }

        public GraphQLRequest(string query, object variables = null, string operationName = null)
        {
            Query = query;
            Variables = variables;
            OperationName = operationName;
        }
    }
}
