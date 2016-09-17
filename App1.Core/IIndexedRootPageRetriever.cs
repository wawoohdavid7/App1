using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace App1.Core
{
    public interface IIndexedRootPageRetriever
    {
        IEnumerable<Tuple<int, Page>> GetIndexedRootPageList();
        
    }
}
