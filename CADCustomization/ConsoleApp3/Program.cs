using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Rectangle
    {
        protected double Length;
        protected double Width;

        public Rectangle()
        {
            this.Length = 0;
            this.Width = 0;
        }

        public Rectangle(double length, double width)
        {
            this.Length = length;
            this.Width = width;
        }

        public double CalculateArea()
        {
            return (Length * Width);
        }
    }

    //public class Cube : Rectangle
    //{
    //    public double Height;
    //    public Cube()
    //    { 
    //        this.Height = 0;
    //        this.Length = 0;
    //        this.Width= 0;
    //    }

    //    public Cube(double Length,double Width, double height)
    //    {
    //        this.Height = height;
    //        this.Length = Length;
    //        this.Width = Width;
    //    }

    //    double CalculateArea()
    //    {

    //    }
    //}

    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle a = new Rectangle(10.8, 50.5);
            Console.WriteLine(a.CalculateArea());
        }
    }
}
