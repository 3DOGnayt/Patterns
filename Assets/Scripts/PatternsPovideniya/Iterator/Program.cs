using System;

namespace Assets.Scripts.PatternsPovideniya.Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            Reader reader = new Reader();
            reader.SeeBooks(library);

            Console.Read();
        }

    }

}