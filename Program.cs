using System;

namespace Methods
{
    class Program
    {
      
        static void Main(string[] args)
        {
            var point = new Point(10,20);
            point.Move(new Point(6,900));
            Console.WriteLine("point is at {0} , {1}", point.X, point.Y);
            point.Move(100,900);
            Console.WriteLine("point is at {0} , {1}", point.X, point.Y);

        }

        }
    
}
