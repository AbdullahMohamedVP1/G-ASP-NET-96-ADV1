namespace Advanced_Assignment1
{
    //Q10: interface constraint example.
    class ShapeProcessor<T> where T : IShape
    {
        public double GetArea(T shape) { return shape.GetArea(); }
    }
}