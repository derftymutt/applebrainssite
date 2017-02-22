using Microsoft.Practices.Unity;
using System.Web.Http;
using System.Web.Mvc;
using Unity.WebApi;

namespace AppleBrainsSite
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            // e.g. container.RegisterType<ITestService, TestService>();
           
            DependencyResolver.SetResolver(new Unity.Mvc5.UnityDependencyResolver(container));
            //GlobalConfiguration.Configuration
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}