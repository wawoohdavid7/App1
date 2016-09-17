using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1.Core
{
   public class PageResolver : IPageResolver
   {
      private readonly ILifetimeScope _lifetimeScope;
      public PageResolver(ILifetimeScope lifetimeScope)
      {
         _lifetimeScope = lifetimeScope;
      }

        public Page ResolveTabbedPage(Object tabKey)
        {
            return ResolvePage(tabKey) as CustomTabbedPage;
        }


      public Page ResolvePage(Object key)
      {
         try
         {
            var page = _lifetimeScope.ResolveKeyed<Page>(key);
            //var vm = _lifetimeScope.ResolveKeyed<ViewModelBase>(key);
            //page.BindingContext = vm;

            if (_lifetimeScope.IsRegisteredWithKey<ViewModelBase>(key))
            {
                var vm = _lifetimeScope.ResolveKeyed<ViewModelBase>(key);
                page.BindingContext = vm;
            }

            return page;
         }
         catch (Exception ex)
         {
            //Debug.WriteLine("Error resolving page");
            throw new Exception("page not resolved");
            return null;
         }

      }
   }
}
