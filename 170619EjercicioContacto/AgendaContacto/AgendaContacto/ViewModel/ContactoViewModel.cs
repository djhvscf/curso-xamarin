using AgendaContacto.Model;
using System.Collections.ObjectModel;

namespace AgendaContacto.ViewModel
{
    public class ContactoViewModel
    {
        public ObservableCollection<Contacto> Contactos { get; set; }
    }
}
