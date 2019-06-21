using AgendaContacto.Model;
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
    public partial class AgregarContacto : ContentPage
    {
        public AgregarContacto()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            //Agregar validaciones correspondientes
            // 1.Campos no vacios
            // 2. Nombre y telefono no existen en la lista
            var contacto = new Contacto()
            {
                Nombre = txtNombre.Text,
                Telefono = txtTelefono.Text,
                Direccion = txtDireccion.Text
            };

            //Agregarlo a la lista de contactos
        }
    }
}