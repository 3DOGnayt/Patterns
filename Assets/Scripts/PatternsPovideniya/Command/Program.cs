using System;

namespace Assets.Scripts.PatternsPovideniya.Command
{
    class Program
    {
        static void Main(string[] args)
        {
            Pult pult = new Pult();
            TV tv = new TV();
            pult.SetCommand(new TVOnCommand(tv));
            pult.PressButton();
            pult.Undo();

            Microwave microwave = new Microwave();
            pult.SetCommand(new MicrowaveCommand(microwave, 5000));
            pult.PressButton();

            Console.ReadLine();
        }
    }
}
