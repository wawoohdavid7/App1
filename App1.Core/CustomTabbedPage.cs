using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1.Core
{
    public class CustomTabbedPage : TabbedPage
    {
        private readonly INavigationService _navigationService;
        public CustomTabbedPage(INavigationService navigationService)
        {
            _navigationService = navigationService;
            CurrentPageChanged += OnCurrentPageChanged;
        }

        private void OnCurrentPageChanged(object sender, EventArgs e)
        {
            var s = (TabbedPage)sender;
            var cur = s.CurrentPage;
            var isNav = cur is NavigationPage;
            if (isNav)
            {
                _navigationService.Navigation = cur.Navigation;
            }
        }
    }
}
