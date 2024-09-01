namespace Ejercicio08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num=6, factorial;
            factorial = Factorial(num);
            Console.WriteLine("Factorial de 6:");
            Console.WriteLine($"{num}! = {factorial}");
        }
        static double Factorial(double numero)
        {
            if(numero == 1 || numero == 0)
            {
                return 1;
            }
            else
            {
                return numero * Factorial(numero - 1);
            }
        }
    }
}
