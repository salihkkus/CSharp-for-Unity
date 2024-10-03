using System;

namespace BooleanDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            bool answerOne = true;

            bool answerTwo = false;

            Console.WriteLine("---------------------------------------------------------");

            int cookiesSoldGuess = 40;

            int storeOneCookies = 110;
            int storeTwoCookies = 135;

            int cookiesSoldActual = storeOneCookies + storeTwoCookies;

            bool guessedCorrect = cookiesSoldGuess == cookiesSoldActual;

            Console.WriteLine(guessedCorrect);

            Console.WriteLine("---------------------------------------------------------");

            double timeToDinner = 4;

            double distance = 95;

            double rate = 30;

            double tripDuration = distance / rate;

            bool answer = (tripDuration <= timeToDinner);

            Console.WriteLine(answer);

            Console.WriteLine("---------------------------------------------------------");

            bool beach = true;
            bool hiking = false;
            bool city = true;

            bool yourNeeds = (beach && city);
            bool friendNeeds = (beach || hiking);

            bool tripDecision = (yourNeeds && friendNeeds);
            Console.WriteLine(tripDecision);

        }
    }
}
