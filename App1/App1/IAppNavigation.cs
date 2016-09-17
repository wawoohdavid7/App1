using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
   public interface IAppNavigation
   {
      Task GotoPage2();
      Task GotoPage3();

      Task PopToRootPageAsync(object rootPageKey = null);
   }
}
