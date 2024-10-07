using System;
using System.Xml.Linq;

namespace CallingMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string designer = "Anders Hejlsberg";

            Console.WriteLine(designer);

            int indexOfSpace = designer.IndexOf(" ");

            int indexOfSecondName = indexOfSpace + 1;

            string secondName = designer.Substring(indexOfSecondName);

            Console.WriteLine(secondName);

            Console.WriteLine("---------------------------------------------------");

            VisitPlanets();


            static void VisitPlanets()
            {
                Console.WriteLine("You visited many new planets...");
            }

            Console.WriteLine("---------------------------------------------------");

            {
                VisitPlanet(3);
                VisitPlanet(4);
                VisitPlanet(5);
            }

            static void VisitPlanet(int numberOfPlanets)
            {
                Console.WriteLine($"You visited {numberOfPlanets} planets...");
            }

            Console.WriteLine("---------------------------------------------------");

            {
                IntroduceFriends("Laika", "Albert");
                IntroduceFriends("Naomi", "Jasmine", "Cyrus");
                IntroduceFriends();
            }

            static void IntroduceFriends(string friend1, string friend2)
            {
                Console.WriteLine($"These are my friends, {friend1} and {friend2}!");
            }

            static void IntroduceFriends(string friend1, string friend2, string friend3)
            {
                Console.WriteLine($"These are my friends, {friend1}, {friend2}, and {friend3}!");
            }

            static void IntroduceFriends()
            {
                Console.WriteLine("There is no one who needs to be introduced.");
            }

            Console.WriteLine("---------------------------------------------------");

            string scoreAsString = "85.6";
            string statement = "Hello World";

            double scoreAsDouble;
            bool outcome;

            outcome = Double.TryParse(scoreAsString, out scoreAsDouble);

            Console.WriteLine($"{outcome}, {scoreAsDouble}");

            string whispered = Whisper(statement, out bool marker);
            Console.WriteLine(whispered);
        }

        static string Whisper(string phrase, out bool wasWhisperCalled)
        {
            wasWhisperCalled = true;
            return phrase.ToLower();
        }

        Console.WriteLine("---------------------------------------------------");

        static void OurMethodName(string message, string punctuation = ".")
        {
            Console.WriteLine(message + punctuation);
        }


        OurMethodName("I'm hungry", "!"); // prints "I'm hungry!"
        OurMethodName("I'm hungry");  // prints "I'm hungry."

        Console.WriteLine("---------------------------------------------------");

        VisitPlanets();
        VisitPlanets(numberOfPlanets : 2);
        VisitPlanets(numberOfPlanets : 2, name: "Salih");
    }

       static void VisitPlanets(
       string adjective = "brave",
       string name = "Cosmonaut",
       int numberOfPlanets = 0,
       double gForce = 4.2)
    {
        Console.WriteLine($"Welcome back, {adjective} {name}.");
        Console.WriteLine($"You visited {numberOfPlanets} new planets...");
        Console.WriteLine($"...while experiencing a g-force of {gForce} g!");

    }
}
 
