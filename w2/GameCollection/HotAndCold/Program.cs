using System;

namespace HotAndCold
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int gameNumber;

            Console.WriteLine("What would you like to play?\n1) CoinFlipper\n2) Hot and Cold");

            while(true)
            {
                Console.WriteLine("Please enter the name or number of the game you want to play:");
                string game = Console.ReadLine();

                if (Int32.TryParse(game, out gameNumber))
                {
                    if (gameNumber == 1)
                    {
                        CoinFlipper.Coin();
                    }
                    else if (gameNumber == 2)
                    {
                        GuessingGame();
                    }
                    else
                    {
                        continue;
                    }
                }
                else
                {
                    if (game.ToLower().Equals("coinflipper") || game.ToLower().Equals("one"))
                    {
                        CoinFlipper.Coin();
                        break;
                    }
                    else if (game.ToLower().Equals("hot and cold") || game.ToLower().Equals("two"))
                    {
                        GuessingGame();
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }

                
            }
        }

        public static void GuessingGame()
        {
            Guessing game = new Guessing();

            Console.WriteLine("Number Guesser started:"); // greet the user

            int secretNum = game.GenerateSecretNumber();
            
            int userNum = 0;

            do
            {
                userNum = game.GetUserNumber();

                Console.WriteLine( game.PrintResult( secretNum, userNum ) );
                
            } while (secretNum != userNum);

            Console.WriteLine("Thanks for playing!");
        }
    }
}