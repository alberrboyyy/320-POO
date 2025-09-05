using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ParaClub
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(Config.SCREEN_WIDTH, Config.SCREEN_HEIGHT);
            Console.CursorVisible = false;


            Plane plane = new Plane();
            Para bob = new Para();


            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo keyPressed = Console.ReadKey(false);
                    switch (keyPressed.Key)
                    {
                        case ConsoleKey.Escape:
                            Environment.Exit(0);
                            break;
                        case ConsoleKey.Spacebar:

                            break;
                    }
                }


                plane.Update();
                plane.Draw();


                Thread.Sleep(100);
            }
        }
    }
}
