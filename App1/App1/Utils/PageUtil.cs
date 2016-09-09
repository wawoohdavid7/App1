using App1.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1.Utils
{
   public class PageUtil : IPageUtil
   {
      private readonly IPageResolver _pageResolver;
      public PageUtil(IPageResolver pageResolver)
      {
         _pageResolver = pageResolver;
      }


      public List<Tuple<int, Page>> GetIndexedRootPages()
      {
         var listPageRoot = _pageResolver.ResolvePage(PageKeys.ListPage);
         var settingsPageRoot = _pageResolver.ResolvePage(PageKeys.Settings);

         List<Tuple<int, Page>> indexedRootPageList = new List<Tuple<int, Page>>();

         indexedRootPageList.Add(new Tuple<int, Page>(1,settingsPageRoot));
         indexedRootPageList.Add(new Tuple<int, Page>(0, listPageRoot));

         return indexedRootPageList;
      }
   }
}
