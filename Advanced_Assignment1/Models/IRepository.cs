namespace Advanced_Assignment1
{
    //Q6: Write IRepository<T>.
    interface IRepository<T>
    {
        void Add(T item);
        T GetById(int id);
    }
}