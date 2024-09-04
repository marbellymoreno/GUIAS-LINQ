using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroLinq
{
    public class Habitante
    {
        // ID único del habitante
        public int IdHabitante { get; set; }

        // Nombre del habitante
        public string Nombre { get; set; }

        // Edad del habitante
        public int Edad { get; set; }

        // ID de la casa donde vive el habitante
        public int IdCasa { get; set; }

        // Método que devuelve los datos del habitante como una cadena
        public string datosHabitante()
        {
            return $"Soy {Nombre} con edad de {Edad} años, viviendo en la casa con ID {IdCasa}";
        }
    }
}
