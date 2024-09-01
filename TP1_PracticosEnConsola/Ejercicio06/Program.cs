namespace Ejercicio06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double circunferencia;
            Console.WriteLine("Inserte la circunferencia del circulo");
            circunferencia = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"El diametro del circulo es: {(circunferencia/Math.PI):F2}");
            Console.ReadKey();
        }
    }
}
