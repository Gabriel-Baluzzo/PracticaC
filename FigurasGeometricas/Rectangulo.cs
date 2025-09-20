using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasGeometricas
{
    internal class Rectangulo: Figura
    {
        private int Base { get; set; }
        private int Altura { get; set; }

        public Rectangulo(int a, int b) {
            Base = b;
            Altura = a;
        }

        public override double CalcularArea()
        {
            return (Base * Altura);
        }
    }
}
