using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParaClub
{
    public class Plane
    {
        private int x;

        private List<Para> parachutistes = new List<Para>();

        private string[] view =
            {   @"  _                         ",
                @" | \                        ",
                @" |  \       ______          ",
                @" --- \_____/  |_|_\____  |  ",
                @"   \_______ --------- __>-} ",
                @"         \_____|_____/   |  "};


        public Plane()
        {
            int _planeX = x;
            string[] _planeView = view;
        }


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
}
