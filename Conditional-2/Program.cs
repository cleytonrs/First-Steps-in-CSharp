using System;

namespace Conditional_2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int ageOfBarbara = 15;
            int amountOfPeople = 2;
            bool accompanied = amountOfPeople >= 2;

            Console.WriteLine($"Name: Barbara \nAge: {ageOfBarbara} \nAmount of people: {amountOfPeople} \n");

            if (ageOfBarbara > 18 && accompanied == true)
            {
                Console.WriteLine("Barbara can enter the bar");
            }
            else
            {
                Console.WriteLine("Barbara cannot enter the bar");
            }
            Console.ReadLine();
        }
    }
}
