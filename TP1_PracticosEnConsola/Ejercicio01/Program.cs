namespace Ejercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Numero = 0;
            int Numero2 = 0;
            Console.WriteLine("Ingrese un numero por favor: ");
            Numero = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro numero por favor: ");
            Numero2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("La suma es {0} ", Numero+Numero2);
            Console.ReadKey();
        }
    }
}
