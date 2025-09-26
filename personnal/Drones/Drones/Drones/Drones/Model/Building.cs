using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones.Model
{
    public partial class Building
    {
        private int _x;
        private int _y;
        private int _sizeX;
        private int _sizeY;
        private Color _color;


        public int X { get { return _x; } set { _x = value; } }
        public int Y { get { return _y; } set { _y = value; } }
        public int SizeX { get { return _sizeX; } set { _sizeX = value; } }
        public int SizeY { get { return _sizeY; } set { _sizeY = value; } }
        public Color Color { get { return _color; } set { _color = value; } }


        public Building(int x, int y, int sizeX, int sizeY, Color color)
        {
            X = x;
            Y = y;
            SizeX = sizeX;
            SizeY = sizeY;
            Color = color;
        }



    }
}