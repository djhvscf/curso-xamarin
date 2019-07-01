using AgendaContacto.Model;
using Plugin.LocalNotifications;
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
            CrossLocalNotifications.Current.Show($"Llamar al contacto",
                $"Recuerde llamar a {contacto.Nombre}. Tel: {contacto.Telefono}",
                0,
                DateTime.Now.AddSeconds(5));
            await Navigation.PopAsync();
        }
    }
}