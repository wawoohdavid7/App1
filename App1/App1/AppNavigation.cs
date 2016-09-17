using App1.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
   public class AppNavigation : IAppNavigation
   {
      private readonly INavigationService _navigationService;
      public AppNavigation(INavigationService navigationService)
      {
         _navigationService = navigationService;
      }

      public async Task GotoPage2()
      {
         await _navigationService.PushPageAsync(PageKeys.Page2);
      }

        public async Task GotoPage3()
        {
            await _navigationService.PushPageAsync(PageKeys.Page3);
        }

        public async Task PopToRootPageAsync(object rootPageKey = null)
      {
         await _navigationService.PopToRootPageAsync(rootPageKey);
      }
   }
}
