using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleados
{
    internal class Empleado
    {
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("El nombre no puede estar vacío.");
                }
                nombre = value;
            }
        }

        private int salario;

        public int Salario
        {
            get { return salario; }
            set {
                if (value < 0)
                {
                    throw new Exception("El salario no puede ser negativo");
                }
                else
                {
                    salario = value;
                }
                ;
            }
        }

        private int id;

        public int Id
        {
            get { return id; }
            set {
                if (id < 0)
                {
                    throw new Exception("El ID no puede ser negativo");
                }
                else
                {
                    id = value;
                }
                ;
            }
        }


        public Empleado(string nombre, int salario, int id)
        {
            Nombre=nombre;
            Salario=salario;
            Id=id;

        }

        public void MostrarInformacion()
        {
            Console.WriteLine($"ID: {Id}, Nombre: {Nombre}, Salario: {Salario}");
        }
    }
}
