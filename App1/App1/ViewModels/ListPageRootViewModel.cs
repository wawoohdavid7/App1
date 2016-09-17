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
   public class ListPageRootViewModel : ViewModelBase
   {
        private readonly IAppNavigation _appNavigation;
        public ListPageRootViewModel(IAppNavigation appNavigation)
        {
            _appNavigation = appNavigation;

            TestCommand = new Command(async () =>
            {
                // Add the key to the input string.
                await _appNavigation.GotoPage2();
            });
        }

        public ICommand TestCommand { protected set; get; }


    }
}
