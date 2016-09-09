using App1.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace App1.ViewModels
{
   public class MainPageViewModel : App1.Core.ViewModelBase
   {
      private readonly IAppNavigation _appNavigation;
      public MainPageViewModel(IAppNavigation appNavigation) 
      {
         _appNavigation = appNavigation;


         this.AddCharCommand = new Command<string>((key) =>
         {
            // Add the key to the input string.
            WelcomeText = "Changed";
         });

         GoPage2Command = new Command(async() => 
         {
            //_appNavigation.RootPage = App.RootPage;
            await _appNavigation.GotoPage2();
         });
      }

      public ICommand AddCharCommand { protected set; get; }

      public ICommand GoPage2Command { protected set; get; }

      private string welcomeText = "default";
      public string WelcomeText
      {
         get
         {
            return welcomeText;
         }
         set
         {
            //welcomeText = value;
            //RaisePropertyChanged(() => WelcomeText);
            SetProperty(ref welcomeText, value, nameof(WelcomeText));
         }
      }

   }
}
