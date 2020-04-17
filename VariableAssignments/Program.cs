using System;

namespace VariableAssignments
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int age = 32;
            int ageOfJulia = age;
            age = 20;

            Console.WriteLine("Age: " + age);
            Console.WriteLine("Julia's age is " + ageOfJulia);

            Console.ReadLine();
        }
    }
}
