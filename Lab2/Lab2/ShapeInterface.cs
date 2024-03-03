using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesInterface
{
    public interface IShape
    {
        void Get();
        void Display();
    }

    public class Rectangle : IShape
    {
        private double length;
        private double width;

        public Rectangle (double  length, double width)
        {
            this.length = length;
            this.width = width;
        }
        public void Get()
        {
            Console.WriteLine("Given Length of the rectangle is " + length);
            Console.WriteLine("Given Width of the rectangle is " + width);
        }

        public void Display()
        {
            Console.WriteLine("Rectangle____");
            Console.WriteLine("Length: " + length);
            Console.WriteLine("Width: " + width);
        }
    }
    public class Square : IShape
    {
        private double side;

        public Square(double side)
        {
            this.side = side;
        }
        public void Get()
        {
            Console.WriteLine("Given side of the square is " + side);
        }

        public void Display()
        {
            Console.WriteLine("Square____");
            Console.WriteLine("Side: " + side);
        }
    }
}
