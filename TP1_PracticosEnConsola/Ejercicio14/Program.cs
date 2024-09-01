namespace Ejercicio14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int difFechas;
            string fechaCadena;
            DateTime fecha1, fecha2;
            Console.WriteLine("Ingresa la primer fecha (dd/mm/aaaa): ");
            fechaCadena = Console.ReadLine();
            fecha1 = Convert.ToDateTime(fechaCadena);

            Console.WriteLine("Ingrese la segunda fecha (dd/mm/aaaa): ");
            fechaCadena = Console.ReadLine();
            fecha2 = Convert.ToDateTime(fechaCadena);

            difFechas = Math.Abs(fecha1.Subtract(fecha2).Days);
            Console.WriteLine($"La diferencia entre las fechas es de {difFechas} dias");
        }
    }
}
