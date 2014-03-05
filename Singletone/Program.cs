using System;

namespace Singletone
{
    class Program
    {

        static void Main()
        {
            // Constructor is protected -- cannot use new 
            Singleton s1 = Singleton.Instance();
            Singleton s2 = Singleton.Instance();

            if (ReferenceEquals(s1, s2))
            {
                Console.WriteLine("Objects are the same instance");
            }

            // Wait for user 
            Console.Read();
        }
    }

    // "Singleton" 
    class Singleton
    {
        private static Singleton _instance;

        // Note: Constructor is 'protected' 
        private Singleton()
        {
        }

        public static Singleton Instance()
        {
            // Use 'Lazy initialization' 
            return _instance ?? (_instance = new Singleton());
        }
    }
}
