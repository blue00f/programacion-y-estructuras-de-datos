namespace Ejercicio09
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena;
            int[,] matriz = new int[5,5];
            int cat, depto, hs;
            int i, j;

            for(i=0; i<5; i++)
            {
                Console.WriteLine($"\nIngrese el nro de categoria:");
                cadena = Console.ReadLine();
                cat = Convert.ToInt32(cadena);
                for(j=0; j<5; j++)
                {
                    Console.WriteLine("Ingrese el nro de departamento:");
                    cadena = Console.ReadLine();
                    depto = Convert.ToInt32(cadena);

                    Console.WriteLine("Ingrese el nro de hs trabajadas:");
                    cadena = Console.ReadLine();
                    hs = Convert.ToInt32(cadena);

                    matriz[cat, depto] = matriz[cat, depto] + hs;
                }
            }

            for(i = 0; i<5; i++)
            {
                for(j = 0; j<5;j++)
                {
                    Console.WriteLine($"Categoria {i} Departamento {j} Horas {matriz[i, j]}");
                }
            }
            Console.ReadKey();
        }
    }
}