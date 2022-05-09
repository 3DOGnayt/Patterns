using System;

namespace Assets.Scripts.PatternsPovideniya.Chain_of_responsibility
{
    public class Program
    {
        static void Main(string[] args)
        {
            Poliklinika poliklinika = new Poliklinika(false, false, false);

            Obrashenie terapevt = new Terapevt();
            Obrashenie hiryrg = new Hiryrg();
            Obrashenie morg = new Morg();

            terapevt.Priniato = hiryrg;
            hiryrg.Priniato = morg;
            morg.Peredano(poliklinika);

            Console.ReadLine();

        }
    }

}