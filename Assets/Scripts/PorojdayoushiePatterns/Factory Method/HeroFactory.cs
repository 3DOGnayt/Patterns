namespace Assets.Scripts.PorojdayoushiePatterns.Factory_Method
{
    class HeroFactory
    {
        public static IHero Creator(TypeHero type)
        {
            switch (type)
            {
                case TypeHero.Archer:
                    return new Archer();
                case TypeHero.Knight:
                    return new Knight();
                default: return new Enemy();
            }
        }
    }
}


