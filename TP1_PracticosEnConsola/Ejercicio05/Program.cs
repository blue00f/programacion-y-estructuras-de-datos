namespace Ejercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int baseRec, alturaRec;
            Console.WriteLine("Ingrese la base del rectangulo: ");
            baseRec = Int16.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la altura del rectangulo: ");
            alturaRec = Int16.Parse(Console.ReadLine());

            Console.WriteLine($"La superficie del rectangulo es {baseRec*alturaRec} unidades cuadradas");
            Console.ReadKey();
        }
    }
}
