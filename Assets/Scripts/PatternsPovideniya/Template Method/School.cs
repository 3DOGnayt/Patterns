using System;

namespace Assets.Scripts.PatternsPovideniya.Template_Method
{
    class School : Education
    {
        public override void Enter()
        {
            Console.WriteLine("Idem uchitsia");
        }

        public override void Study()
        {
            Console.WriteLine("Poseshaem uroki");
        }

        public override void GetDocument()
        {
            Console.WriteLine("Poluchaem doki");
        }

    }
}
