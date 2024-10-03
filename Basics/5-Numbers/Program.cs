using System;

namespace BusinessSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            // Calculating Net Income 
            double revenue = 853023.45;
            double expenses = 438374.11;
            double netIncome = revenue - expenses;

            Console.WriteLine(netIncome);

            // Calculating a Break-Even Point
            double fixedCosts = 912849.30;
            double salesPrice = 29.99;
            double variableCostPerUnit = 17.65;

            double breakEvenVolume = fixedCosts / (salesPrice - variableCostPerUnit);
            Console.WriteLine(breakEvenVolume);

            Console.WriteLine("------------------------------------------------------------------------------------");

                // Your Age
                int userAge = 20;

                // Length of years on Jupiter (in Earth years)
                double jupiterYears = 11.86;

                // Age on Jupiter
                double jupiterAge = userAge / jupiterYears;

                // Time to Jupiter
                double journeyToJupiter = 6.142466;

                // New Age on Earth
                double newEarthAge = userAge + journeyToJupiter;

                // New Age on Jupiter
                double newJupiterAge = newEarthAge / jupiterYears;

                // Log calculations to console
                Console.WriteLine(jupiterAge);
                Console.WriteLine(newEarthAge);
                Console.WriteLine(newJupiterAge);

            Console.WriteLine("------------------------------------------------------------------------------------");

            int eggs = 56;
            int crateCapacity = 12;

            int eggsLeftOver = eggs % crateCapacity;
            // 56 / 12 = 4 (12*4 = 48) with 8 remaining
            // we can confirm this is correct because 48 + 8 = 56
            Console.Write(eggsLeftOver);
        }
        }
    }