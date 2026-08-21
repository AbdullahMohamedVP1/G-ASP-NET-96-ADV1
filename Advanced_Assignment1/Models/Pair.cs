namespace Advanced_Assignment1
{
    //Q3: Write Pair<TKey, TValue>.
    class Pair<TKey, TValue>{
        public TKey Key;
        public TValue Value;
        public Pair(TKey key, TValue value) { Key = key; Value = value; }
    }
}