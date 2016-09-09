using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace App1.Views
{
   public partial class ListPageRoot : ContentPage
   {
      public ListPageRoot()
      {
         InitializeComponent();

         btnTest.Clicked += BtnTest_Clicked;
      }

      private void BtnTest_Clicked(object sender, EventArgs e)
      {
         var app = Application.Current;
         var mpage = app.MainPage.Title;

      }
   }
}
