using Castle.MicroKernel.Registration;
using Castle.Windsor;
using DependencyInjectionWithCastle.Controllers;
using DependencyInjectionWithCastle.Models;
using DependencyInjectionWithCastle.Services;
using System.Data.Entity;
using System.Web.Http;

namespace DependencyInjectionWithCastle
{
    public static class CastleConfig
    {
        public static IWindsorContainer GetContiner()
        {
            var container = new WindsorContainer();
            container.Register(Component.For<MyContext>());


            container.Register(Component.For<IGravityServices>()
                .ImplementedBy<GravityServices>());

           
          //  container.Register(Component.For<IranGravityController>().LifestylePerWebRequest());
            //or using this , if you have multiple controller in your project
            container.Register(Classes.FromThisAssembly().BasedOn<ApiController>().LifestylePerWebRequest());

            return container;
        }

    }
}
