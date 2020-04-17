using System;

namespace ConversionsAndOtherNumericTypes
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            double salary = 1230.50;
            int fullSalary;
            fullSalary = (int)salary;
            Console.WriteLine("(int) Full salary: " + fullSalary);

            long age = 24000000;
            Console.WriteLine("(long) Age: " + age);

            short quantityOfProducts = 150;
            Console.WriteLine("(short) Quantity of products: " + quantityOfProducts);

            float height = 1.80f;
            Console.WriteLine("(float) Height: " + height);

            Console.ReadLine();
        }
    }
}
