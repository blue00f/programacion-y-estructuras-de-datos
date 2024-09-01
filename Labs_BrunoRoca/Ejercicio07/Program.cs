namespace Ejercicio07
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena;
            // Primera forma de declarar un array
            int[] vecval = new int[5];
            int cat, legajo, hs, i, sueldo, total;
            total = 0;
            
            for(i=0; i<5; i++)
            {
                Console.WriteLine($"Ingrese el valor de la hs de la categoria {i}:");
                cadena = Console.ReadLine();
                vecval[i] = Convert.ToInt32(cadena);
            }

            Console.WriteLine("\nIngrese el nro de legajo:");
            cadena = Console.ReadLine();
            legajo = Convert.ToInt32(cadena);
            while (legajo != 0)
            {
                Console.WriteLine("Ingrese el nro de categoria:");
                cadena = Console.ReadLine();
                cat = Convert.ToInt32(cadena);

                Console.WriteLine("Ingrese las hs trabajadas:");
                cadena = Console.ReadLine();
                hs = Convert.ToInt32(cadena);

                sueldo = vecval[cat] * hs;
                Console.WriteLine($"El legajo {legajo} cobrara {sueldo}");
                total = total + sueldo;

                Console.WriteLine("\nIngrese el nro de legajo:");
                cadena = Console.ReadLine();
                legajo = Convert.ToInt32(cadena);
            }
            Console.WriteLine($"\nEl total a pagar por sueldos es {total}");
            Console.ReadKey();
        }
    }
}