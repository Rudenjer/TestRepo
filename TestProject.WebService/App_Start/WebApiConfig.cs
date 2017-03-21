using System.Web.Http;
using System.Web.Http.Cors;
using Microsoft.Practices.Unity;
using TestProject.BusinessLogicLayer.Interfaces;
using TestProject.BusinessLogicLayer.Services;
using TestProject.DataAccessLayer.Interfaces;
using TestProject.DataAccessLayer.Repository;

namespace TestProject.WebService
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            var container = new UnityContainer();

            container.RegisterType<IUnitOfWork, UnitOfWork>(new HierarchicalLifetimeManager());
            container.RegisterType<IPetService, PetService>(new HierarchicalLifetimeManager());
            container.RegisterType<IOwnerService, OwnerService>(new HierarchicalLifetimeManager());

            config.DependencyResolver = new UnityResolver(container);
            config.EnableCors(new EnableCorsAttribute("*", "*", "*"));

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}