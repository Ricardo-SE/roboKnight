using System;

class Program
{
    static int ammo = 100;               // 全局弹药
    static int coins = 50;               // 全局金币
    static bool gunLocked = false;       // 锁枪状态

    static void Main()
    {
        Console.WriteLine("=== RoboKnight · 弹药官 v3 ===");

        Console.WriteLine("买几包弹？");
        int packs = int.Parse(Console.ReadLine());
        int left = BuyAmmo(coins, packs);
        if (left == -1)
        {
            Console.WriteLine("no enough money");
        }
        else
        {
            coins = left;
            Console.WriteLine($"now your coins:{coins}");
        }

        bool ok = TryFire();
        if (ok)
        {
            Console.WriteLine("fire");
            Console.WriteLine($"ammo left:{ammo}");
        }
        else
        {
            Console.WriteLine("fire failed");
        }
    }

    static bool TryFire()
    {
        if (gunLocked) return false;     // 锁枪 → 失败
        if (ammo == 0) return false;     // 没弹 → 失败

        ammo--;                          // 过了两关才走到这
        return true;                     // 成功
    }

    static int BuyAmmo(int coins, int packs)   // 注意：这两个是点单副本
    {
        int price = 10 * packs;          // 一包 10 金币
        if (coins < price) return -1;    // 钱不够 → -1

        coins = coins - price;
        return coins;                    // 端出剩余金币
    }
}
