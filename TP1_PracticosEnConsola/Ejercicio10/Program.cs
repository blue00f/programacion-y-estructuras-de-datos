namespace Ejercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string frase;
            string fraseMitad1, fraseMitad2;
            Console.WriteLine("Ingrese una frase: ");
            frase = Console.ReadLine();

            // Substring(indiceComienzo, cantidadDeCaracteresATomar)
            fraseMitad1 = frase.Substring(0, frase.Length/2);
            fraseMitad2 = frase.Substring(frase.Length/2, frase.Length/2);

            Console.WriteLine($"{fraseMitad2}{fraseMitad1}");
            Console.ReadKey();
        }
    }
}
