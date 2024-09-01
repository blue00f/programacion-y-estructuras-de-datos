namespace Ejercicio11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string frase;
            Console.WriteLine("Ingrese una frase: ");
            frase = Console.ReadLine();
            Console.WriteLine($"La frase {frase} tiene {frase.Length} caracteres");
            Console.ReadKey();
        }
    }
}
