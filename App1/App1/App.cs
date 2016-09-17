using Xamarin.Forms;

namespace App1
{
    public class App : Application
    {
        #region Fields

        private readonly IAppNavigation _appNavigation;

        #endregion Fields

        public App(IAppNavigation appNavigation)
        {
            _appNavigation = appNavigation;
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

        protected override void OnStart()
        {
            base.OnStart();
            InitializeMainPage();
        }

        private void InitializeMainPage()
        {
            //var page = _pageResolver.ResolvePage(PageKeys.TabbedMasterPage) as CustomTabbedPage;
            //page.InitializeTabbedPage();

            //MainPage = page;

            _appNavigation.InitializeMainPage();
        }

    }


}
