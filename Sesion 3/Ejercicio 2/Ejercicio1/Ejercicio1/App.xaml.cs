using Ejercicio2.Localization;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Ejercicio2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            if (Device.RuntimePlatform == Device.iOS || Device.RuntimePlatform == Device.Android)
            {
                var ci = DependencyService.Get<ILocalize>().GetCurrentCultureInfo();
                Resx.AppResources.Culture = ci; // setea el archivo RESX
                DependencyService.Get<ILocalize>().SetLocale(ci); // setea el hilo para que este al tanto de localization
            }

            MainPage = new MainPage();
        }
    }
}
