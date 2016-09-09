using Autofac;
using System;
using System.Collections.Generic;
using System.Text;

namespace App1.Shared
{
    public static class AutofacContainer
    {
      public static IContainer AppContainer { get; private set; }

      public static Xamarin.Forms.Application GetApplicationInstance()
      {
         var containerBuilder = new ContainerBuilder();
         containerBuilder.RegisterModule(new App1Module());
         AppContainer = containerBuilder.Build();

         return AppContainer.Resolve<Xamarin.Forms.Application>();
      }
   }
}
