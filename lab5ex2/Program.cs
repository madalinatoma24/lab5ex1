using System;

namespace lab5ex2
{
    class Program
    {

        /*
         Ex 2
         Scrieti un program care sa verifice daca un sir de caractere citit de 
         la tastatura este sau nu palindrom.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti sirul de caractere");
            string text = Console.ReadLine();

            Console.WriteLine(IsPalindrome(text));
        }

        static bool IsPalindrome(string text)
        {
            string reverse = "";
            for( int i= text.Length-1; i>=0; i--)
            {
                reverse += text[i];
            }
            if (reverse != text)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
