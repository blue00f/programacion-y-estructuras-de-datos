namespace Ejercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena;
            int a, b;
            Console.WriteLine("Ingresa un valor:");
            cadena = Console.ReadLine();
            a = Convert.ToInt32(cadena);
            Console.WriteLine("Ingrese otro valor:");
            cadena = Console.ReadLine();
            b = Convert.ToInt32(cadena);

            if (a == b)
            {
                Console.WriteLine($"A={a} y B={b}, son iguales");
            }
            else{
                Console.WriteLine($"A={a} y B={b}, son distintos");
            }
            if(a<b)
            {
                Console.WriteLine("El primero es menor al segundo");
            }
            else
            {
                Console.WriteLine("El segundo es menor al primero");
            }
            Console.ReadKey();
        }
    }
}