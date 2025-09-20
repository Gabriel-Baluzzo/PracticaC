using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistAnimales
{
    internal class Perro: Animal
    {
        public override string hacerSonido()
        {
            return "Guau Guau";
        }
        public override string moverse()
        {
            return "El perro corre";
        }
    }

}
