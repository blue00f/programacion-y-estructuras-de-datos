namespace Ejercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            int numero2 = 0;
            Console.WriteLine("Ingrese un numero por favor: ");
            numero = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro numero por favor");
            numero2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"Entre {numero} y {numero2} hay {Math.Abs(numero2 - numero)} numeros.");
            Console.ReadKey();
        }
    }
}
