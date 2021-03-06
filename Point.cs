using System.Globalization;
using System.Runtime.CompilerServices;
using System;

namespace Methods
{   
    public class Point
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {   
            this.X = x;
            this.Y = y;
        }
        public void Move(int x , int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void Move(Point newLocation)
        {   
            Move(newLocation.X,newLocation.Y);
        }
    }
}