using System;

namespace Assets.Scripts.PatternsPovideniya.State
{
    class SolidWaterState : IWaterState
    {
        public void Heat(Water water)
        {
            Console.WriteLine("Prevrashenie v vody");
            water.State = new LiquidWaterState();
        }

        public void Frost(Water water)
        {
            Console.WriteLine("Ohlagdaem");
        }
    }
}
