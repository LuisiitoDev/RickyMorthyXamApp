using System;
using GraphQL.Client.Http;

namespace RickAndMortyApp.Services.GraphQL
{
    public interface IGraphQLClient
    {
        GraphQLHttpClient GetClient();
    }
}
