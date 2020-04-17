using System;

namespace CharactersAndTexts
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            char firstLetter = 'a';
            Console.WriteLine("First letter = " + firstLetter);

            char secondLetter = (char)85;
            Console.WriteLine("Second letter = " + secondLetter);

            string phrase = "Alura technology courses " + 2020;
            Console.WriteLine(phrase);

            Console.ReadLine();
        }
    }
}
