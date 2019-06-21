using Ejercicio2100619.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Ejercicio2100619.ViewModels
{
    public class MonkeyViewModel
    {
        public ObservableCollection<Monkey> Monkeys { get; set; }
        public string Header { get { return "Monkey Header"; } }
        public string Footer { get { return " Habian " + Monkeys.Count + " monkeys"; } }
    }
}
