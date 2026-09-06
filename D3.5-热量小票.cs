using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== RoboKnight · 热量小票 ===");
        Console.Write("连开几枪？");
        int shots = int.Parse(Console.ReadLine());   // 点单：打几发

        int heat = 0;                    // 热量累计，从 0 开始

        for (int i = 1; i <= shots; i++) // 数着数开枪：1 到 shots
        {
            heat = heat + 10;
            Console.WriteLine($"{i}shot,heat:{heat}/100");
            if (heat >= 100)             // 热量条满了
            {
                Console.WriteLine("superheated");
                break;
            }
        }
    }
}
