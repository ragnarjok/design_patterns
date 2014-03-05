using System;

namespace Command
{
    class Program
    {
        static void Main()
        {
            // Create receiver, command, and invoker 
            var receiver = new Receiver();
            Command command = new ConcreteCommand(receiver);
            var invoker = new Invoker();

            // Set and execute command 
            invoker.SetCommand(command);
            invoker.ExecuteCommand();

            // Wait for user 
            Console.Read();
        }
    }

    // "Command" 
    abstract class Command
    {
        protected Receiver Receiver;

        // Constructor 
        protected Command(Receiver receiver)
        {
            Receiver = receiver;
        }

        public abstract void Execute();
    }

    // "ConcreteCommand" 
    class ConcreteCommand : Command
    {
        // Constructor 
        public ConcreteCommand(Receiver receiver) :
            base(receiver)
        {
        }

        public override void Execute()
        {
            Receiver.Action();
        }
    }

    // "Receiver" 
    class Receiver
    {
        public void Action()
        {
            Console.WriteLine("Called Receiver.Action()");
        }
    }

    // "Invoker" 
    class Invoker
    {
        private Command _command;

        public void SetCommand(Command command)
        {
            _command = command;
        }

        public void ExecuteCommand()
        {
            _command.Execute();
        }
    }
}
