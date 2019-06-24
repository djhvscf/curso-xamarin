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
        ContactoViewModel viewModel;

        public ListaContacto()
        {
            InitializeComponent();
            BindingContext = viewModel = new ContactoViewModel();
        }

        private void Add_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AgregarContacto());
        }

        private void ListaContactos_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            listaContactos.SelectedItem = null;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (viewModel.Contactos.Count == 0)
            {
                viewModel.CargarContactosCommand.Execute(null);
            }
        }

        private void ListaContactos_Refreshing(object sender, EventArgs e)
        {
            listaContactos.IsRefreshing = this.IsBusy;
        }
    }
}