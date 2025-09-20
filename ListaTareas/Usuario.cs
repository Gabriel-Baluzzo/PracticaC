using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaTareas
{
    internal class Usuario
    {
        public string Nombre { get; private set; }

        public Usuario(string nombre) {
            Nombre = nombre;
        }
    }
}
