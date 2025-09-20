using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Hijo : Persona
    {
        public string Colegio { get; set; }
        public Hijo(string nombre, int altura, int edad, string colegio) : base(nombre, altura, edad)
        {
            Colegio = colegio;
        }
    }
}
