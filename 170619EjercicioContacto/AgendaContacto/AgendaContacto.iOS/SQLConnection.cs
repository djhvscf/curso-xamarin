using System;
using System.IO;
using AgendaContacto.DataAccess;
using SQLite;

namespace AgendaContacto.iOS
{
    public class SQLConnection : ISQLConnection
    {
        public SQLiteConnection GetConnection()
        {
            var docsPath = System.Environment.GetFolderPath(
                Environment.SpecialFolder.Personal);

            var libsPath = Path.Combine(docsPath, "..", "Library");

            var path = Path.Combine(libsPath, "agendacontacto.db3");

            return new SQLiteConnection(path);       }
    }
}