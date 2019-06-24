using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WorkingWithMaps.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MapTabs : TabbedPage
    {
        public MapTabs()
        {
            InitializeComponent();
        }
    }
}