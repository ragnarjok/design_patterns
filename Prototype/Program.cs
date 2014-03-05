using System;

namespace Prototype
{
    // MainApp test application
    class MainApp
    {
        static void Main()
        {
            // Create two instances and clone each 
            var p1 = new ConcretePrototype1("I");
            var c1 = (ConcretePrototype1)p1.Clone();
            Console.WriteLine("Cloned: {0}", c1.Id);

            var p2 = new ConcretePrototype2("II");
            var c2 = (ConcretePrototype2)p2.Clone();
            Console.WriteLine("Cloned: {0}", c2.Id);

            // Wait for user 
            Console.Read();
        }
    }

    // "Prototype" 
    abstract class Prototype
    {
        private readonly string _id;

        // Constructor 
        protected Prototype(string id)
        {
            _id = id;
        }

        // Property 
        public string Id
        {
            get { return _id; }
        }

        public abstract Prototype Clone();
    }

    // "ConcretePrototype1" 
    class ConcretePrototype1 : Prototype
    {
        // Constructor 
        public ConcretePrototype1(string id)
            : base(id)
        {
        }

        public override Prototype Clone()
        {
            // Shallow copy 
            return (Prototype)MemberwiseClone();
        }
    }

    // "ConcretePrototype2" 
    class ConcretePrototype2 : Prototype
    {
        // Constructor 
        public ConcretePrototype2(string id)
            : base(id)
        {
        }

        public override Prototype Clone()
        {
            // Shallow copy 
            return (Prototype)MemberwiseClone();
        }
    }
}
