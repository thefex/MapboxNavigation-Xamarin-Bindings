using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Java.Lang;
using Java.Util;

namespace Com.Mapbox.Android.Core
{
    public sealed partial class FileUtils
    {
        public partial class LastModifiedComparator
        {

            public int Compare(Java.Lang.Object a, Java.Lang.Object b)
            {
                return Compare(a as Java.IO.File, b as Java.IO.File);
            }
        }
    }
   
}