using System.Runtime.CompilerServices;

namespace POO
{
    internal  class Program
    {
        static void Main(string[] args)
        {
            //Action<int,string> action = (x,y) => Console.WriteLine(x + y);
            //action(1,"world");
            //var coleccion = new Coleccion<int>(10);
            //coleccion.Agregar(8, 2);
            //coleccion.Agregar(3);
            //Console.WriteLine(coleccion.ToString());
            var persona = new Persona("Juan", 180, 30);
            Console.ReadLine();
        }

        //public static string Capitalize(this string txt)
        //{
        //    return txt.ToUpper();
        //}

        //public static int Increment(this int number, int cantidad)
        //{
        //    return number + cantidad;
        //}

        
    }
}
