namespace Assets.Scripts.PatternsPovideniya.Chain_of_responsibility
{
    abstract class Obrashenie
    {
        public Obrashenie Priniato { get; set; }
        public abstract void Peredano(Poliklinika poliklinika);
    }
}
