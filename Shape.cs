using System;

namespace Activity5._3._1
{
    public abstract class Shape
    {
        public Point Centre { get; set; } = new Point();

        public Shape(double x, double y)
        {
           //To Do
        }

        public void Move(double dx, double dy)
        {
            //ToDo
        }

        public abstract double GetArea();
        public abstract double GetPerimeter();

        public bool IsSmallerThan(Shape other)
        {
            //ToDo
        }
      
    }
}