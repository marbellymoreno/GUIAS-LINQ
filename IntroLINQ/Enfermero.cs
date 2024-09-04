using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroLINQ
{
    // Clase Enfermero que hereda de Empleado
    public class Enfermero : Empleado
    {
        // Nombre del enfermero
        public new string nombre { get; set; }
    }
}