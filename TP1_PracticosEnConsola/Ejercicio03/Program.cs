namespace Ejercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lado1, lado2, lado3;
            Console.WriteLine("Ingrese el lado 1 del triangulo: ");
            lado1 = Int16.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el lado 2 del triangulo");
            lado2 = Int16.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el lado 3 del triangulo: ");
            lado3 = Int16.Parse(Console.ReadLine());

            Console.WriteLine($"El perimetro es igual a {lado1+lado2+lado3}");
            Console.ReadKey();
        }
    }
}
