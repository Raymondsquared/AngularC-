using System;
using System.Collections.Generic;
using AngularCSharp.Core.Interfaces;
using AngularCSharp.Core.Models;
using AngularCSharp.Core.Serializers;
using AngularCSharp.Core.Services;
using Ninject.Modules;

namespace AngularCSharp.Core.IoC
{
    public class CoreModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IGenericService<Person>>()
                .To<PeopleService>();

            Bind<IPetService>()
                .To<PetService>();

            Bind<ISerializer>()
                .To<JsonSerializer>();
        }
    }
}
