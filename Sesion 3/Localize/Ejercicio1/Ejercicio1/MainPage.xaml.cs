using System;
using Xamarin.Forms;

namespace Ejercicio2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            OpenBrowser();
        }

        public void OpenBrowser()
        {
            Device.OpenUri(new Uri(urlText.Text));
        }
    }
}
