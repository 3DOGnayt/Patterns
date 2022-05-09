using System;

namespace Assets.Scripts.PatternsPovideniya.Chain_of_responsibility
{
    class Morg : Obrashenie
    {
        public override void Peredano(Poliklinika poliklinika)
        {
            if (poliklinika.Morg == true)
                Console.WriteLine("Opa, eshe odin");
            else if (Priniato != null)
                Console.WriteLine("Tak ti jivoy eshe? Any von otsyda");
                Priniato.Peredano(poliklinika);
        }
    }
}
