using System;

namespace lab5ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Ex 6
            Screiti un program care va numara vocalele dintr-un sir de caractere 
            citit de la tastatura.
             */
            Console.WriteLine("Introduceti sirul:");
            string sir = Console.ReadLine();

            int countVocale = 0;

            for (int i = 0; i < sir.Length; i++)
            {
                if (sir[i] == 'a' || sir[i] == 'e' ||
                    sir[i] == 'i' || sir[i] == 'o' ||
                    sir[i] == 'u')
                {
                    countVocale++;
                }
            }
            Console.WriteLine(countVocale);
        }
    }
}
