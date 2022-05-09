using System;

namespace Assets.Scripts.PatternsPovideniya.Memento
{
    class Hero
    {
        private int patrons = 10; 
        private int lives = 5; 

        public void Shoot()
        {
            if (patrons > 0)
            {
                patrons--;
                Console.WriteLine("Shmalaem. Ostalos {0} ammo", patrons);
            }
            else
                Console.WriteLine("I need ammo");
        }
        
        public HeroMemento SaveState()
        {
            Console.WriteLine("Saved. Parameters: {0} ammo, {1} lives", patrons, lives);
            return new HeroMemento(patrons, lives);
        }

        public void RestoreState(HeroMemento memento)
        {
            this.patrons = memento.Patrons;
            this.lives = memento.Lives;
            Console.WriteLine("Restore game. Parameters: {0} ammo, {1} lives", patrons, lives);
        }
    }
}
