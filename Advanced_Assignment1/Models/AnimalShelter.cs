using System;

namespace Advanced_Assignment1
{
    //Q11: base class constraint example.
    class AnimalShelter<T> where T : Animal
    {
        public void PrintName(T animal) { Console.WriteLine(animal.Name); }
    }
}