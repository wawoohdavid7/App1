using App1.Core;
using App1.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    public class RootPageRetriever : IIndexedRootPageRetriever
    {
        private readonly IPageUtil _pageUtil;

        public RootPageRetriever(IPageUtil pageUtil)
        {
            _pageUtil = pageUtil;
        }
        public IEnumerable<Tuple<int, Page>> GetIndexedRootPageList()
        {
            return _pageUtil.GetIndexedRootPages().OrderBy(o => o.Item1);
        }
    }
}
