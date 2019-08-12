using AgendaContacto.Model;
using SQLite;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AgendaContacto.DataAccess
{
    public class DatabaseHelper : IDatabaseHelper
    {
        static SQLiteAsyncConnection conn;

        public DatabaseHelper(ISQLConnection sqlConnection)
        {
            conn = sqlConnection.GetConnection();

            conn.CreateTableAsync<Contacto>();
        }

        public async Task<int> AgregarContacto (Contacto contacto)
        {
            return await conn.InsertAsync(contacto);
        }

        public async Task<IEnumerable<Contacto>> ObtenerContactos()
        {
            return await conn.Table<Contacto>().ToListAsync();
        }

        public async Task<int> EliminarContacto(Contacto contacto)
        {
            return await conn.DeleteAsync(contacto);
        }
    }
}
