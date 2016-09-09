using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace App1.ViewModels
{
   public class Page2ViewModel : App1.Core.ViewModelBase
   {
      private readonly IAppNavigation _appNavigation;
      public Page2ViewModel(IAppNavigation appNavigation)
      {
         _appNavigation = appNavigation;
         PopCommand = new Command(async () =>
         {
            // Add the key to the input string.
            await _appNavigation.PopToRootPageAsync();
         });
      }
      public string MainText
      {
         get
         {
            return "@Page2";
         }
      }

      public ICommand PopCommand { protected set; get; }

   }
}
