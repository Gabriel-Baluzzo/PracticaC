namespace SistAnimales
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            var perro = new Perro();
            var pajaro = new Pajaro();
            Console.WriteLine(perro.hacerSonido());
            Console.WriteLine(perro.moverse());
            Console.WriteLine(pajaro.hacerSonido());
            Console.WriteLine(pajaro.moverse());
        }
    }
}
