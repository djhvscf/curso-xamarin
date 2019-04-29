using BrisaFresca.ViewModels;
using Xamarin.Forms;

namespace BrisaFresca
{
    public partial class App : Application
    {
        public static MainViewModel ViewModel;

        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
