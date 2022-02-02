using System;

namespace Assets.Scripts.PatternsPovideniya.Interpreter
{
    public class Program
    {
        void Main()
        {
            Context context = new Context();

            var expression = new NonterminalExpression();
            expression.Interpret(context);

            Console.ReadLine();

        }
    }

}