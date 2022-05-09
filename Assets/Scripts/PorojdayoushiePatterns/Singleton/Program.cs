using System;

namespace Assets.Scripts.PorojdayoushiePatterns.Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton s = Singleton.Instance();
            s.Do();

            Singleton2 a = Singleton2.Instance2();
            Console.WriteLine(a);

            Singleton2 b = Singleton2.Instance2();
            Console.WriteLine(b);

        }
    }
}
