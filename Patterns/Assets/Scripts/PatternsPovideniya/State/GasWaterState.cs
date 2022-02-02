using System;

namespace Assets.Scripts.PatternsPovideniya.State
{
    class GasWaterState : IWaterState
    {

        public void Heat(Water water)
        {
            Console.WriteLine("Nagrevaem");
        }
        public void Frost(Water water)
        {
            Console.WriteLine("Prevrashenie v vody");
            water.State = new LiquidWaterState();
        }
    }
}
