using BrisaFresca.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BrisaFresca
{
    public partial class App : Application
    {
        public static MainViewModel ViewModel;
        public static string APPID = "07ec2dc9d9f2f4c4f8da6f00a989dc74";

        public App()
        {
            InitializeComponent();

            MainPage = new TestPage();
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
