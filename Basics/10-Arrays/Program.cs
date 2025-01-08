using System;

namespace BuildingArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] summerStrut;

            summerStrut = new string[] { "Juice", "Missing U", "Touch the Sky", "New York Groove", "Make Me Feel", "Bound 2", "Despacito", "on Sight" };

            int[] ratings = { 5, 4, 4, 3, 3, 5, 5, 4 };


            if (summerStrut.Length == 8)
            {
                Console.WriteLine("SummerStrut playlist is ready to go!");
            }
            else if (summerStrut.Length > 8)
            {
                Console.WriteLine("Too many songs!");
            }
            else
            {
                Console.WriteLine("Add some songs!");
            }

            Console.WriteLine($"You rated the song {summerStrut[1]} {ratings[1]} stars");

            summerStrut[7] = "I Like It";

            ratings[7] = 3;

            int threeRating = Array.IndexOf(ratings, 3);
            Console.WriteLine($"Song number {threeRating + 1} is rated three stars.");

            Array.Reverse(summerStrut);
            string newFirst = summerStrut[0];
            string newLast = summerStrut[7];
            Console.WriteLine($"The first song in the playlist is now {newFirst}.");
            Console.WriteLine($"The last song in the playlist is now {newLast}.");

            Array.Sort(summerStrut);
            string firstSong = summerStrut[0];
            string lastSong = summerStrut[7];
            Console.WriteLine($"The first song in the playlist is now {firstSong}.");
            Console.WriteLine($"The last song in the playlist is now {lastSong}.");

            Console.WriteLine("-------------------------------------------------------------------");

            int[][] jaggedArray = new int[3][]; // 3 columns jagged array
            jaggedArray[0] = new int[] { 1, 2 };
            jaggedArray[1] = new int[] { 3, 4, 5 };
            jaggedArray[2] = new int[] { 6 };

        }
    }
}
