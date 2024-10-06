using System;

namespace WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int emails = 20;

            while (emails > 0)
            {
                emails--;
                Console.WriteLine($"one email deleted, {emails} left");
            }

            Console.WriteLine("INBOX ZERO ACHIEVED!");

            Console.WriteLine("---------------------------------------------------");

            bool buttonClick = true;

            do
            {
                Console.WriteLine("Alarm Ringing");
            } while (!buttonClick);

            Console.WriteLine("Time for a five minute break");

            Console.WriteLine("---------------------------------------------------");

            for (int i = 1; i <= 16; i++)
            {
                Console.WriteLine($"Week {i}");
                Console.WriteLine("Announcements: \n \n \n ");
                Console.WriteLine("Report Backs: \n \n \n");
                Console.WriteLine("Discussion Items: \n \n \n");
            }

            Console.WriteLine("---------------------------------------------------");

            string[] todo = { "respond to email", "make wireframe", "program feature", "fix bugs" };

            foreach (string task in todo)
            {
                Console.WriteLine($"[] {task}");
            }

            Console.WriteLine("---------------------------------------------------");

            bool buttonClicks = false;
            int counter = 0;

            do
            {
                Console.WriteLine("Alarm Ringing");
                counter++;

                if (counter == 3)
                {
                    break;
                }
            } while (!buttonClicks);
        }

    }
    }

