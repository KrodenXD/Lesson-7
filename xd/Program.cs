using System;

namespace xd
{
    class Program
    {
        static void Main(string[] args)
        {
            Milk milk = new Milk();
            Console.WriteLine(milk.MakeMatzun(4));
            Console.WriteLine(milk.MakeSmetan(6));
            Console.WriteLine(milk.MakeTvarog(8));
        }
    }
}
