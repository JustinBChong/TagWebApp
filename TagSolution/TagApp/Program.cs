using System;
using TagLibrary;

namespace TagApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine($"The answer is {new Thing().Get(42)}.");
        }
    }
}