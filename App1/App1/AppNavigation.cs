using App1.Core;
using System.Threading.Tasks;

namespace App1
{
    public class AppNavigation : IAppNavigation
    {
        private readonly INavigationService _navigationService;
        private readonly IPageResolver _pageResolver;

        public AppNavigation(INavigationService navigationService, IPageResolver pageResolver)
        {
            _navigationService = navigationService;
            _pageResolver = pageResolver;
        }

        public async Task GotoPage2()
        {
            await _navigationService.PushPageAsync(PageKeys.Page2);
        }

        public async Task GotoPage3()
        {
            await _navigationService.PushPageAsync(PageKeys.Page3);
        }

        public async Task PopToRootPageAsync()
        {
            await _navigationService.PopToRootPageAsync();
        }

        public void InitializeMainPage()
        {
            var page = _pageResolver.ResolvePage(PageKeys.TabbedMasterPage) as CustomTabbedPage;
            page.InitializeTabbedPage();

            App.Current.MainPage = page;
        }
    }
}
