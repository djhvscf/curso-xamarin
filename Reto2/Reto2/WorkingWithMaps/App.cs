using Xamarin.Forms;

namespace WorkingWithMaps
{
	public class App : Application
	{
		public App ()
		{
            var tabs = new TabbedPage ();

			tabs.Children.Add (new MapPage {Title = "Map/Zoom", Icon = "glyphish_74_location.png"});

			tabs.Children.Add (new MapAppPage {Title = "Map App", Icon = "glyphish_103_map.png"});

			MainPage = tabs;
		}
    }
}

