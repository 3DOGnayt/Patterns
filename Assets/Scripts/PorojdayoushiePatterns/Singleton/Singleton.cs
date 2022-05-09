using System;

namespace Assets.Scripts.PorojdayoushiePatterns.Singleton
{
    class Singleton
    {
        private static Singleton instance;

        private Singleton()
        { }

        public static Singleton Instance()
        {
            if (instance == null)
                instance = new Singleton();
            return instance;
        }

        public void Do()
        {
            Console.WriteLine("eboy");
        }

    }
}
