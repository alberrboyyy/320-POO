using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ParaClub
{
    internal class Program
    {
        static class Config
        {
            public const int SCREEN_HEIGHT = 40;
            public const int SCREEN_WIDTH = 150;
        }
        class Plane
        {
            public int x = 0;

            private string[] view =
                {
                    @"  _                         ",
                    @" | \                        ",
                    @" |  \       ______          ",
                    @" --- \_____/  |_|_\____  |  ",
                    @"   \_______ --------- __>-} ",
                    @"         \_____|_____/   |  "
                };
            public void Update()
            {
                if (x > Config.SCREEN_WIDTH - 40)
                {
                    Console.Clear();
                    x = 0;
                }
                else
                {
                    x++;
                }
            }
            public void Draw()
            {
                for (int i = 0; i < view.Length; i++)
                {
                    Console.SetCursorPosition(x, i);
                    Console.Write(view[i]);
                }

            }
        }
        static void Main(string[] args)
        {
            Console.SetWindowSize(Config.SCREEN_WIDTH, Config.SCREEN_HEIGHT);
            Plane plane = new Plane();
            Console.CursorVisible = false;

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
