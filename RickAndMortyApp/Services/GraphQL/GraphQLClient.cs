using System;
using GraphQL.Client.Http;
using GraphQL.Client.Serializer.Newtonsoft;

namespace RickAndMortyApp.Services.GraphQL
{
    public class GraphQLClient : IGraphQLClient
    {
        /// <summary>
        /// Api URL to create request
        /// </summary>
        public string baseAdress { get; set; }

        public GraphQLClient(string baseAdress)
        {
            this.baseAdress = baseAdress;
        }

        public GraphQLHttpClient GetClient()
        {
            return new GraphQLHttpClient(baseAdress,
                                        new NewtonsoftJsonSerializer());

        }
    }
}
