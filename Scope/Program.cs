using System;

namespace Scope
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int ageOfMary = 18;
            bool accompanied = true;
            string additionalMessage;

            Console.WriteLine($"Name: Mary \nAge: {ageOfMary} \nAccompanied: {accompanied} \n");

            if (accompanied == true)
            {
                additionalMessage = "Mary is accompanied";
            }
            else
            {
                additionalMessage = "Mary is not accompanied";
            }

            if (ageOfMary >= 18 && accompanied == true)
            {
                Console.WriteLine("Mary can enter the bar");
                Console.WriteLine(additionalMessage);
            }
            else
            {
                Console.WriteLine("Mary cannot enter the bar");
            }
            Console.ReadLine();
        }
    }
}
