using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterpreterPattern
{
    class Client
    {
        static void Main(string[] args)
        {
            Context context = new Context();
            List<AbstractExpression> list = new List<AbstractExpression>
            {
                new TerminalExpression(),
                new NonterminalExpression(),
                new TerminalExpression(),
                new TerminalExpression(),
            };

            foreach (var exp in list)
            {
                exp.Interpret(context);
            }

            Console.ReadKey();
        }
    }
}
