using System;

namespace Activity5._3._1
{
    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double x, double y, double width, double height) : base(x, y)
        {
            this.Height = height;
            this.Width = width;
        }

        public override double GetArea()
        {
            return Height*Width;
        }

        public override double GetPerimeter()
        {
            return 2.0*Height + 2.0*Width;
        }
    }
}