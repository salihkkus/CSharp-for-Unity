using System;

namespace gettinginput
{
    class gettinginput
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How old are you?");
            string input = Console.ReadLine();
            Console.WriteLine("You are " + input + " years old");
        }
    }
}
