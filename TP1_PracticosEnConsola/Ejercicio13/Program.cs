namespace Ejercicio13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fechaCadena;
            DateTime fecha;
            Console.WriteLine("Ingresa una fecha dd/mm/aaaa");
            fechaCadena = Console.ReadLine();
            fecha = Convert.ToDateTime(fechaCadena);

            Console.WriteLine("Formato AAAAMMDD:");
            Console.WriteLine(fecha.ToString("yyyyMMdd"));
            Console.ReadKey();
        }
    }
}
