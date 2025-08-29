using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace snail
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int rand = rnd.Next(1, 100);

            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(100);

                Console.SetCursorPosition(i, 7);
                Console.Write(" __O.");
                Console.SetCursorPosition(i, 7);
            }
            Console.Write(" ____");

            while (true) ;
        }

    }
}
