using System;

namespace IfStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            int socks = 6;

            if (socks <= 3)
            {
                Console.WriteLine("Time to do laundry!");
            }

            Console.WriteLine("-----------------------------------------------");

            int people = 12;
            string weather = "bad";

            if (people <= 10 && weather == "nice")
            {
                Console.WriteLine("SaladMart");
            }
            else
            {
                Console.WriteLine("Soup N Sandwich");
            }

            Console.WriteLine("-----------------------------------------------");

            double ph = 7.0;

            if (ph < 7)
            {
                Console.WriteLine("Acidic");
            }
            else if (ph > 7)
            {
                Console.WriteLine("Basic");
            }
            else
            {
                Console.WriteLine("Neutral");
            }

            Console.WriteLine("-----------------------------------------------");

            double pH = 14;

            switch (pH)
            {
                case <= 3:
                    Console.WriteLine("Very Acidic");
                    break;
                case < 7:
                    Console.WriteLine("Acidic");
                    break;
                case >= 11:
                    Console.WriteLine("Very Basic");
                    break;
                case > 7:
                    Console.WriteLine("Basic");
                    break;
                default:
                    Console.WriteLine("Neutral");
                    break;
            }

            Console.WriteLine("-----------------------------------------------");

            double pepperLength = 4;

            string message = (pepperLength >= 3.5) ? "ready!" : "wait a little longer";

            Console.WriteLine(message);
        }
    }
}
