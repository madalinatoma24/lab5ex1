using System;

namespace lab5ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Ex1: Scrieti un program care va afisa pozitia unui substring intr-un string, 
            ambele siruri de caractere fiind citite de la tastatura
             */

            Console.WriteLine("Introduceti string-ul");
            var text = Console.ReadLine();

            Console.WriteLine("Introduceti substring-ul");
            var substring = Console.ReadLine();

            var position = text.IndexOf(substring);
            Console.WriteLine(position);
        }
    }
}
