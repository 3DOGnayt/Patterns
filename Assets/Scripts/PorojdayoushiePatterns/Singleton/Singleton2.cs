using System;

namespace Assets.Scripts.PorojdayoushiePatterns.Singleton
{
    class Singleton2
    {
        private static Singleton2 instance = new Singleton2();
        public string cho;

        private Singleton2()
        {
            Console.WriteLine(cho);
        }

        public static Singleton2 Instance2()
        {
            //if (instance == null)
            //    instance = new Singleton2();
            return instance;
        }

    }
}
