using Models;
using Ninject.Modules;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shop.App_Start
{
    public class NinjectRegistrator : NinjectModule
    {
        public override void Load()
        {
            Bind<RepositoryFactory>().To<RepositoryFactory>();
        }
    }
}