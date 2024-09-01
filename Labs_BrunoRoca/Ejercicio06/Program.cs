namespace Ejercicio06
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena;
            int legajo, sueldo, total, cont;
            float promedio;
            total = cont = 0;
            promedio = 0;

            Console.WriteLine("Ingrese el legajo:");
            cadena = Console.ReadLine();
            legajo = Convert.ToInt32(cadena);
            while (legajo != 0)
            {
                Console.WriteLine($"LEG{legajo} - Ingrese el sueldo:");
                cadena = Console.ReadLine();
                sueldo = Convert.ToInt32(cadena);
                total = total + sueldo;
                cont = cont + 1;

                Console.WriteLine("Ingrese el legajo:");
                cadena = Console.ReadLine();
                legajo = Convert.ToInt32(cadena);
            }
            Console.WriteLine($"El total pagado es: {total}");
            Console.ReadKey();
            promedio = (float)(total / cont);
            Console.WriteLine($"El sueldo promedio es: {promedio:F2}");
            Console.WriteLine("El sueldo promedio es: {0,2:F2}", promedio);
            Console.ReadKey();
        }
    }
}