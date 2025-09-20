using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Coleccion<T>
    {
        private T[] Lista { get; set; }

        public Coleccion(int cantidad)
        {
            Lista = new T[cantidad];
        }

        public void Agregar(int indice, T elemento)
        {
            if (indice >= 0 && indice < Lista.Length)
            {
                Lista[indice] = elemento;
            }
            else
            {
                throw new IndexOutOfRangeException("Indice fuera de rango");
            }
        }

        public void Agregar(T elemento)
        {
            Lista = Lista.Append(elemento).ToArray();
        }

        public override string ToString()
        {
            return string.Join(", ", Lista);
        }

    }
}
