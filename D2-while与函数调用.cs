using System;

class Program
{
    static int ammo = 100;            // 搬家完成，直接用
    static int coins = 50;

    static void Main()
    {
        Console.WriteLine("=== RoboKnight · 弹药官 v2 ===");
        ShowStatus();

        while (true)                  // 菜单开始一直问
        {
            Console.WriteLine("请输入：1开火 2买弹 3退出");
            int choice = int.Parse(Console.ReadLine());   // 每圈都重新读！

            if (choice == 1)
            {
                Fire();
            }
            else if (choice == 2)
            {
                BuyAmmo();
            }
            else if (choice == 3)
            {
                Console.WriteLine("今日军需结算");
                break;                // 跳出循环 = 退出
            }
            else
            {
                Console.WriteLine("nonsense");
            }
			 ShowStatus();
        }
    }

    static void Fire()
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

    static void BuyAmmo()
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

    static void ShowStatus()
    {
			Console.WriteLine($"account:ammo:{ammo},coins:{coins}");
    }
}