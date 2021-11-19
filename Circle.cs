using System;

namespace Activity5._3._1
{
   public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double x, double y, double radius) : base(x, y)
        {
            this.Radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI*Radius*Radius;
        }

        public override double GetPerimeter()
        {
            return 2.0*Math.PI*Radius;//ToDo
        }
    } 
}