using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Todo
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TodoNavigationPage : NavigationPage
    {
		public TodoNavigationPage(ContentPage mainPage) : base(mainPage)
        {
            InitializeComponent();
        }
    }
}