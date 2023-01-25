using System;

namespace lab5ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Ex 7
                Scrieti un program care va citi doua siruri de caractere 
                de la tastatura si va  verifica daca cele doua siruri de 
                caractere sunt anagrame.
             */
            Console.WriteLine("Introduceti primul sir: ");
            string primulSir = Console.ReadLine();
            Console.WriteLine("Introduceti al doilea sir: ");
            string alDoileaSir = Console.ReadLine();
            int pozitiv = 0;
            int negativ = 0;
            if(primulSir.Length == alDoileaSir.Length)
            {
                for(var i=0; i < primulSir.Length; i++)
                {
                    if (alDoileaSir.ToLower().Contains(primulSir[i].ToString().ToLower()))
                    {
                        pozitiv++;
                    }
                    else
                    {
                        negativ++;
                    }
                }

                if (pozitiv > negativ)
                {
                    Console.WriteLine("Anagrama");
                }
                else
                {
                    Console.WriteLine("Nu este anagrama");
                }
            }
            else
            {
                Console.WriteLine("Nu este anagrama");
            }

            // RUINAT si rutina
        }
    }
}
