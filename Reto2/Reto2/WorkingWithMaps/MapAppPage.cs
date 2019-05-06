using System;
using Xamarin.Forms;

namespace WorkingWithMaps
{
	public class MapAppPage : ContentPage
	{
		public MapAppPage ()
		{
			var l = new Label {
				Text = "Estos botones cierran la aplicación actual y abre mapas"
			};

			var openLocation = new Button {
				Text = "Abrir aplicación de mapas"
			};
			openLocation.Clicked += (sender, e) => {

				if (Device.RuntimePlatform == Device.iOS) {
					//https://developer.apple.com/library/ios/featuredarticles/iPhoneURLScheme_Reference/MapLinks/MapLinks.html
					Device.OpenUri(new Uri("http://maps.apple.com/?q=394+Pacific+Ave+San+Francisco+CA"));
				} else if (Device.RuntimePlatform == Device.Android) {
					// opens the Maps app directly
					Device.OpenUri(new Uri("geo:0,0?q=394+Pacific+Ave+San+Francisco+CA"));

				}
			};

			var openDirections = new Button {
				Text = "Obtener direcciones usando la aplicación de mapas"
			};
			openDirections.Clicked += (sender, e) => {

				if (Device.RuntimePlatform == Device.iOS) {
					//https://developer.apple.com/library/ios/featuredarticles/iPhoneURLScheme_Reference/MapLinks/MapLinks.html
					Device.OpenUri(new Uri("http://maps.apple.com/?daddr=San+Francisco,+CA&saddr=cupertino"));

				} else if (Device.RuntimePlatform == Device.Android) {
					// opens the 'task chooser' so the user can pick Maps, Chrome or other mapping app
					Device.OpenUri(new Uri("http://maps.google.com/?daddr=San+Francisco,+CA&saddr=Mountain+View"));

				}
			};
			Content = new StackLayout{
				Padding = new Thickness (5, 20, 5, 0),
				HorizontalOptions = LayoutOptions.Fill,
				Children = {
					l,
					openLocation,
					openDirections
				}
			};
		}
	}
}
