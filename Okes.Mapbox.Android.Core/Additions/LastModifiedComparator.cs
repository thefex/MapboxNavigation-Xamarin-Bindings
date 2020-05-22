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

namespace Okes.Mapbox.Android.Core.Additions
{
    public partial class LastModifiedComparator 
    {
     
        public int Compare(Java.IO.File a, Java.IO.File b)
        {
           return Compare(a, b);
            
        }
             
    }
}