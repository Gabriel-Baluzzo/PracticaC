namespace Empleados
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            var empleado1 = new Empleado("Juan Perez", 3000, 1);
            empleado1.MostrarInformacion();
        }
    }
}
