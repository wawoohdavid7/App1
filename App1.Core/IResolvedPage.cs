using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1.Core
{
   public interface IResolvedPage
   {
      Page ResolvePage(ILifetimeScope lifetimeScope,PageKeys key);
   }
}
