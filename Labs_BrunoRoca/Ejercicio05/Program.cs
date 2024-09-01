namespace Ejercicio05
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena;
            int a, i, total;
            total = 0;
            for (i = 0; i < 4; i++)
            {
                Console.WriteLine("Ingrese un valor:");
                cadena = Console.ReadLine();
                a = Convert.ToInt32(cadena);
                total += a;
            }
            Console.WriteLine($"El total de la suma es {total}");
            Console.ReadKey();
        }
    }
}