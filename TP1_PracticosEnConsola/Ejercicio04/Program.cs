namespace Ejercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lado1, lado2;
            Console.WriteLine("Ingrese uno de los lados del cuadrado: ");
            lado1 = Int16.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro de los lados del cuadrado: ");
            lado2 = Int16.Parse(Console.ReadLine());

            Console.WriteLine($"La superficie del cuadrado es {lado1*lado2} unidades cuadradas");
            Console.ReadKey();
        }
    }
}
