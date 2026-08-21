namespace Advanced_Assignment1
{
    //Q12: multiple constraints example (base class + interface + new()).
    class Repository<T> where T : Animal, IShape, new()
    {
        public T Create() { return new T(); }
    }
}