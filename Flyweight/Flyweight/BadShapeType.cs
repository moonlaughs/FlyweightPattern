using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight
{
    public class BadShapeType
    {
        public string name;
        public string color;
        public int x;
        public int y;

        public BadShapeType(string name, string color, int x, int y)
        {
            this.name = name;
            this.color = color;
            this.x = x;
            this.y = y;
        }

        public void CreateShape(string name, string color, int x, int y)
        {
            Console.WriteLine("Shape: " + name + ", of color: " + color + "x and y: " + x + " " + y);
        }
    }
}
