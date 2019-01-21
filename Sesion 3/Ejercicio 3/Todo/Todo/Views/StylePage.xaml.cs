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
            //....complete la logica faltante
            if (!string.IsNullOrWhiteSpace(backgroundColorEntry.Text))
            {
                
            }
        }

        void OnDoneButtonClicked(object sender, EventArgs e)
        {
            //Utilice Navigation para volver al view anterior
        }
    }
}