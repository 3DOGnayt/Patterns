using System;

namespace Assets.Scripts.PatternsPovideniya.Template_Method
{
    class University : Education
    {
        public override void Enter()
        {
            Console.WriteLine("Sdaem vstupitelnie");
        }
        public override void Study()
        {
            Console.WriteLine("Uchimsia");
            Console.WriteLine("Praktika");
        }

        public override void PassExams()
        {
            Console.WriteLine("Sdaem examen po specialnosti");
        }

        public override void GetDocument()
        {
            Console.WriteLine("Nu i zachem mne diplom?");
        }

    }
}
