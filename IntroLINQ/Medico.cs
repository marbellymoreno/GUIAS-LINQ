using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroLINQ
{
    // Clase Medico que hereda de Empleado
    public class Medico : Empleado
    {
        // Nombre del médico
        public new string nombre { get; set; }
    }
}