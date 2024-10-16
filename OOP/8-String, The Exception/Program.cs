using System;

namespace StringTheException
{
    class Program
    {
        static void Main(string[] args)
        {
            string t1 = "immutable";
            string t2 = "immutable";
            Console.WriteLine(t1 == t2);
            Object a1 = new Object();
            Object a2 = new Object();
            Console.WriteLine(a1 == a2);


            Console.Write("Enter some input please: ");
            string input = Console.ReadLine();

            if (String.IsNullOrEmpty(input))
            {
                Console.WriteLine("You didn't enter anything!");
            }
            else
            {
                Console.WriteLine("Thank you for your submission!");
            }

            string dates = 
            "January 4th, 2024\n" +
            "March 25th, 2024\n" +
            "July 8th, 2024\n" +
            "December 11th, 2024";
      
              // Call `Replace()` here
            dates = dates.Replace("th", "");
      
            Console.WriteLine(dates);
        }
    }
}
