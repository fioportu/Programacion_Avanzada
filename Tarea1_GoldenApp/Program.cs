using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1_GoldenApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Pedir al usuario ingresar un número
            Console.Write("Type an integer from 2 to 45: ");
            string input = Console.ReadLine();
            int n;

            //Muestra error 
            if (!int.TryParse(input, out n) || n < 2 || n > 45)
            {
                Console.WriteLine("Input is out of range");
                return;
            }

            //Calculo de phi 
            double phiFormula = (1 + Math.Sqrt(5)) / 2;
            Console.WriteLine($"\nPhi ~ {phiFormula}");

            //Calculo de Fibonacci
            int[] fib = new int[n + 1];
            fib[0] = 0;
            fib[1] = 1;

            for (int i = 2; i <= n; i++)
            {
                fib[i] = fib[i - 1] + fib[i - 2];
            }

            //Aproximación de phi 
            for (int i = 2; i <= n; i++)
            {
                double approxPhi = (double)fib[i] / fib[i - 1];
                double diff = Math.Abs(phiFormula - approxPhi);
                Console.WriteLine($"Fib({i}) / Fib({i - 1}) ~ {approxPhi} [+- {diff}]");
            }

            //Resultado
            Console.WriteLine($"\nFib({n}) = {fib[n]}");
            Console.WriteLine($"Fib({n - 1}) = {fib[n - 1]}");

            // Salir del programa 
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}