namespace Ejercicio15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime fechaHoy = DateTime.Now;
            DateTime fechaNavidad = new DateTime(2024,12,25);
            int difDias;
            
            difDias = fechaNavidad.Subtract(fechaHoy).Days;
            Console.WriteLine($"Faltan {difDias} dias para navidad!");           
        }
    }
}
