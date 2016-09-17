using System;
using Xamarin.Forms;

namespace App1.Core
{
    public interface IPageResolver
   {
      Page ResolvePage(Object key);
   }
}
