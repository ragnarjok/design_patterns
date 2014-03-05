using System;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main()
        {
            // Setup Chain of Responsibility 
            Handler h1 = new ConcreteHandler1();
            Handler h2 = new ConcreteHandler2();
            Handler h3 = new ConcreteHandler3();
            h1.SetSuccessor(h2);
            h2.SetSuccessor(h3);

            // Generate and process request 
            int[] requests = { 2, 5, 14, 22, 18, 3, 27, 20 };

            foreach (var request in requests)
            {
                h1.HandleRequest(request);
            }

            // Wait for user 
            Console.Read();
        }
    }

    // "Handler" 
    abstract class Handler
    {
        protected Handler Successor;

        public void SetSuccessor(Handler successor)
        {
            Successor = successor;
        }

        public abstract void HandleRequest(int request);
    }

    // "ConcreteHandler1" 
    class ConcreteHandler1 : Handler
    {
        public override void HandleRequest(int request)
        {
            if (request >= 0 && request < 10)
            {
                Console.WriteLine("{0} handled request {1}",
                  this.GetType().Name, request);
            }
            else if (Successor != null)
            {
                Successor.HandleRequest(request);
            }
        }
    }

    // "ConcreteHandler2" 
    class ConcreteHandler2 : Handler
    {
        public override void HandleRequest(int request)
        {
            if (request >= 10 && request < 20)
            {
                Console.WriteLine("{0} handled request {1}",
                  GetType().Name, request);
            }
            else if (Successor != null)
            {
                Successor.HandleRequest(request);
            }
        }
    }

    // "ConcreteHandler3" 
    class ConcreteHandler3 : Handler
    {
        public override void HandleRequest(int request)
        {
            if (request >= 20 && request < 30)
            {
                Console.WriteLine("{0} handled request {1}",
                  GetType().Name, request);
            }
            else if (Successor != null)
            {
                Successor.HandleRequest(request);
            }
        }
    }
}

