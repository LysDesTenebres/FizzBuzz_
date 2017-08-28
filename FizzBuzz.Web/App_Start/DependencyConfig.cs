using System.Reflection;
using System.Web.Http;
using System.Web.Mvc;
using FizzBuzz.Data;
using FizzBuzz.Web.Models;
using SimpleInjector;
using SimpleInjector.Integration.Web;
using SimpleInjector.Integration.Web.Mvc;
using SimpleInjector.Integration.WebApi;

namespace FizzBuzz.Web
{
    public class DependencyConfig
    {
        public static void RegisterDependencies()
        {
            //TODO: make sure the "RegisterDependencies()" method is called somewhere

            RegisterApiDependencies();
        }

        private static void RegisterApiDependencies()
        {

            //TODO: setup dependency injection with Simple Injector 
            var container = new Container();
            container.Options.DefaultScopedLifestyle = new WebRequestLifestyle();

            container.Register(() => new ApplicationDbContext(), Lifestyle.Scoped);

        
            container.Verify();
            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));
        }
    }
}