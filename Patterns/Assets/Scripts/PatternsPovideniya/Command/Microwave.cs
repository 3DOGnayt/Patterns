using System;
using System.Threading.Tasks;

namespace Assets.Scripts.PatternsPovideniya.Command
{
    class Microwave
    {
        public void StartCooking(int time)
        {
            Console.WriteLine("Nachinaem gotovit");
            Task.Delay(time).GetAwaiter().GetResult();
        }

        public void StopCooking()
        {
            Console.WriteLine("Zakanchivaem gotovit");
        }
    }
}
