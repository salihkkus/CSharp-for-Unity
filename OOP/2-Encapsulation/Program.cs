using System;

namespace GetOnlyProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            Forest f = new Forest();
            f.Name = "Congo";
            f.Trees = 0;
            f.Biome = "Tropical";
            f.Age = 10;
        }
    }
}
