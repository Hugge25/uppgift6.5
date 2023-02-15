using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in två hel tal eller texter");
            Console.Write("Första: ");
            string tal1 = Console.ReadLine();
            Console.Write("Andra: ");
            string tal2 = Console.ReadLine();
            Console.WriteLine($"Mellan {tal1} och {tal2} är {Längst(tal1, tal2)} längst");
        }

        static string Längst(string tal1, string tal2)
        {
            if(tal1.Length > tal2.Length)
            {
                return tal1;
            }
            else if(tal1.Length < tal2.Length)
            {
                return tal2;
            }
            else if (tal1.Length == tal2.Length)
            {
                return tal1;
            }
            else
            {
                return "Error";
            }
        }
    }
}
