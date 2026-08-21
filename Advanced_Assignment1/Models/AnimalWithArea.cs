namespace Advanced_Assignment1
{
    //Used for Q12: a class that inherits Animal AND implements IShape,
    //needed to test multiple constraints together.
    class AnimalWithArea : Animal, IShape
    {
        public double GetArea() { return 0; }
    }
}