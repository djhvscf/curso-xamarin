using AgendaContacto.DataAccess;
using AgendaContacto.DataAccess.Repositorios;
using AgendaContacto.Model;
using AgendaContacto.Utils;
using AgendaContacto.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
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
            contactoRepository = new ContactoRepository();

            MessagingCenter.Subscribe<AgregarContacto, Contacto>(this, "AgregarContacto", async (obj, contacto) =>
            {
                var _contacto = contacto as Contacto;
                contactoRepository.AgregarContacto(_contacto);
                CargarContactosCommand.Execute(null);
            });

            MessagingCenter.Subscribe<ListaContacto, Contacto>(this, "EliminarContacto", async (obj, contacto) =>
            {
                var _contacto = contacto as Contacto;
                contactoRepository.EliminarContacto(_contacto);
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
                var items = await contactoRepository.ObtenerContactos();
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
