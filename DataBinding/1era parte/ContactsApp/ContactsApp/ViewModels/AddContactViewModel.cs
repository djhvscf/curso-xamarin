using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ContactsApp.ViewModels
{
    public class AddContactViewModel
    {

        public AddContactViewModel()
        {
        }

        string nombre = "Xamarin.Fomrs";
        string website = "www.google.com";
        bool esMejorAmigo;
        bool estaOcupado = false;

        public bool EsMejorAmigo
        {
            get { return esMejorAmigo; }
            set { esMejorAmigo = value; }
        }


        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string DisplayMessage
        {
            get
            {
                return $"Tu nuevo amigo se llama {Nombre} y " +
                       $"{(esMejorAmigo ? "es" : "no es")} tu mejor amigo.";
            }
        }

        public string Website
        {
            get
            {
                return website;
            }
            set { website = value; }
        }

        public bool EstaOcupado
        {
            get { return estaOcupado; }
            set { estaOcupado = value; }
        }

        void LaunchWebsite()
        {
            try
            {
                Device.OpenUri(new Uri(website));
            }
            catch
            {

            }
        }

        async Task GuardaContacto()
        {
            EstaOcupado = true;
            await Task.Delay(4000);

            EstaOcupado = false;

            await Application.Current.MainPage.DisplayAlert("Guardar", "Contacto ha sido guardado", "OK");
        }

    }
}
