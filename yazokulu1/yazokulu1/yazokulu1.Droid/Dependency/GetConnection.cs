
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
using SQLite.Net;
using yazokulu1.Dependency;
using SQLite.Net.Platform.XamarinAndroid;
using yazokulu1.Droid.Dependency;

[assembly: Xamarin.Forms.Dependency(typeof(GetConnection))]
namespace yazokulu1.Droid.Dependency
{
    public class GetConnection : ISQLiteConnection
    {
        SQLiteConnection ISQLiteConnection.GetConnection()
        {
            string documentPath = System.Environment.
                GetFolderPath(System.
                Environment.SpecialFolder.Personal);
            var path = System.IO.Path.Combine(documentPath, 
                App.dbName);
            var platform = new SQLitePlatformAndroid();
            var connection = new SQLiteConnection(platform, 
                path);
            return connection;
        }
    }
}