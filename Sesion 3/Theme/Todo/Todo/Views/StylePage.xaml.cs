using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Todo
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class StylePage : ContentPage
	{
        public StylePage()
        {
            InitializeComponent();
        }

        void OnApplyThemeClicked(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(backgroundColorEntry.Text))
            {
                App.Current.Resources["backgroundColor"] = Color.FromHex(backgroundColorEntry.Text);
            }

            if (!string.IsNullOrWhiteSpace(textColorEntry.Text))
            {
                App.Current.Resources["textColor"] = Color.FromHex(textColorEntry.Text);
            }

            if (!string.IsNullOrWhiteSpace(backgroundColorBarEntry.Text))
            {
                App.Current.Resources["backgroundBar"] = Color.FromHex(backgroundColorBarEntry.Text);
            }
        }

        void OnDoneButtonClicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}