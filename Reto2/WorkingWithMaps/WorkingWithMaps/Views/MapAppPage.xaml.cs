using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WorkingWithMaps.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MapAppPage : ContentPage
    {
        public MapAppPage()
        {
            InitializeComponent();
        }

        private void OpenLocation_Clicked(object sender, EventArgs e)
        {
            if (Device.RuntimePlatform == Device.iOS)
            {
                //https://developer.apple.com/library/ios/featuredarticles/iPhoneURLScheme_Reference/MapLinks/MapLinks.html
                Device.OpenUri(new Uri("http://maps.apple.com/?q=394+Pacific+Ave+San+Francisco+CA"));
            }
            else if (Device.RuntimePlatform == Device.Android)
            {
                // opens the Maps app directly
                Device.OpenUri(new Uri("geo:0,0?q=394+Pacific+Ave+San+Francisco+CA"));

            }
        }

        private void OpenDirections_Clicked(object sender, EventArgs e)
        {
            if (Device.RuntimePlatform == Device.iOS)
            {
                //https://developer.apple.com/library/ios/featuredarticles/iPhoneURLScheme_Reference/MapLinks/MapLinks.html
                Device.OpenUri(new Uri("http://maps.apple.com/?daddr=San+Francisco,+CA&saddr=cupertino"));

            }
            else if (Device.RuntimePlatform == Device.Android)
            {
                // opens the 'task chooser' so the user can pick Maps, Chrome or other mapping app
                Device.OpenUri(new Uri("http://maps.google.com/?daddr=San+Francisco,+CA&saddr=Mountain+View"));

            }
        }
    }
}