using AgendaContacto.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AgendaContacto.DataAccess.Repositorios
{
    public interface IContactoRepository
    {
        void AgregarContacto(Contacto contacto);

        Task<IEnumerable<Contacto>> ObtenerContactos();

        void EliminarContacto(Contacto contacto);
        // Actualizar contacto
        // Eliminar contacto
    }
}
