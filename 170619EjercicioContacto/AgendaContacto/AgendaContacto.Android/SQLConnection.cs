using System;
using System.IO;
using AgendaContacto.DataAccess;
using SQLite;

namespace AgendaContacto.Droid
{
    public class SQLConnection : ISQLConnection
    {
        public SQLiteConnection GetConnection()
        {
            var docsPath = System.Environment.GetFolderPath(
                Environment.SpecialFolder.Personal);

            var path = Path.Combine(docsPath, "agendacontacto.db3");

            return new SQLiteConnection(path);
        }
    }
}