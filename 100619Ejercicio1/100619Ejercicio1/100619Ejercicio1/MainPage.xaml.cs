using _100619Ejercicio1.Model;
using _100619Ejercicio1.ViewModels;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace _100619Ejercicio1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            var monkeys = new ObservableCollection<Monkey>();
            for (int i = 0; i < 100; i++)
            {
                monkeys.Add(new Monkey
                {
                    Name = $"Monkey {i}",
                    Description = $"Monkey Desc {i}",
                    Image = ImageSource.FromFile("monkey.jpg")
                });
            }
            
            BindingContext = new MonkeyViewModel { Monkeys = monkeys };
        }

        void OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e == null)
            {
                return;
            }
            ((ListView)sender).SelectedItem = null; // de-seleccionar la fila
        }
    }
}
