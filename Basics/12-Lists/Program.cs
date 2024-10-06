using System;
using System.Collections.Generic;

namespace LearnLists
{
    class Program
    {
        static void Main()
        {
            List<string> citiesList = new List<string> { "Delhi", "Los Angeles", "Saint Petersburg" };

            citiesList.Add("New York City");

            citiesList.Remove("Delhi");

            citiesList.AddRange(new string[] { "Cairo", "Johannesburg" });

            bool hasNewDelhi = citiesList.Contains("New Delhi");

            foreach (string city in citiesList)
            {
                Console.WriteLine(city);
            }

            Console.WriteLine("--------------------------------------------------------------");

            List<double> marathons = new List<double>();
            marathons.Add(144.07);
            marathons.Add(143.12);

            Console.WriteLine(marathons[1]);

            Console.WriteLine("--------------------------------------------------------------");

            //Object Initialization
            List<double> marathon = new List<double> { 144.07, 143.12, 146.73, 146.33 };

            Console.WriteLine("--------------------------------------------------------------");

            List<double> marathonss = new List<double>
            {
            144.07,
            143.12,
            146.73,
            146.33
            };

            Console.WriteLine(marathonss.Count);

            marathons.Add(143.23);

            Console.WriteLine(marathonss.Contains(143.23));

            Console.WriteLine(marathonss.Count);

            Console.WriteLine("--------------------------------------------------------------");

            Console.WriteLine(marathons[1]);

            bool removed = marathons.Remove(143.12);

            Console.WriteLine(marathons[1]);

            Console.WriteLine(removed);

            Console.WriteLine("--------------------------------------------------------------");

            marathons.Clear();

            Console.WriteLine($"Count: {marathons.Count}");

            Console.WriteLine("--------------------------------------------------------------");

            List<string> runners = new List<string> { "Jemima Sumgong", "Tiki Gelana", "Constantina Tomescu", "Mizuki Noguchi" };
            Random rand = new Random();

            Console.WriteLine("In reverse chronological order, the gold medalists are...");

            // First loop
            for (int i = 0; i < runners.Count; i++)
            {
                Console.WriteLine($"{i + 1}: {runners[i]}");
            }

            Console.WriteLine("\nPrinting runner bibs...");

            // Second loop
            foreach (string runner in runners)
            {
                string name = runner.ToUpper();
                int id = rand.Next(100, 1000);
                Console.WriteLine($"{id} - {name}");
            }

            Console.WriteLine("--------------------------------------------------------------");

            List<string> places = new List<string> { "first", "second" };

            places.AddRange(new string[] { "fifth", "sixth" });
            // List is  "first", "second", "fifth", "sixth" ]
            places.InsertRange(2, new string[] { "third", "fourth" });
            // List is [ "first", "second", "third", "fourth", "fifth", "sixth" ]
            places.RemoveRange(4, 2);
            // List is [ "first", "second", "third", "fourth" ]
            List<string> newPlaces = places.GetRange(0, 3);
            // New list is [ "first", "second", "third" ]
        }
    }
}
