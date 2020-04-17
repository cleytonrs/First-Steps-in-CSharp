using System;

namespace Factorial
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            double result = 1;

            for (double j = 1; j <= 10; j++)
            {
                result *= j;
                Console.WriteLine($"{j}! = {result}");
            }
            Console.ReadLine();
        }
    }
}
