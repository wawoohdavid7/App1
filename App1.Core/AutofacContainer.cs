using App1.Core;
using Autofac;
using System;
using System.Collections.Generic;
using System.Text;

namespace App1.Core
{
    public static class AutofacContainer
    {
        public static IContainer AppContainer { get; private set; }

        public static Xamarin.Forms.Application GetApplicationInstance(Module appModule = null)
        {
            var containerBuilder = new ContainerBuilder();
            //containerBuilder.RegisterModule(new App1Module());
            if(appModule != null) containerBuilder.RegisterModule(appModule);
            containerBuilder.RegisterModule(new CoreModule());
            AppContainer = containerBuilder.Build();

            return AppContainer.Resolve<Xamarin.Forms.Application>();
        }
    }
}
