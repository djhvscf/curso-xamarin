using Plugin.Permissions;
using Plugin.Permissions.Abstractions;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;

namespace WorkingWithMaps.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MapPage : ContentPage
    {
        public MapPage()
        {
            InitializeComponent();
            RequestLocationPermissions();
            initMiMapa();
        }

        private void initMiMapa()
        {
            miMapa.MoveToRegion(new MapSpan(new Position(0, 0), 360, 360));
        }

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            var zoomLevel = e.NewValue; // between 1 and 18
            var latlongdegrees = 360 / (Math.Pow(2, zoomLevel));
            if (miMapa.VisibleRegion != null)
                miMapa.MoveToRegion(new MapSpan(miMapa.VisibleRegion.Center, latlongdegrees, latlongdegrees));
        }

        private void HandleClicked(object sender, EventArgs e)
        {
            var b = sender as Button;
            switch (b.Text)
            {
                case "Street":
                    miMapa.MapType = MapType.Street;
                    break;
                case "Hybrid":
                    miMapa.MapType = MapType.Hybrid;
                    break;
                case "Satellite":
                    miMapa.MapType = MapType.Satellite;
                    break;
            }
        }

        async void RequestLocationPermissions()
        {
            var status = await CrossPermissions.Current.CheckPermissionStatusAsync(Permission.Storage);
            if (status != PermissionStatus.Granted)
            {
                status = await Utils.CheckPermissions(Permission.Location);
            }
        }
    }
}