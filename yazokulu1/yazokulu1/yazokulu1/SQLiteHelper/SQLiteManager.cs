using SQLite.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using yazokulu1.Dependency;
using yazokulu1.Models;

namespace yazokulu1.SQLiteHelper
{
    public class SQLiteManager
    {
        SQLiteConnection _sqliteConnection;

        public SQLiteManager()
        {
            _sqliteConnection = DependencyService.Get
                <ISQLiteConnection>().GetConnection();
            _sqliteConnection.CreateTable<Students>();
        }

        public int Insert(Students model)
        {
            return _sqliteConnection.Insert(model);
        }

        public IEnumerable<Students> GetAll()
        {
            return _sqliteConnection.Table<Students>();
        }
    }
}
