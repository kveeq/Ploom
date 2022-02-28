using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Ploom.Db;
using Ploom.Droid;
using Xamarin.Forms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Ploom.Droid
{
    class SQlite_Android
    {
        public SQlite_Android() { }
        public string GetDatabasePath(string filename)
        {
            string documentPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var path = Path.Combine(documentPath, filename);
            return path;
        }
    }
}