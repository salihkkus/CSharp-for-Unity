using System;

namespace PrideAndPrejudice
{
    class Program
    {
        static void Main(string[] args)
        {
            // First string variable
            string firstSentence = "It is a truth universally acknowledged, that a single man in possession of a good fortune, must be in want of a wife.";
            // Second string variable
            string firstSpeech = "\"My dear Mr. Bennet,\" said his lady to him one day, \"have you heard that Netherfield Park is let at last?\"";

            // Print variable and newline
            Console.WriteLine(firstSentence);
            Console.WriteLine("\n");
            Console.WriteLine(firstSpeech);

            Console.WriteLine("------------------------------------------------------------------------------");

            string beginning = "Once upon a time";
            string middle = "the kid climbed a tree";
            string end = "Everyone lived happily ever after";

            // Concatenate the string and the variables
            string story = beginning + ", " + middle + ". " + end + ".";

            // Print the story to the console 
            Console.WriteLine(story);

            Console.WriteLine("------------------------------------------------------------------------------");

            // Declare the variables
            string begin = "Once upon a time,";
            string mid = "The kid climbed a tree";
            string endd = "Everyone lived happily ever after.";

            // Interpolate the string and the variables
            string storyy = $"{begin} it was a beautiful day. {mid} and the birds flew through the sky. {endd}";

            // Print the story to the console 
            Console.WriteLine(story);

            Console.WriteLine("------------------------------------------------------------------------------");

            // Create password
            string password = "a92301j2add";

            // Get password length
            int passwordLength = password.Length;

            // Check if password uses symbol
            int passwordCheck = password.IndexOf("!");

            // Print results
            Console.WriteLine($"The user password is {password}. Its length is {passwordLength} and it receives a {passwordCheck} check.");

            Console.WriteLine("------------------------------------------------------------------------------");

            // DNA strand
            string startStrand = "ATGCGATGAGCTTAC";

            // Find location of "tga"
            int tga = startStrand.IndexOf("TGA");

            // Start point and stop point variables
            int startPoint = 0;
            int length = tga + 3;

            // Define final strand
            string dna = startStrand.Substring(startPoint, length);
            Console.WriteLine(dna);

            // DNA mutation search
            Console.WriteLine(dna[3]);
        }
    }
}
