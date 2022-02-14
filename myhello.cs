using System;

namespace lab2_3
{
    class myhello
    {
        static void Main(string[] args)
        {
            Console.WriteLine("myHello");
            string name;
            name = Console.ReadLine();
            Console.WriteLine($"Привет", {name});
        }
    }
}
