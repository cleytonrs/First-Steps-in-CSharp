using System;

namespace ForLoop
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // *
            // **
            // ***
            // ****
            // *****
            // ******
            // *******
            // ********
            // *********
            // **********

            // Writing asterisks with BREAK
            for (int lineCounter = 0; lineCounter < 10; lineCounter++)
            {
                for (int columnCounter = 0; columnCounter < 10; columnCounter++)
                {
                    Console.Write("*");
                    if (columnCounter >= lineCounter)
                    {
                        break;
                    }
                }
                Console.WriteLine();
            }

            // A different way of drawing asterisks
            for (int lineCounter = 0; lineCounter < 10; lineCounter++)
            {
                for (int columnCounter = 0; columnCounter <= lineCounter; columnCounter++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
