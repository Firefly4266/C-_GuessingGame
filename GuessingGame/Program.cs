using System;


namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string playerInput;
            int playerGuess;
            bool isNumberGuessed = false;
            int answer;

            Console.Write("Guess a number between 1 and 20: ");
            playerInput = Console.ReadLine();


            Random randomNum = new Random();
            answer = randomNum.Next(1, 21);
            while (!isNumberGuessed)
            {
                //int.TryParse(playerInput, out playerGuess);
                playerGuess = int.Parse(playerInput);
                if (answer == playerGuess)
                {
                    isNumberGuessed = true;
                    Console.WriteLine("Your are correct, the answer is {0}", answer);
                    break;
                }
                else
                    if (playerGuess < answer)
                    {
                        string low = "You guessed too low.";
                        Console.WriteLine("{0} is incorrect. {1} Try again.", playerGuess, low);
                    }
                    else
                    {
                        string high = "you've guessed too high.";
                        Console.WriteLine("{0} is incorrect. {1} Try again.", playerGuess, high);
                    }
                Console.Write("Guess a number between 1 and 20: ");
                playerInput = Console.ReadLine();
            }
            Console.WriteLine("You guessed correct, {0} is the correct number!", answer);
        }
    }
}
