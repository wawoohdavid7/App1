using Autofac;
using Xamarin.Forms;

namespace App1.Core
{
    public class CoreModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //builder.RegisterType<CustomTabbedPage>().Keyed<Page>(PageKeys.TabbedMasterPage).SingleInstance();
            //.Resolve<TabbedPage>();
            builder.RegisterType<CustomTabbedPage>().As<TabbedPage>().SingleInstance();

            builder.RegisterType<NavigationService>().As<INavigationService>().SingleInstance();
            builder.RegisterType<PageResolver>().As<IPageResolver>().SingleInstance();
        }
    }
}
