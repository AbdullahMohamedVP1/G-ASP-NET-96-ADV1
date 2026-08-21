using System;

namespace Advanced_Assignment1
{
    //Used for Q10: a class implementing IShape, to test ShapeProcessor<T>.
    class Circle : IShape
    {
        public double Radius;
        public Circle(double radius) { Radius = radius; }
        public double GetArea() { return Math.PI * Radius * Radius; }
    }
}