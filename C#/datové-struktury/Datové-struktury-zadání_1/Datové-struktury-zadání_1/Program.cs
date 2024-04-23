using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datové_struktury_zadání_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // List
            List<string> slova = new List<string>();
            int indexPoslednihoZobrazeni = -1; // Index posledního zobrazeného slova

            while (true)
            {
                // Přečtení vstupu uživatele
                string vstup = Console.ReadLine();

                // Rozdělení vstupu na příkaz a hodnotu
                string[] casti = vstup.Split(':');

                // Ověření, zda je vstup validní
                if (casti.Length != 2 || !casti[0].Equals("Pridat") || string.IsNullOrWhiteSpace(casti[1]))
                {
                    Console.WriteLine("Neplatný příkaz!");
                    continue;
                }

                // Zpracování příkazu Pridat
                string noveSlovo = casti[1].Trim();
                slova.Add(noveSlovo);
                Console.WriteLine(noveSlovo);

                // Nastavení indexu posledního zobrazeného slova na nejnovější přidané slovo
                indexPoslednihoZobrazeni = slova.Count - 1;
            }

            // Zpracování příkazu Zpet
            else if (vstup.Equals("Zpet")) 
            {
                if (indexPoslednihoZobrazeni > 0)
                {
                    indexPoslednihoZobrazeni--;
                    Console.WriteLine(slova[indexPoslednihoZobrazeni]);
                }
                else
                {
                    Console.WriteLine("Není možné zobrazit předchozí slovo.");
                }
            }

            // Zpracování příkazu Vpred
            else if (vstup.Equals("Vpred"))
            {
                if (indexPoslednihoZobrazeni < slova.Count - 1)
                {
                    indexPoslednihoZobrazeni++;
                    Console.WriteLine(slova[indexPoslednihoZobrazeni]);
                }
                else
                {
                    Console.WriteLine("Není možné zobrazit další slovo.");
                }
            }

            // chyba
            else
            {
                Console.WriteLine("Neznámý příkaz!");
            }
        }
    }
}
