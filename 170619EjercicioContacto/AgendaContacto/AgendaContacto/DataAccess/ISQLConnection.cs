using SQLite;

namespace AgendaContacto.DataAccess
{
    public interface ISQLConnection
    {
        SQLiteConnection GetConnection();
    }
}
