using AgendaContacto.Utils;
using AgendaContacto.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AgendaContacto.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListaContacto : ContentPage
    {
        public ListaContacto()
        {
            InitializeComponent();
            BindingContext = new ContactoViewModel()
            {
                Contactos = GeneradorContacto.CrearContactos()
            };
        }
    }
}