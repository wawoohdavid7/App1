using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1.Core
{

    /// <summary>
    /// Page navigation service.
    /// </summary>
    public class NavigationService : INavigationService
    {
        private readonly IPageResolver _pageResolver;

        public NavigationService(IPageResolver pageResolver)
        {
            _pageResolver = pageResolver;
        }

        public INavigation Navigation { get; set; }

        /// <summary>
        /// Navigation to page asynchronously.
        /// </summary>
        /// <param name="pageKey">The page key as a value in page names enum.</param>
        /// <returns>Task.</returns>
        public Task PushPageAsync(object pageKey)
        {
            var page = _pageResolver.ResolvePage(pageKey);

            return Navigation.PushAsync(page);
        }

        public async Task PopToRootPageAsync()
        {
            await Navigation.PopToRootAsync();
        }
   }
}
