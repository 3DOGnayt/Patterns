namespace Assets.Scripts.PatternsPovideniya.Chain_of_responsibility
{
    class Poliklinika
    {
        public bool Terapevt { get; set; }
        public bool Hiryrg { get; set; }
        public bool Morg { get; set; }

        public Poliklinika(bool t, bool h, bool m)
        {
            Terapevt = t;
            Hiryrg = h;
            Morg = m;
        }
    }
}
