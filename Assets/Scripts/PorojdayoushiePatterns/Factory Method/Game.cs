namespace Assets.Scripts.PorojdayoushiePatterns.Factory_Method
{
    class Game
    {
        static void Main(string[] args)
        {
            var a = HeroFactory.Creator(TypeHero.Archer);
            var b = HeroFactory.Creator(TypeHero.Enemy);
            var c = HeroFactory.Creator(TypeHero.Knight);

        }
    }
}

