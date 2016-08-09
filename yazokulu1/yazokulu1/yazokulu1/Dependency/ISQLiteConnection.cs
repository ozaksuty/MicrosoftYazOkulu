using SQLite.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yazokulu1.Dependency
{
    public interface ISQLiteConnection
    {
        SQLiteConnection GetConnection();
    }
}
