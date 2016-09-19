using Autofac;
using System;
using System.Diagnostics;
using Xamarin.Forms;

namespace App1.Core
{
    public class PageResolver : IPageResolver
    {
        private readonly ILifetimeScope _lifetimeScope;

        public PageResolver(ILifetimeScope lifetimeScope)
        {
            _lifetimeScope = lifetimeScope;
        }

        public CustomTabbedPage ResolveTabbedMainPage()
        {
            return _lifetimeScope.Resolve<TabbedPage>() as CustomTabbedPage;
        }

        /// <summary>
        /// Gets the resolved page and automatically binded to its view model.
        /// </summary>
        /// <param name="key">The key of the page as a value in page names enum.</param>
        /// <returns><see cref="Page"/>.</returns>
        public Page ResolvePage(Object key)
        {
            try
            {
                var page = _lifetimeScope.ResolveKeyed<Page>(key);

                if (_lifetimeScope.IsRegisteredWithKey<ViewModelBase>(key))
                {
                    var vm = _lifetimeScope.ResolveKeyed<ViewModelBase>(key);
                    page.BindingContext = vm;
                }

                return page;
            }
            catch (Exception ex)
            {
                string errorMsg = $"Error resolving {key}";
                Debug.WriteLine(errorMsg);
                throw new Exception(errorMsg);
            
                return null;
            }
      }
   }
}
