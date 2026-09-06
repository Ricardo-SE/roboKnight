using System;
					
public class Program
{
	public static void Main()
	{
		int ammo = 100;
		int coins = 5;
		Console.WriteLine("Welcome to roboKnight");
		Console.WriteLine($"now your ammo:{ammo}");
		Console.WriteLine($"now your coins:{coins}");
		Console.WriteLine("input a number:1Fire 2Buy ammo 3exit");
		int choice = int.Parse(Console.ReadLine());
		if(choice == 1)
		{
			if(ammo == 0)
			{
				Console.WriteLine("ammo empty");
			}
			else
			{
				ammo -= 1;
			    Console.WriteLine($"now ammo:{ammo}");
			 }
		}
		 else if(choice == 2)
		 {
			 if(coins < 10)
			 {
				 Console.WriteLine("no enough money");
			 }
			 else
			 {
				 coins -= 10;
			     ammo += 10;
				 Console.WriteLine($"now your coins:{coins},your ammo:{ammo}");
			 }
		 }
		else if(choice == 3)
		{
			Console.WriteLine($"account:ammo:{ammo},coins:{coins}");
		}
		else
		{
			Console.WriteLine("nonsense");
		}
			
			 
			
		
	}
}