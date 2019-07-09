using System;
using System.IO;
using AgendaContacto.DataAccess;
using AgendaContacto.iOS;
using SQLite;
using Xamarin.Forms;

[assembly: Dependency(typeof(SQLConnection))]
namespace AgendaContacto.iOS
{
    public class SQLConnection : ISQLConnection
    {
        public SQLiteAsyncConnection GetConnection()
        {
            var docsPath = System.Environment.GetFolderPath(
                Environment.SpecialFolder.Personal);

            var libsPath = Path.Combine(docsPath, "..", "Library");

            var path = Path.Combine(libsPath, "agendacontacto.db3");

            return new SQLiteAsyncConnection(path);       }
    }
}