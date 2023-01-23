using System;

namespace lab5ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Ex 3
            Scrieti un program care va numara toate aparitiile unui caracter 
            intr-un sir de caractere. Atat caracterul cautat cat si sirul de 
            caractere vor fi citite de la tastatura
             */

            Console.WriteLine("Introduceti sirul: ");
            string text = Console.ReadLine();
            Console.WriteLine("Introduceti caracterul");
            char character = char.Parse(Console.ReadLine());
            Console.WriteLine(CountChar(text, character));
        }
        static int CountChar(string text, char a)
        {
            int countChar = 0;
            foreach(char letter in text)
            {
               if( a == letter)  countChar++;
            }

            return countChar;
        }
    }
}
