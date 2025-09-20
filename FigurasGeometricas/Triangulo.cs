using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasGeometricas
{
    internal class Triangulo: Figura
    {
        private int Base { get; set; }
        private int Altura { get; set; }
        public Triangulo(int b, int a)
        {
            Base = b;
            Altura = a;
        }

        public override double CalcularArea()
        {
            return ((Base * Altura) / 2);
        }
    }
}
