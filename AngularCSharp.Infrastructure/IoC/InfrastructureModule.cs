using AngularCSharp.Core.Interfaces;
using AngularCSharp.Infrastructure.DAL;
using AngularCSharp.Infrastructure.DAL.WebServices;
using Ninject.Modules;

namespace AngularCSharp.Infrastructure.IoC
{
    public class InfrastructureModule : NinjectModule
    {
        public override void Load()
        {
            /*
            Bind<IRepository>()
                .To<DefaultPeopleRepository>();            
            */

            Bind<IRepository>()
                .To<WebServicePeopleRepository>()
                .WithConstructorArgument("endPoint", "http://agl-developer-test.azurewebsites.net/people.json");
        }
    }
}
