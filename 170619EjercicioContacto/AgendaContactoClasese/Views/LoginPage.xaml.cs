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
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNombreUsuario.Text)
                || !string.IsNullOrWhiteSpace(txtContrasenna.Text))
            {
                Navigation.PushAsync(new ListaContacto());
            }
            else
            {
                DisplayAlert("Datos incorrectos", "El nombre de usuario o contraseña es incorrecto", "Ok");
            }
        }
    }
}