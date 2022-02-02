namespace Assets.Scripts.PatternsPovideniya.Strategy
{
    class Switch
    {        
        public void Work(IState state)
        {
            if (state == null)
                state.Turn();
        }
    }
}
