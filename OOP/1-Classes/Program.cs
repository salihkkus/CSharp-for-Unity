using System;

namespace OverloadingConstructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Forest f = new Forest("Congo", "Tropical");
            f.trees = 0;

            Forest rendlesham = new Forest("Rendlesham");
            Console.WriteLine(rendlesham.biome);
        }
    }
}
