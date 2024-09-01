namespace Ejercicio07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pesoKB, pesoBits;
            Console.WriteLine("Ingrese el peso en KBytes: ");
            pesoKB = Convert.ToDouble(Console.ReadLine());
            pesoBits = ConversorKBaBits(pesoKB);

            Console.WriteLine($"{pesoKB} KBytes es igual a {pesoBits} bits");
            Console.ReadKey();
        }

        static double ConversorKBaBits(double pesoKB)
        {
            // Primero paso de KBytes a Bytes, multiplicandolo por 2 elevado a 10, que es el multiplicador de K
            // Despues al resultado en Bytes lo multiplico por 8 para pasarlo a bits
            return (pesoKB * Math.Pow(2, 10)) * 8;
        }
    }
}
