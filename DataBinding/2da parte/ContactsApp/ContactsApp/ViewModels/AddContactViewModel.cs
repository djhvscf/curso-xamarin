using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ContactsApp.ViewModels
{
    public class AddContactViewModel : INotifyPropertyChanged
    {

        public AddContactViewModel()
        {
        }

        string nombre = "Xamarin.Forms";
        string website = "http://www.google.com";
        bool esMejorAmigo;
        bool estaOcupado = false;

        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }


        public bool EsMejorAmigo
        {
            get { return esMejorAmigo; }
            set
            {
                esMejorAmigo = value;
                OnPropertyChanged();

                OnPropertyChanged(nameof(DisplayMessage));
            }
        }


        public string Nombre
        {
            get { return nombre; }
            set
            {
                nombre = value;

                if (nombre == "android")
                {
                    estaOcupado = true;
                }
                else
                {
                    estaOcupado = false;
                }
               
                OnPropertyChanged();

                OnPropertyChanged(nameof(DisplayMessage));
                OnPropertyChanged(nameof(EstaOcupado));
            }
        }

        public string DisplayMessage
        {
            get
            {
                return $"Tu nuevo amigo se llama {Nombre} y " +
                     $"{(EsMejorAmigo ? "es" : "no es")} tu mejor amigo.";
            }
        }

        public string Website
        {
            get
            {
                return website;
            }
            set
            {
                website = value;
                OnPropertyChanged();
            }
        }

        public bool EstaOcupado
        {
            get { return estaOcupado; }
            set
            {
                estaOcupado = value;

                OnPropertyChanged();
                LaunchWebsiteCommand.ChangeCanExecute();
                GuardarContactoCommand.ChangeCanExecute();
            }
        }


        public Command LaunchWebsiteCommand { get; }
        public Command GuardarContactoCommand { get; }

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
