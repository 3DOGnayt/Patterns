using System;

namespace Assets.Scripts.PatternsPovideniya.State
{
    class LiquidWaterState : IWaterState
    {
        public void Heat(Water water)
        {
            Console.WriteLine("Prevrashenie v gas");
            water.State = new GasWaterState();
        }

        public void Frost(Water water)
        {
            Console.WriteLine("Prevrashenie v led");
            water.State = new SolidWaterState();
        }

    }
}
