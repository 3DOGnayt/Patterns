using System;

namespace Assets.Scripts.PatternsPovideniya.Chain_of_responsibility
{
    class Terapevt : Obrashenie
    {
        public override void Peredano(Poliklinika poliklinika)
        {
            if (poliklinika.Terapevt == true)
                Console.WriteLine("Tyt izi, pospi");
            else if (Priniato != null)
                Console.WriteLine("Tebe k Hiryrgy");
                Priniato.Peredano(poliklinika);
        }
    }
}
