using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            bool aufgabe = true;
            string aufgabentext = aufgabenText();
            if (aufgabe == true)
            {
                Console.WriteLine(aufgabentext);
            }
        }
        static string aufgabenText()
        {
            string newAufgabe = Console.ReadLine();
            return newAufgabe;
        }
    }
}
