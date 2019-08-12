using System.Collections.Generic;
using System.Threading.Tasks;
using AgendaContacto.DataAccess.Repositorios;
using AgendaContacto.Model;

namespace AgendaContacto.DataAccess.Servicios
{
    public class ContactoService : IContactoService
    {
        private readonly IContactoRepository repository;

        public ContactoService(IContactoRepository repository)
        {
            this.repository = repository;
        }

        public void AgregarContacto(Contacto contacto)
        {
            this.repository.AgregarContacto(contacto);
        }

        public void EliminarContacto(Contacto contacto)
        {
            this.repository.EliminarContacto(contacto);
        }

        public async Task<IEnumerable<Contacto>> ObtenerContactos()
        {
            return await this.repository.ObtenerContactos().ConfigureAwait(false);
        }
    }
}
