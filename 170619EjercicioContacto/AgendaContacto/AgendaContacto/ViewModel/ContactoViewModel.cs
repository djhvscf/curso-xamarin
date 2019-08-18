using AgendaContacto.DataAccess.Servicios;
using AgendaContacto.Model;
using AgendaContacto.Views;
using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AgendaContacto.ViewModel
{
    [Preserve]
    public class ContactoViewModel : BaseViewModel
    {
        public ObservableCollection<Contacto> Contactos { get; set; }
        public Command CargarContactosCommand { get; set; }

        private readonly IContactoService service;

        public ContactoViewModel(IContactoService service)
        {
            this.service = service;
            Contactos = new ObservableCollection<Contacto>();
            CargarContactosCommand = new Command(async () => await ExecuteLoadItemsCommand());

            MessagingCenter.Subscribe<AgregarContacto, Contacto>(this, MessageKeys.AgregarContacto, async (obj, contacto) =>
            {
                var _contacto = contacto as Contacto;
                this.service.AgregarContacto(_contacto);
                CargarContactosCommand.Execute(null);
            });

            MessagingCenter.Subscribe<ListaContacto, Contacto>(this, MessageKeys.EliminarContacto, async (obj, contacto) =>
            {
                var _contacto = contacto as Contacto;
                this.service.EliminarContacto(_contacto);
                CargarContactosCommand.Execute(null);
            });
        }

        async Task ExecuteLoadItemsCommand()
        {
            if (IsBusy)
            {
                return;
            }

            IsBusy = true;

            try
            {
                Contactos.Clear();
                var items = await this.service.ObtenerContactos();
                foreach (var item in items)
                {
                    Contactos.Add(item);
                }
            }
            catch (Exception)
            {
                // Log errores
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}
