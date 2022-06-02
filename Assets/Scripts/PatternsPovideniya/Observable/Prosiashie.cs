using System;
namespace Assets.Scripts.PatternsPovideniya.Observable
{
    class Prosiashie : IProsiashy
    {
        public void Update(object ob)
        {
            NastroenieInfo nastroenie = (NastroenieInfo)ob;

            if (nastroenie == NastroenieInfo.zamechatelnoe)
                Console.WriteLine("Всем сыра!!!");
            if (nastroenie == NastroenieInfo.nezamechatelnoe)
                Console.WriteLine("Убить всех");
            if (nastroenie == NastroenieInfo.mmmm)
                Console.WriteLine("Скууууучнаааааа");            
        }
    }
}
