﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1.Utils
{
   public interface IPageUtil
   {
      List<Tuple<int, Page>> GetIndexedRootPages();
   }
}
