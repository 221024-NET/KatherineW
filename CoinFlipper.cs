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

			Console.WriteLine("Would you like to flips more coins?\nEnter number of coins ");
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
		Console.WriteLine("I have a coin here. Let's play a game!");
		
		Console.WriteLine("Heads or tails? Type your response below:");
		
		string response = Console.ReadLine();
		int Num = 0;
		
		try
		{
			Num = Int32.Parse(UserNumber);
			if ( Num <= 0 )
			{
				throw new Exception("Argument may not be negative");
			}
		}
		catch( InvalidOperationException e )
		{
			Console.WriteLine("A less specific catch: " + e.Message);
		}
		catch( ArgumentException e)
		{
			Console.WriteLine(e.Message);
		}
		catch( Exception e )
		{
			Console.WriteLine("The least specific catch: " + e.Message);
		}
	
			///////////////////// REMEMBER TO CALL FLIPCOIN //////////////////////////////

	}
	
	
	public static void FlipCoin(int Num)
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