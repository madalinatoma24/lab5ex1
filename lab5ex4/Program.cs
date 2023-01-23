using System;

namespace lab5ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Scrieti un program care va afisa caracterul cu numarul cel mai
            mare de aparitii dintr-un string citit de la tastatura, 
            ignorand caseing-ul literelor.
            Exemplu:
            Input: Elena are mere
            Output: e apare de 5 ori
             */
            Console.WriteLine("Intriduceti textul: ");
            var text = Console.ReadLine();
            CountLetter(text);
        }

        static string CountLetter(string text)
        {
            int[] lettersArr = new int[255];

            int max = 0;
            char countLetter = ' ';
            for (int i=0; i<text.Length; i++)
            {
                lettersArr[text[i]]++;
                if (max < lettersArr[text[i]])
                {
                    max = lettersArr[text[i]];
                    countLetter = text[i];
                }
            }

            var result = $@"Litera {(char)countLetter} apare de {max} ori";
            return result;
        }
    }
}
