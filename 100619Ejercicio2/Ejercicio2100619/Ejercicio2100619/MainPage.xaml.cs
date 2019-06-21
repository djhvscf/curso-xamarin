using Ejercicio2100619.Model;
using Ejercicio2100619.ViewModels;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Xamarin.Forms;

namespace Ejercicio2100619
{
    public partial class MainPage : ContentPage
    {
        ObservableCollection<Monkey> monkeys = new ObservableCollection<Monkey>();
        public MainPage()
        {
            InitializeComponent();
            for (int i = 0; i < 100; i++)
            {
                monkeys.Add(new Monkey { Name = $"Monkey {i}", Description = $"Monkey Desc {i}" });
            }

            BindingContext = new MonkeyViewModel { Monkeys = monkeys };
        }

        private void ListView_Refreshing(object sender, System.EventArgs e)
        {
            monkeys.RemoveAt(0);
            listView.IsRefreshing = false;
        }
    }
}
