using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasGeometricas
{
    internal class Circulo : Figura
    {
        private int Radio { get; set; }
        public Circulo(int radio)
        {
            Radio = radio;
        }
        
        public override double CalcularArea()
        {
            return (Math.PI * Radio * Radio);
        }
    }
}
