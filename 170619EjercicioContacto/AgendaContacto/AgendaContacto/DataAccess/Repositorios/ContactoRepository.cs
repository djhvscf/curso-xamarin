using System.Collections.Generic;
using System.Threading.Tasks;
using AgendaContacto.Model;

namespace AgendaContacto.DataAccess.Repositorios
{
    public class ContactoRepository : IContactoRepository
    {
        private readonly IDatabaseHelper databaseHelper;

        public ContactoRepository (IDatabaseHelper databaseHelper)
        {
            this.databaseHelper = databaseHelper;
        }

        public async void AgregarContacto(Contacto contacto)
        {
            await databaseHelper.AgregarContacto(contacto);
        }

        public async void EliminarContacto(Contacto contacto)
        {
            await databaseHelper.EliminarContacto(contacto);
        }

        public async Task<IEnumerable<Contacto>> ObtenerContactos()
        {
            return await databaseHelper.ObtenerContactos();
        }
    }
}
