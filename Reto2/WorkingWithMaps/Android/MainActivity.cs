using Android.App;
using Android.OS;

using Xamarin.Forms.Platform.Android;
using Android.Content.PM;
using Plugin.Permissions;
using Plugin.CurrentActivity;

namespace WorkingWithMaps.Android
{

	[Activity (Label = "WorkingWithMaps.Android.Android", Icon = "@drawable/icon", Theme = "@style/MainTheme", MainLauncher = true, 
		ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : FormsAppCompatActivity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			Xamarin.Forms.Forms.Init (this, bundle);
			Xamarin.FormsMaps.Init (this, bundle);
            CrossCurrentActivity.Current.Init(this, bundle);

            LoadApplication (new App ());
		}

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, Permission[] grantResults)
        {
            PermissionsImplementation.Current.OnRequestPermissionsResult(requestCode, permissions, grantResults);
            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }

}

