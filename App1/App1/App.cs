using App1.Core;
using App1.Views;
using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    public class App : Application
    {
      private readonly ILifetimeScope _lifetimeScope;
      private readonly INavigationService _navigationService;
      private readonly IPageResolver _pageResolver;
      private readonly IAppNavigation _appNavigation;
      public App(ILifetimeScope lifetimeScope, INavigationService navigationService, IPageResolver pageResolver, IAppNavigation appNavigation)
      {
         _lifetimeScope = lifetimeScope;
         _navigationService = navigationService;
         _pageResolver = pageResolver;
         _appNavigation = appNavigation;
         //try
         //{
         //  var t = _lifetimeScope.ResolveKeyed<Page>(PageKeys.MainPage);
         //   var k = "";
         //}
         //catch (Exception ex)
         //{
         //}
      }

      #region Pang tesst lang
      //private void Testing()
      //{
      //   List<Calendar> calendarList = new List<Calendar>()
      //   {
      //      new Calendar {AlarmDate = new DateTime(2016,2,7), EventDate = new DateTime(2016,2,9),TypeId=1},
      //      new Calendar {AlarmDate = new DateTime(2016,9,2), EventDate = new DateTime(2016,9,4),TypeId=2},
      //      new Calendar {AlarmDate = new DateTime(2016,2,7), EventDate = new DateTime(2016,2,13),TypeId=3},
      //      new Calendar {AlarmDate = new DateTime(2016,2,7), EventDate = new DateTime(2016,2,9),TypeId=1},
      //      new Calendar {AlarmDate = new DateTime(2016,3,1), EventDate = new DateTime(2016,3,3),TypeId=1},
      //      new Calendar {AlarmDate = new DateTime(2016,9,2), EventDate = new DateTime(2016,9,8),TypeId=3},
      //      new Calendar {AlarmDate = new DateTime(2016,1,12), EventDate = new DateTime(2016,1,18),TypeId=3},
      //      new Calendar {AlarmDate = new DateTime(2016,6,15), EventDate = new DateTime(2016,6,19),TypeId=2},
      //      new Calendar {AlarmDate = new DateTime(2016,8,29), EventDate = new DateTime(2016,9,4),TypeId=3},
      //   };

      //   var grped = from action in calendarList
      //               group action by new
      //               {
      //                  AlarmDateGrp = action.AlarmDate.Date,
      //                  EventDateGrp = action.EventDate.Date,
      //                  TypeIdGrp = action.TypeId
      //               } into g
      //               select new { TheAlarm = g.Key.AlarmDateGrp, TheEvent = g.Key.EventDateGrp, Total  = g.Count(), TheType = g.Key.TypeIdGrp };
      //   var res = grped.ToList();

      //   var feb7batch = grped.Where(w => w.TheAlarm <= new DateTime(2016, 2, 7).Date).Sum(s => s.Total);
      //   var sep2batch = grped.Where(w => w.TheAlarm <= new DateTime(2016, 9, 2).Date).Sum(s => s.Total);
      //   var mar1batch = grped.Where(w => w.TheAlarm <= new DateTime(2016, 3, 1).Date).Sum(s => s.Total);
      //   var jan12batch = grped.Where(w => w.TheAlarm <= new DateTime(2016, 1, 12).Date).Sum(s => s.Total);
      //   var jun15batch = grped.Where(w => w.TheAlarm <= new DateTime(2016, 6, 15).Date).Sum(s => s.Total);
      //   var aug29batch = grped.Where(w => w.TheAlarm <= new DateTime(2016, 8, 29).Date).Sum(s => s.Total);

      //}

      //private class Calendar
      //{
      //   public DateTime EventDate { get; set; }
      //   public DateTime AlarmDate { get; set; }
      //   public int TypeId { get; set; }
      //}
      #endregion Pang tesst lang

      private void InitializeTabbedPage()
      {
         var page = _pageResolver.ResolvePage(PageKeys.TabbedMasterPage) as TabbedPage;

         var rootPages = GetIndexedRootPages().OrderBy(o => o.Key);
         
         //page.Children.Add(new SettingsPageRoot());
         //page.Children.Add(new ListPageRoot());


         foreach (var pgkey in rootPages)
         {
            var pg = _pageResolver.ResolvePage(pgkey.Value);
            page.Children.Add(pg);
         }

         MainPage = page;
      }

      private Dictionary<int, object> GetIndexedRootPages()
      {
         //List<Tuple<int, object>> indexedRootPageList = new List<Tuple<int, object>>();
         Dictionary<int, object> indexedRootPageList = new Dictionary<int, object>();
         indexedRootPageList.Add(0, PageKeys.Settings);
         indexedRootPageList.Add(1, PageKeys.ListPage);

         return indexedRootPageList;
      }



      //public static Page RootPage { get; set; }
      protected override void OnStart()
      {
         base.OnStart();
         //Testing();

         //MainPage = new MainPage();
         try
         {
            //var page = _pageResolver.ResolvePage(PageKeys.MainPage);
            //MainPage = new NavigationPage(page);
            //_navigationService.Navigation = MainPage.Navigation;

            //_navigationService.Navigation = MainPage.Navigation;
            //var page = _pageResolver.ResolvePage(PageKeys.TabbedMasterPage);


            //MainPage = page;


            //_appNavigation.PopToRootPageAsync(PageKeys.TabbedMasterPage);

            InitializeTabbedPage();

         }
         catch (Exception ex)
         {
         }
      }
   }


}
