using System;

namespace lab5ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Ex 5
        Un program care va normaliza un sir de caractere citit de la tastatura 
        astfel incat fiecare cuvant din sir sa inceapa cu MAJUSCULA, restul 
        literelor fiind transformate in litere mici.
            Exemplu:
            Input: Ana ARE mErE
            Rezultat: Ana Are Mere
         */
            Console.WriteLine("Introduceti sirul");
            string text = Console.ReadLine();

            string[] arr = text.Split(' ');
            var result = "";
            
            foreach(var s in arr)
            {
                var letter = s.ToLower();
                result += char.ToUpper(letter[0]) + letter.Substring(1) + ' ';
            }

            Console.WriteLine(result);
        }
    }
}
