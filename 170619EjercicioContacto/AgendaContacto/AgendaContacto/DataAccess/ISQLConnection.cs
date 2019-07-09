using SQLite;

namespace AgendaContacto.DataAccess
{
    public interface ISQLConnection
    {
        SQLiteAsyncConnection GetConnection();
    }
}
