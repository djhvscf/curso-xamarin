using AgendaContacto.Model;
using AgendaContacto.ViewModel;
using Autofac;
using System;
using System.Collections.Generic;

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
            BindingContext = viewModel = App.Container.Resolve<ContactoViewModel>();
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

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            List<Color> colors = new List<Color>()
            {
                Color.Red,
                Color.Purple,
                Color.RoyalBlue,
                Color.Cyan
            };

            Random r = new Random();
            this.Resources["listViewBackground"] = colors[r.Next(colors.Count - 1)];
        }

        private void Elimnar_Clicked(object sender, EventArgs e)
        {
            var contacto = ((MenuItem)sender).CommandParameter as Contacto;
            MessagingCenter.Send(this, MessageKeys.EliminarContacto, contacto);
        }
    }
}