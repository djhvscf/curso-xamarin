using System;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace WorkingWithMaps
{
    public class MapPage : ContentPage
    {
        Map map;

        public MapPage()
        {
            map = new Map
            {
                HeightRequest = 100,
                WidthRequest = 960,
                VerticalOptions = LayoutOptions.FillAndExpand
            };

            map.MoveToRegion(new MapSpan(new Position(0, 0), 360, 360));

            var slider = new Slider(1, 18, 1);
            slider.ValueChanged += (sender, e) =>
            {
                var zoomLevel = e.NewValue;
                var latlongdegrees = 360 / (Math.Pow(2, zoomLevel));
                if (map.VisibleRegion != null)
                    map.MoveToRegion(new MapSpan(map.VisibleRegion.Center, latlongdegrees, latlongdegrees));
            };

            var street = new Button { Text = "Street" };
            var hybrid = new Button { Text = "Hybrid" };
            var satellite = new Button { Text = "Satellite" };
            street.Clicked += HandleClicked;
            hybrid.Clicked += HandleClicked;
            satellite.Clicked += HandleClicked;
            var segments = new StackLayout
            {
                Spacing = 30,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                Orientation = StackOrientation.Horizontal,
                Children = { street, hybrid, satellite }
            };

            var stack = new StackLayout { Spacing = 0 };
            stack.Children.Add(map);
            stack.Children.Add(slider);
            stack.Children.Add(segments);
            Content = stack;
        }

        void HandleClicked(object sender, EventArgs e)
        {
            var b = sender as Button;
            switch (b.Text)
            {
                case "Street":
                    map.MapType = MapType.Street;
                    break;
                case "Hybrid":
                    map.MapType = MapType.Hybrid;
                    break;
                case "Satellite":
                    map.MapType = MapType.Satellite;
                    break;
            }
        }
    }
}
