using System;

namespace CalculatesSavings_2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            double amountInvested = 1000;

            Console.WriteLine($"Amount Invested in savings - {amountInvested.ToString("C")}\n");

            for (int monthCounter = 1; monthCounter <= 12; monthCounter++)
            {
                amountInvested *= 1.0036;
                Console.WriteLine($"After {monthCounter} month(s), you will have {amountInvested.ToString("C")}");
            }
            Console.ReadLine();
        }
    }
}
