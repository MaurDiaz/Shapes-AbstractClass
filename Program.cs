﻿using System;

namespace Activity5._3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int shapeCount = Int32.Parse(Console.ReadLine());
            var shapes = new Shape[shapeCount];
            for (int i = 0; i < shapeCount; ++i)
            {
                var cmd = Console.ReadLine().Split();
                if (cmd[0] == "rectangle")
                {
                    double x = double.Parse(cmd[1]);
                    double y = double.Parse(cmd[2]);
                    double width = double.Parse(cmd[3]);
                    double height = double.Parse(cmd[4]);
                    shapes[i] = new Rectangle(x, y, width, height);
                }
                else if (cmd[0] == "circle")
                {
                    double x = double.Parse(cmd[1]);
                    double y = double.Parse(cmd[2]);
                    double radius = double.Parse(cmd[3]);
                    shapes[i] = new Circle(x, y, radius);
                }
            }
            string input;
            while ((input = Console.ReadLine()) != "exit")
            {
                var cmd = input.Split();
                if (cmd[0] == "move")
                {
                    int index = int.Parse(cmd[1]);
                    double dx = double.Parse(cmd[2]);
                    double dy = double.Parse(cmd[3]);
                    shapes[index].Move(dx, dy);
                }
                else if (cmd[0] == "centre")
                {
                    int index = int.Parse(cmd[1]);
                    Console.WriteLine(shapes[index].Centre.x + ", " + shapes[index].Centre.y);
                }
                else if (cmd[0] == "area")
                {
                    int index = int.Parse(cmd[1]);
                    Console.WriteLine(shapes[index].GetArea());
                }
                else if (cmd[0] == "perimeter")
                {
                    int index = int.Parse(cmd[1]);
                    Console.WriteLine(shapes[index].GetPerimeter());
                }
                else if (cmd[0] == "issmaller")
                {
                    int index1 = int.Parse(cmd[1]);
                    int index2 = int.Parse(cmd[2]);
                    Console.WriteLine(shapes[index1].IsSmallerThan(shapes[index2]));
                }
            }
        }
    }
}
