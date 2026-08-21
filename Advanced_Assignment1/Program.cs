using System;

namespace Advanced_Assignment1
{
    internal class Program
    {
        #region Questions (answers as comments)

        //Q1: What is a generic class? Why use generics?
        //sol: generic class is a class that works with a type parameter(T) instead of a fixed data type
        //We use generics for code reusability and to avoid boxing or unboxing
        //(Implementation in Container.cs)

        //Q2: see Container.cs

        //Q3: What are multiple type parameters?
        //means a class or method can accept more than one generic type at same time
        //(Implementation: see Pair.cs)

        //Q4: What is a generic method?
        //generic method is a method that has its own type parameter even if the class itself isn't generic
        //(Implementation: Swap<T> below)

        //Q5: see FindMax<T> below

        //Q6: What is a generic interface?
        //generic interface is an interface that takes a type parameter and any implementing class must specify the type
        //(Implementation: see IRepository.cs)

        //Q7: What is the 'struct' constraint?
        //It restricts the type parameter to value types only (structs) not classes
        //(Implementation: see Calculator.cs)

        //Q8: What is the 'class' constraint?
        //It restricts the type parameter to reference types only (classes), not structs
        //(Implementation: see Storage.cs)

        //Q9: What is the 'new()' constraint?
        //It requires the type parameter to have a parameterless constructor so we can create a new object of it inside the class
        //(Implementation: see Factory.cs)

        //Q10: What is the interface constraint?
        //It requires the type parameter to implement a specific interface
        //(Implementation: see IShape.cs, Circle.cs, ShapeProcessor.cs)

        //Q11: What is the base class constraint?
        //It requires the type parameter to inherit from a specific base class
        //(Implementation: see Animal.cs, Dog.cs, AnimalShelter.cs)

        //Q12: How do you apply multiple constraints?
        //You can combine multiple constraints on the same type parameter, separated by commas
        //Base class must come first then interfaces, then new() last
        //(Implementation: see AnimalWithArea.cs, Repository.cs)

        #endregion

        //Q4: Generic method Swap<T>
        static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

        //Q5: Generic method FindMax<T>
        static T FindMax<T>(T[] items) where T : IComparable<T>
        {
            T max = items[0];
            for (int i = 1; i < items.Length; i++)
                if (items[i].CompareTo(max) > 0) max = items[i];
            return max;
        }

        static void Main(string[] args)
        {
            // Q2 test
            Container<int> container = new Container<int>();
            container.Add(10);
            container.Add(20);
            Console.WriteLine("Container: " + container.Get(0));

            // Q3 test
            Pair<string, int> pair = new Pair<string, int>("Ali", 25);
            Console.WriteLine("Pair: " + pair.Key + " " + pair.Value);

            // Q4 test
            int x = 5, y = 10;
            Swap(ref x, ref y);
            Console.WriteLine($"swap: {x} + {y} ");

            // Q5 test
            int[] nums = { 3, 7, 2, 9, 4 };
            Console.WriteLine("findMax: " + FindMax(nums));

            // Q7 test
            Calculator<int> calc = new Calculator<int>();
            calc.Value = 100;
            Console.WriteLine("calculator: " + calc.Value);

            // Q8 test
            Storage<string> storage = new Storage<string>();
            storage.Data = "Hello";
            Console.WriteLine("storage: " + storage.Data);

            // Q9 test
            Factory<Dog> factory = new Factory<Dog>();
            Dog dog = factory.CreateInstance();
            Console.WriteLine("factory created: " + dog.GetType().Name);

            // Q10 test
            ShapeProcessor<Circle> processor = new ShapeProcessor<Circle>();
            Circle circle = new Circle(5);
            Console.WriteLine("circle area: " + processor.GetArea(circle));

            // Q11 test
            AnimalShelter<Dog> shelter = new AnimalShelter<Dog>();
            Dog myDog = new Dog { Name = "Rex" };
            shelter.PrintName(myDog);

            // Q12 test
            Repository<AnimalWithArea> repo = new Repository<AnimalWithArea>();
            AnimalWithArea a = repo.Create();
            Console.WriteLine("repo created: " + a.GetType().Name);

            Console.ReadLine();
        }
    }
}