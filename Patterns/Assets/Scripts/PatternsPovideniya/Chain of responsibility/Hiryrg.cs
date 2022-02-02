using System;

namespace Assets.Scripts.PatternsPovideniya.Chain_of_responsibility
{
    class Hiryrg : Obrashenie
    {
        public override void Peredano(Poliklinika poliklinika)
        {
            if (poliklinika.Hiryrg == true)
                Console.WriteLine("Shas mi tebe pomojem");
            else if (Priniato != null)
                Console.WriteLine("Ny tyt vse yje. V Morg.");
                Priniato.Peredano(poliklinika);
        }
    }
}
