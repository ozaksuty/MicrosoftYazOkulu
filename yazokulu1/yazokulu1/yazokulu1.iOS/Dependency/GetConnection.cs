using System;
using System.Collections.Generic;
using System.Text;
using SQLite.Net;
using yazokulu1.Dependency;
using SQLite.Net.Platform.XamarinIOS;
using yazokulu1.iOS.Dependency;

[assembly: Xamarin.Forms.Dependency(typeof(GetConnection))]
namespace yazokulu1.iOS.Dependency
{
    public class GetConnection : ISQLiteConnection
    {
        SQLiteConnection ISQLiteConnection.GetConnection()
        {
            var documentPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var path = System.IO.Path.Combine(documentPath, App.DbName);
            var platform = new SQLitePlatformIOS();
            var connection = new SQLiteConnection(platform, path);
            return connection;
        }
    }
}
