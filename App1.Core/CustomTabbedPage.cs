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
        private readonly IIndexedRootPageRetriever _rootPageRetriever;

        public CustomTabbedPage(INavigationService navigationService, IIndexedRootPageRetriever rootPageRetriever)
        {
            _navigationService = navigationService;
            _rootPageRetriever = rootPageRetriever;

            CurrentPageChanged += OnCurrentPageChanged;
        }

        public void InitializeTabbedPage()
        {
            PopulateTabs();
        }

        private void PopulateTabs()
        {
            var rootPages = _rootPageRetriever.GetIndexedRootPageList();

            foreach (var pg in rootPages)
            {
                Children.Add(pg.Item2);
            }
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
