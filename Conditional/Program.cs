using System;

namespace Conditional
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int ageOfClarice = 15;
            int amountOfPeople = 2;

            Console.WriteLine($"Name: Clarice \nAge: {ageOfClarice} \nAmount of people: {amountOfPeople} \n");

            if (ageOfClarice > 18)
            {
                Console.WriteLine("Clarice is over 18 years old.");
            }
            else
            {
                if (amountOfPeople >= 2)
                {
                    Console.WriteLine("Clarice is no older than 18 years old, but she is accompanied.");
                }
                else
                {
                    Console.WriteLine("Clarice is no older than 18 years old.");
                }
            }
            Console.ReadLine();
        }
    }
}
