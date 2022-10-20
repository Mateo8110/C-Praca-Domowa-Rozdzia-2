using System;

namespace Zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y = 4;
            x = (y -= 2);
            x = y++;
            x = y--;
            Console.WriteLine(x);
            Console.ReadKey();
        }
    }
}