using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AgendaContacto.Model;

namespace AgendaContacto.DataAccess.Servicios
{
    public class ContactoMockService : IContactoService
    {
        public void AgregarContacto(Contacto contacto)
        {
            throw new NotImplementedException();
        }

        public void EliminarContacto(Contacto contacto)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Contacto>> ObtenerContactos()
        {
            return await Task.FromResult(new List<Contacto>()
            {
                new Contacto()
                {
                    Nombre = "Unit Test",
                    Direccion = "Unit Test Dir",
                    Telefono = "89654120",
                    Id = int.MaxValue
                }
            });
        }
    }
}
