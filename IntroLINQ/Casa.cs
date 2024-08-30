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
        public int Id { get; set; }
        public string Direccion { get; set; }
        public string Ciudad { get; set; }
        public int numeroHabitaciones { get; set; }

        public string datosCasa()
        {
            return $"La direccion es {Direccion}, en la ciudad{Ciudad}";
        }
    }
}
