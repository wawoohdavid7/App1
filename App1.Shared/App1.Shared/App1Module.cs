using App1.Core;
using App1.Utils;
using App1.ViewModels;
using App1.Views;
using Autofac;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace App1.Shared
{
   public class App1Module : Module
   {
        private ContainerBuilder _builder = null;
        protected override void Load(ContainerBuilder builder)
        {
            _builder = builder;
            RegisterServices();
            RegisterManagers();
            RegisterViews();
            RegisterViewModel();

            _builder.RegisterType<App>().As<Xamarin.Forms.Application>().SingleInstance();
        }

        private void RegisterServices()
        {
            _builder.RegisterType<NavigationService>().As<INavigationService>().SingleInstance();
            _builder.RegisterType<PageResolver>().As<IPageResolver>().SingleInstance();

            _builder.RegisterType<AppNavigation>().As<IAppNavigation>().SingleInstance();
            _builder.RegisterType<PageUtil>().As<IPageUtil>().SingleInstance();
            _builder.RegisterType<RootPageRetriever>().As<IIndexedRootPageRetriever>().SingleInstance();
        }

        private void RegisterManagers()
        {
        }

        private void RegisterViews()
        {
            //_builder.RegisterType<TabbedMasterPage>().Keyed<Page>(PageKeys.TabbedMasterPage).SingleInstance();
            _builder.RegisterType<CustomTabbedPage>().Keyed<Page>(PageKeys.TabbedMasterPage).SingleInstance();

            _builder.RegisterType<ListPageRoot>().Keyed<Page>(PageKeys.ListPage).SingleInstance();
            _builder.RegisterType<SettingsPageRoot>().Keyed<Page>(PageKeys.Settings).SingleInstance();
            _builder.RegisterType<MainPage>().Keyed<Page>(PageKeys.MainPage).SingleInstance();
            _builder.RegisterType<Page2>().Keyed<Page>(PageKeys.Page2).SingleInstance();
            _builder.RegisterType<Page3>().Keyed<Page>(PageKeys.Page3).SingleInstance();
        }

        private void RegisterViewModel()
        {
            //_builder.RegisterType<TabbedMasterPageViewModel>().Keyed<ViewModelBase>(PageKeys.TabbedMasterPage).SingleInstance();
            _builder.RegisterType<ListPageRootViewModel>().Keyed<ViewModelBase>(PageKeys.ListPage).SingleInstance();
            _builder.RegisterType<SettingsPageRootViewModel>().Keyed<ViewModelBase>(PageKeys.Settings).SingleInstance();
            _builder.RegisterType<MainPageViewModel>().Keyed<ViewModelBase>(PageKeys.MainPage).SingleInstance();
            _builder.RegisterType<Page2ViewModel>().Keyed<ViewModelBase>(PageKeys.Page2).SingleInstance();
            _builder.RegisterType<Page3ViewModel>().Keyed<ViewModelBase>(PageKeys.Page3).SingleInstance();
        }

   }
}
