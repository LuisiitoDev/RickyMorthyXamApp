using System;
using Autofac;
using RickAndMortyApp.Services.GraphQL;
using RickAndMortyApp.Services.RickAndMortyService;

namespace RickAndMortyApp.Bootstrap
{
    public class AppSetUp
    {

        public static IContainer CreateContainer()
        {
            // SEVICES 
            var builder = new ContainerBuilder();
            builder.Register(c => new RickMortyService("https://rickandmortyapi.com/api/")).As<IRickMortyService>().SingleInstance();
            return builder.Build();
        }
    }
}
