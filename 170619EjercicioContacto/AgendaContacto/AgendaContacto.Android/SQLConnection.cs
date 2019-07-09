using System;
using System.IO;
using AgendaContacto.DataAccess;
using AgendaContacto.Droid;
using SQLite;
using Xamarin.Forms;

[assembly: Dependency(typeof(SQLConnection))]
namespace AgendaContacto.Droid
{
    public class SQLConnection : ISQLConnection
    {
        public SQLiteAsyncConnection GetConnection()
        {
            var docsPath = System.Environment.GetFolderPath(
                Environment.SpecialFolder.Personal);

            var path = Path.Combine(docsPath, "agendacontacto.db3");

            return new SQLiteAsyncConnection(path);
        }
    }
}