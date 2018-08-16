using Microsoft.Practices.Unity;
using System;

namespace DoorsApp
{
    public static class Bootstrapper
    {
        private static readonly Lazy<IUnityContainer> Container = new Lazy<IUnityContainer>(() => new UnityContainer());

        public static IUnityContainer Initialize()
        {
            //var container = GetConfiguredContainer();
            //DependencyResolver.SetResolver(new UnityMVCDependencyResolver(container));

            //var resolver = new UnityWebApiDependencyResolver(GetConfiguredContainer());
            //GlobalConfiguration.Configuration.DependencyResolver = resolver;

            return GetConfiguredContainer();
        }

        public static IUnityContainer GetConfiguredContainer()
        {
            return Container.Value;
        }
    }
}