using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uvod
{
    class Program
    {

        
        static void Main(string[] args)
        {
            try {
                Console.WriteLine("Toto je kalkulacka pro  dvou cisel");
                Console.WriteLine(".");
                Console.WriteLine(".");
                Console.WriteLine("Zadejte prvni cislo.");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Zadejte druhe cislo.");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("Zadejte znamenko");
                string znamenko = Console.ReadLine();
                if (znamenko == "+") {
                    Console.WriteLine($"Vysledek je: {a + b}");
                } else if (znamenko == "-") {
                    Console.WriteLine($"Vysledek je: {a - b}");
                } else if (znamenko == "*") {
                    Console.WriteLine($"Vysledek je: {a * b}");
                } else if (znamenko == "/" && b == 0) {
                    Console.WriteLine("delit nulou nelze");
                } else if (znamenko == "/") {
                   Console.WriteLine($"Vysledek je: {a / b}");
                };
                Console.Read();
            }
            catch {
                Console.WriteLine("Špatny vstup");
                Console.Read();
            }
        }
    }
}