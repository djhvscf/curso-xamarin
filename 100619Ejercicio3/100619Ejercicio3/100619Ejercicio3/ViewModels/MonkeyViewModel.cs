using _100619Ejercicio3.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace _100619Ejercicio3.ViewModels
{
    public class MonkeyViewModel
    {
        public List<Monkey> Monkeys { get; set; }
        public string Header { get { return "Monkey Header"; } }
        public string Footer { get { return " Habian " + Monkeys.Count + " monkeys"; } }
    }
}
