namespace Advanced_Assignment1
{
    //Q9: new() constraint example.
    class Factory<T> where T : new()
    {
        public T CreateInstance() { return new T(); }
    }
}