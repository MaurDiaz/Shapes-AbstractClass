using System;

namespace Activity5._3._1
{
    public abstract class Shape
    {
        public Point Centre { get; set; } = new Point();

        public Shape(double x, double y)
        {
           this.Centre.x = x;
           this.Centre.y = y;
        }

        public void Move(double dx, double dy)
        {
            this.Centre.x += dx;
            this.Centre.y += dy;
        }

        public abstract double GetArea();
        public abstract double GetPerimeter();

        public bool IsSmallerThan(Shape other)
        {
            //ToDo
        }
      
    }
}