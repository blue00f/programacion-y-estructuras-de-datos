namespace Ejercicio08
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena;
            // Segunda forma de declarar un array
            int[] vecVal = Enumerable.Repeat(0, 5).ToArray();
            int[] vecCant = Enumerable.Repeat(0, 5).ToArray();
            int cat, legajo, hs, i, sueldo, total;
            total = 0;

            for(i=0; i<5; i++)
            {
                Console.WriteLine($"Ingrese el valor de las hr de la categoria {i}");
                cadena = Console.ReadLine();
                vecVal[i] = Convert.ToInt32(cadena);
            }

            Console.WriteLine("\nIngrese el nro de legajo:");
            cadena = Console.ReadLine();
            legajo = Convert.ToInt32(cadena);
            while(legajo != 0)
            {
                Console.WriteLine("Ingrese el nro de categoria:");
                cadena = Console.ReadLine();
                cat = Convert.ToInt32(cadena);

                Console.WriteLine("Ingrese el nro de hs trabajadas:");
                cadena = Console.ReadLine();
                hs = Convert.ToInt32(cadena);

                sueldo = vecVal[cat] * hs;
                Console.WriteLine($"El legajo {legajo} cobrara {sueldo}");
                total = total + sueldo;
                vecCant[cat] = vecCant[cat] + 1;

                Console.WriteLine("\nIngrese el nro de legajo:");
                cadena = Console.ReadLine();
                legajo = Convert.ToInt32(cadena);
            }

            Console.WriteLine("\n------------------------------");
            for(i=0; i<5; i++)
            {
                Console.WriteLine($"De la categoria {i} hay {vecCant[i]} empleados");
            }
            Console.WriteLine($"\nEl total a pagar por sueldos es {total}");
            Console.ReadKey();
        }
    }
}