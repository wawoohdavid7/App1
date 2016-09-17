using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1.Core
{
   public class NavigationService : INavigationService
   {
      private readonly IPageResolver _pageResolver;
      public NavigationService(IPageResolver pageResolver)
      {
         _pageResolver = pageResolver;
      }

      public INavigation Navigation { get; set; }

      public Task PushPageAsync(object pageKey)
      {
         var page = _pageResolver.ResolvePage(pageKey);

         return Navigation.PushAsync(page);
      }

      public async Task PopToRootPageAsync(object rootPageKey = null)
      {
        //         if (rootPageKey == null) return Navigation.PopToRootAsync();
        if (rootPageKey == null)
        {
            await Navigation.PopToRootAsync();
        }
        else
        {
            var app = Application.Current;

            var page = _pageResolver.ResolvePage(rootPageKey);

            app.MainPage = page;

        }

      }

   }
}
