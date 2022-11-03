using System;

public class Program
{
	// Fields
	public int test = 0;
	
	// Constructor
	// Methods
	//[access modifier] [modifier] [return type] [method name] ([parameters])
	public static void Main()
	{
		bool loop = true;

		while(loop)
		{
			CoinFlipper(); // models the ENTIRE behavior

			Console.WriteLine("Would you like to flips more coins?\nEnter number of coins or type 'X' to quit:");
			string playAgain = Console.ReadLine().ToUpper();

			if (playAgain.Equals("Y"))
			{
				loop = true;
			}
			else
			{
				loop = false;
			}
		}
		
	}

	public static void CoinFlipper()
	{
		string playerChoice = "";
		string response = "";

		Console.WriteLine("I have a coin here. Let's play a game!\nHeads or tails? Type your response below:");
		response = Console.ReadLine();
		
		if (response.ToLower() == "heads" || response.ToLower() == "h")
		{
			playerChoice = "heads";
		}
		else if (response.ToLower() == "tails" || response.ToLower() == "t")
		{
			playerChoice = "tails";
		}
		else
		{
			Console.WriteLine("Please enter a valid response ('heads'/'h' or 'tails'/'t'):");	
			response = Console.ReadLine();
		}
	
			FlipCoin(playerChoice);

	}
	
	
	public static void FlipCoin(string playerChoice)
	{
		var rand = new Random();
		int coin = rand.Next(102);
		int result;

		if (coin == 100)
		{
			result = 4;
		}
		else if (coin == 101)
		{
			result = 3;
		}
		else if ( coin % 2 == 0)
		{
			result = 2;
		}
		else
		{
			result = 1;
		}

		CallResults(result);
	}
	
	public static void CallResults(int result)
	{
		switch (result)
		{
			case 4:
				Console.WriteLine("Wow, it landed on its side. Guess it's a draw.");
				break;
			case 3:
				Console.WriteLine("Um, I don't think it's coming down. Huh. One sec.");
				break;
			case 2:
				Console.WriteLine("It's heads.");
				break;
			case 1:
				Console.WriteLine("It's tails.");
				break;
		}
	}
}