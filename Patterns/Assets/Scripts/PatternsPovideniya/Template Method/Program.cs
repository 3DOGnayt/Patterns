using System;

namespace Assets.Scripts.PatternsPovideniya.Template_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            School school = new School();
            University university = new University();

            school.Learn();
            university.Learn();

            Console.ReadLine();

        }

    }
}
