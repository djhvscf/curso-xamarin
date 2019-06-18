using _100619Ejercicio3.Model;
using _100619Ejercicio3.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace _100619Ejercicio3
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            var monkeys = new List<Monkey>();
            for (int i = 0; i < 100; i++)
            {
                monkeys.Add(new Monkey
                {
                    Id = i.ToString(),
                    Name = $"Monkey {i}",
                    Description = $"Monkey Desc {i}"
                });
            }

            BindingContext = new MonkeyViewModel { Monkeys = monkeys };
        }

        public void OnMore(object sender, EventArgs e)
        {
            var mi = ((MenuItem)sender);
            DisplayAlert("Más Context Action", mi.CommandParameter + " más context action", "OK");
        }

        public void OnDelete(object sender, EventArgs e)
        {
            var mi = ((MenuItem)sender);
            DisplayAlert("Eliminar Context Action", mi.CommandParameter + " eliminar context action", "OK");
        }
    }
}
