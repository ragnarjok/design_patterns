using System;
using System.Collections.Generic;

namespace Interpreter
{
    class Program
    {
        static void Main()
        {
            var context = new Context();

            // Usually a tree 
            var list = new List<AbstractExpression>(4)
                           {
                               new TerminalExpression(),
                               new NonterminalExpression(),
                               new TerminalExpression(),
                               new TerminalExpression()
                           };

            // Populate 'abstract syntax tree' 

            // Interpret 
            foreach (var exp in list)
            {
                exp.Interpret(context);
            }

            // Wait for user 
            Console.Read();
        }
    }

    // "Context" 
    class Context
    {
    }

    // "AbstractExpression" 
    abstract class AbstractExpression
    {
        public abstract void Interpret(Context context);
    }

    // "TerminalExpression" 
    class TerminalExpression : AbstractExpression
    {
        public override void Interpret(Context context)
        {
            Console.WriteLine("Called Terminal.Interpret()");
        }
    }

    // "NonterminalExpression" 
    class NonterminalExpression : AbstractExpression
    {
        public override void Interpret(Context context)
        {
            Console.WriteLine("Called Nonterminal.Interpret()");
        }
    }
}
