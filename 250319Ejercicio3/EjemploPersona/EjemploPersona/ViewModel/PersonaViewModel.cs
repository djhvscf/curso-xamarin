using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace EjemploPersona.ViewModel
{
    class PersonaViewModel : INotifyPropertyChanged
    {
        private string annoNacimiento;
        private int edad;

        public PersonaViewModel()
        {

        }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string AnnoNacimiento
        {
            get
            {
                return annoNacimiento;
            }

            set
            {
                if (int.TryParse(value, out var anno))
                {
                    annoNacimiento = anno.ToString();
                }

                OnPropertyChanged();
                OnPropertyChanged(nameof(Edad));
            }
        }

        public string Direccion { get; set; }

        public int Edad
        {
            get
            {
                var hoy = DateTime.Now.Year;
                return hoy - Convert.ToInt32(AnnoNacimiento);
                //return edad;
            }
            set
            {
                var hoy = DateTime.Now.Year;
                edad = hoy - Convert.ToInt32(AnnoNacimiento);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
