using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistAnimales
{
    internal class Pajaro: Animal
    {
        public override string hacerSonido()
        {
            return "Pio Pio";
        }

        public override string moverse()
        {
            return "El pájaro vuela";
        }
    }
}
