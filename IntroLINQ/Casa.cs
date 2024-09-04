using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace IntroLINQ
{
    public class Casa
    {
        // ID de la casa
        public int Id { get; set; }

        // Dirección de la casa
        public string Direccion { get; set; }

        // Ciudad donde está ubicada la casa
        public string Ciudad { get; set; }

        // Número de habitaciones de la casa
        public int numeroHabitaciones { get; set; }

        // Método que devuelve los datos de la casa como una cadena
        public string dameDatosCasa()
        {
            return $"Dirección es {Direccion} en la ciudad de {Ciudad} con número de habitaciones {numeroHabitaciones}";
        }
    }
}