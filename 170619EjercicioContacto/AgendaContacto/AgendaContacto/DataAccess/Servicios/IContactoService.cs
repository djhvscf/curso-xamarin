using AgendaContacto.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AgendaContacto.DataAccess.Servicios
{
    public interface IContactoService
    {
        void AgregarContacto(Contacto contacto);

        Task<IEnumerable<Contacto>> ObtenerContactos();

        void EliminarContacto(Contacto contacto);
    }
}
