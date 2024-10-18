using System;
using System.Collections.Generic;
using System.Linq;

namespace LearnLinq
{
    class Program
    {
        static void Main()
        {
            List<string> heroes = new List<string> { "Astra", "Zephyr", "Nyx", "Orion", "Nova", "Thorne" };

            // Approach 1: without LINQ
            List<string> longLoudHeroes = new List<string>();

            foreach (string hero in heroes)
            {
                if (hero.Length > 5)
                {
                    string formatted = hero.ToUpper();
                    longLoudHeroes.Add(formatted);
                }
            }

            // Approach 2: with LINQ
            var longLoudHeroes2 = from h in heroes
                                  where h.Length > 5
                                  select h.ToUpper();

            // Printing...
            Console.WriteLine("Your long loud heroes are...");

            foreach (string hero in longLoudHeroes2)
            {
                Console.WriteLine(hero);
            }

            Console.WriteLine("---------------------------------------------------------------------------------");

            List<string> heroe = new List<string> { "Zoe", "Liam", "Taryn", "Dorian", "Everett", "Marlena" };

            var shortHeroes = from h in heroe
                              where h.Length < 7
                              select h;

            foreach (string h in shortHeroes)
            {
                Console.WriteLine(h);
            }

            var longHeroes = heroe.Where(n => n.Length >= 7);

            Console.WriteLine(longHeroes.Count());

            Console.WriteLine("---------------------------------------------------------------------------------");

            List<string> heroesList = new List<string> { "Zoe", "Liam", "Taryn", "Dorian", "Everett", "Marlena" };

            // Query syntax
            var queryResult = from h in heroesList
                              where h.Contains("a")
                              select $"{h} contains an 'a'";

            // Printing...
            Console.WriteLine($"queryResult has {queryResult.Count()} elements");

            foreach (string s in queryResult)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("---------------------------------------------------------------------------------");

            List<string> heroeList = new List<string> { "Zoe", "Liam", "Taryn", "Dorian", "Everett", "Marlena" };

            var result = heroeList.Where(h => h.Contains('v') || h.Contains('y'));

            foreach (var i in result)
            {
                Console.WriteLine(i);
            }
        }
    }
}
