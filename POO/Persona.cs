using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal abstract class Persona
    {
        public string Nombre { get; set; }
        
        public int Altura { get; set; }
        public int Edad { get; set; }

        public Persona() {
            Nombre = "NN";
            Edad= 0;
            Altura = 0;
        }
        public Persona(string nombre, int altura, int edad)
        {
            Nombre = nombre;
            Altura = altura;
            Edad = edad;
        }
        
    }
}
