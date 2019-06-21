using _100619Ejercicio1.Model;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace _100619Ejercicio1.ViewModels
{
    public class MonkeyViewModel
    {
        public ObservableCollection<Monkey> Monkeys { get; set; }
        public string Header
        {
            get
            {
                return "Monkey Header";
            }
        }
        public string Footer
        {
            get
            {
                return " Habian " + Monkeys.Count + " monkeys";
            }
        }
    }
}
