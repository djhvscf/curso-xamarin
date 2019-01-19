using Ejercicio1.Utils;
using System;
using System.Reflection;
using System.Resources;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Ejercicio1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            new ResourceManager(ResourceContainer.ResourceId, typeof(App).GetTypeInfo().Assembly);
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
