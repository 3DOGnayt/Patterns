using System;

namespace Assets.Scripts.PatternsPovideniya.Strategy
{
    public class Program
    {
        static void Main(string[] args)
        {
            var Switch = new Switch();
            Switch.Work(new ButtomOn());
            Switch.Work(new ButtomOff());
            Console.ReadLine();
        }
    }
}
