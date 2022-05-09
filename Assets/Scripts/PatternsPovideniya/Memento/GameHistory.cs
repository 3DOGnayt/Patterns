using System.Collections.Generic;

namespace Assets.Scripts.PatternsPovideniya.Memento
{
    class GameHistory
    {
        public Stack<HeroMemento> History { get; private set; }
        public GameHistory()
        {
            History = new Stack<HeroMemento>();
        }
    }
}
