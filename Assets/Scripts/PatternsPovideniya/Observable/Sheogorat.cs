using System.Collections.Generic;

namespace Assets.Scripts.PatternsPovideniya.Observable
{
    class Sheogorat : ISheogorat
    {
        NastroenieInfo nastroenie;

        private List<IProsiashy> prosiashie;

        public Sheogorat()
        {
            prosiashie = new List<IProsiashy>();
            nastroenie = new NastroenieInfo();
        }

        public void AddProsiashy(IProsiashy o)
        {
            prosiashie.Add(o);
        }

        public void RemoveProsiashy(IProsiashy o)
        {
            prosiashie.Remove(o);
        }

        public void Notify()
        {
            foreach (IProsiashy prosiashy in prosiashie)
                prosiashy.Update(nastroenie);
        }
    }
    

    enum NastroenieInfo
    {
        zamechatelnoe,
        nezamechatelnoe,
        mmmm
    }
}
