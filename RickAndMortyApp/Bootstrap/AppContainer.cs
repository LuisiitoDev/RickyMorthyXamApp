using System;
using Autofac;

namespace RickAndMortyApp.Bootstrap
{
    public static class AppContainer
    {
        public static IContainer Container { get; set; }

        public static TService ResolveService<TService>()
        {
            using(var scope = Container.BeginLifetimeScope())
            {
                return scope.Resolve<TService>();
            }
        }
    }
}
