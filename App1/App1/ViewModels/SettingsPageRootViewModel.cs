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
   public class SettingsPageRootViewModel : ViewModelBase
   {
        private readonly IAppNavigation _appNavigation;
        public SettingsPageRootViewModel(IAppNavigation appNavigation)
        {
            _appNavigation = appNavigation;

            GoPage3Command = new Command(async () =>
            {
                // Add the key to the input string.
                await _appNavigation.GotoPage3();
            });
        }
        public ICommand GoPage3Command { protected set; get; }
    }
}
