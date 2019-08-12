using AgendaContacto.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AgendaContacto.DataAccess
{
    public interface IDatabaseHelper
    {
        Task<int> AgregarContacto(Contacto contacto);

        Task<IEnumerable<Contacto>> ObtenerContactos();

        Task<int> EliminarContacto(Contacto contacto);
    }
}
