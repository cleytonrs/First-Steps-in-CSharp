using System;

namespace CalculatesSavings
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            double amountInvested = 1000;
            int monthCounter = 1;

            Console.WriteLine($"Amount Invested in savings - {amountInvested.ToString("C")}\n");

            while (monthCounter <= 12)
            {
                // 0.36% = 0.0036
                amountInvested = amountInvested + amountInvested * 0.0036;
                Console.WriteLine("After " + monthCounter + " month(s), you will have " + amountInvested.ToString("C"));
                monthCounter++;
            }
            Console.ReadLine();
        }
    }
}
