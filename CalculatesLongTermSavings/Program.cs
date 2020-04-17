using System;

namespace CalculatesLongTermSavings
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            double amountInvested = 1000;
            double yieldFactor = 1.0036;

            Console.WriteLine($"Amount Invested in savings - {amountInvested.ToString("C")}\n");

            for (int yearCounter = 1; yearCounter <= 5; yearCounter++)
            {
                for (int monthCounter = 1; monthCounter <= 12; monthCounter++)
                {
                    amountInvested *= yieldFactor;
                }
                yieldFactor += 0.0010;
                Console.WriteLine($"After {yearCounter} year(s), you will have {amountInvested.ToString("C")}");
            }
            Console.ReadLine();
        }
    }
}
