using AgendaContacto.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace AgendaContacto.Utils
{
    public class GeneradorContacto
    {
        private static List<string> nombres = new List<string>()
        {
            "Carlos", "Ivannia", "Guillermo", "Francisca"
        };

        private static List<string> apellidos = new List<string>()
        {
            "Montemagno", "Orozco", "Volio", "Conejo"
        };

        public static ObservableCollection<Contacto> CrearContactos()
        {
            var random = new Random();
            var contactos = new ObservableCollection<Contacto>();
            for (int i = 0; i < 10; i++)
            {
                var nombre = nombres[random.Next(nombres.Count - 1)];
                var apellido = apellidos[random.Next(apellidos.Count - 1)];
                var telefono = "(506) 22585585";
                var contacto = new Contacto()
                {
                    Nombre = nombre + " " + apellido,
                    Telefono = telefono,
                    Direccion = string.Empty
                };
                contactos.Add(contacto);
            }

            return contactos;
        }
    }
}
