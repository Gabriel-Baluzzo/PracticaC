namespace FigurasGeometricas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var circulo = new Circulo(5);
            Console.WriteLine($"El Area del circulo es: { circulo.CalcularArea()}");

            var triangulo = new Triangulo(4, 6);
            Console.WriteLine($"El Area del triangulo es: { triangulo.CalcularArea()}");

            var rectangulo = new Rectangulo(4, 6);
            Console.WriteLine($"El Area del rectangulo es: { rectangulo.CalcularArea()}");
        }
    }
}
