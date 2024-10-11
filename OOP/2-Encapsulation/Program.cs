using System;

namespace Review
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Forest.ForestsCreated);

            Forest f1 = new Forest("Amazon", "Tropical");
            Forest f2 = new Forest("Congo");

            Console.WriteLine(Forest.ForestsCreated);
        }
    }
}
