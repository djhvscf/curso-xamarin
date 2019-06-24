using AgendaContacto.Model;
using AgendaContacto.Utils;
using AgendaContacto.Views;
using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AgendaContacto.ViewModel
{
    public class ContactoViewModel : BaseViewModel
    {
        public ObservableCollection<Contacto> Contactos { get; set; }
        public Command CargarContactosCommand { get; set; }

        public ContactoViewModel()
        {
            Contactos = new ObservableCollection<Contacto>();
            CargarContactosCommand = new Command(async () => await ExecuteLoadItemsCommand());

            MessagingCenter.Subscribe<AgregarContacto, Contacto>(this, "AgregarContacto", async (obj, contacto) =>
            {
                var _contacto = contacto as Contacto;
                Contactos.Add(_contacto);
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
                var items = await GeneradorContacto.CrearContactos();
                foreach (var item in items)
                {
                    Contactos.Add(item);
                }
            }
            catch (Exception ex)
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
