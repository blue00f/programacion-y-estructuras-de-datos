namespace Ejercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena;
            int a, b, c;

            Console.WriteLine("Ingrese el valor de la hora:");
            cadena = Console.ReadLine();
            a = Convert.ToInt32(cadena);

            Console.WriteLine("Ingrese el tiempo trabajado:");
            cadena = Console.ReadLine();
            b = Convert.ToInt32(cadena);

            c = a * b;
            Console.WriteLine($"El sueldo es {c}");
            Console.ReadKey();
        }
    }
}