using App1.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1.ViewModels
{
   public class TabbedMasterPageViewModel : ViewModelBase
   {
        private class tb : TabbedPage
        {
            public tb()
            {
               
            }

            protected override void OnCurrentPageChanged()
            {
                base.OnCurrentPageChanged();
            }
        }
   }



    
}
