using System;
namespace Assets.Scripts.PatternsPovideniya.Observable
{
    class Prosiashie : IProsiashy
    {
        public void Update(object ob)
        {
            NastroenieInfo nastroenie = (NastroenieInfo)ob;

            if (nastroenie.zamechatelnoe == 1)
                Console.WriteLine("Всем сыра!!!");
            if (nastroenie.nezamechatelnoe == 2)
                Console.WriteLine("Убить всех");
            if (nastroenie.mmmm == 0)
                Console.WriteLine("Скууууучнаааааа");            
        }
    }
}
