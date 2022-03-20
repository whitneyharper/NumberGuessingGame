using System;

namespace NumberGuessingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            //Generate random number between 1 - 5
            int number = random.Next(1, 5);

            Console.WriteLine("Pick a number between 1 and 5. You get a total of three tries. What is your guess?");

            //Hold players guess
            int playerGuess = 0;

            //Keep count the number of user tries
            int userTries = 0;

            while (playerGuess != number)
            {
                //Convert Player Guess from string to integer
                playerGuess = Convert.ToInt32(Console.ReadLine());

                if (playerGuess == number)
                {
                    Console.WriteLine($"Congrats! You have picked the correct number. The number was {number}");
                    break;
                }
                else
                {
                    if (userTries == 2)
                    {
                        Console.WriteLine($"Sorry ran out of tries. The correct number was {number}.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Sorry wrong number. Try again.");
                        userTries++;
                    }
                }


            }
            
           

        }
    }
}
