namespace Ejercicio09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string frase1;
            string frase2;

            Console.WriteLine("Ingrese una frase: ");
            frase1 = Console.ReadLine();
            Console.WriteLine("Ingrese otra frase: ");
            frase2 = Console.ReadLine();

            Console.WriteLine($"{frase1} {frase2}");
        }
    }
}
