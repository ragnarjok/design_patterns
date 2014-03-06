using System;

namespace Adapter
{
    class Adaptee
    {
        public void ExecuteClassSpecificAction()
        {
            Console.WriteLine("class-specific logic");
        }
    }

    interface ITarget
    {
        void ExecuteInterfaceSpecificAction ();
    }

    class Adapter : Adaptee, ITarget
    {
        public void ExecuteInterfaceSpecificAction ()
        {
           ExecuteClassSpecificAction ();
        }
    }

    class Client
    {
        static void Main ()
        {
            var first = new Adaptee ();
            Console.Write ("Before the new standard: ");
            first.ExecuteClassSpecificAction ();

            ITarget second = new Adapter ();
            Console.WriteLine ("\nMoving to the new standard");
            second.ExecuteInterfaceSpecificAction () ;
        }
    }	


}
