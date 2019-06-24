using AgendaContacto.Model;
using System;

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

        private async void Button_Clicked(object sender, EventArgs e)
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

            MessagingCenter.Send(this, "AgregarContacto", contacto);
            await Navigation.PopAsync();
        }
    }
}