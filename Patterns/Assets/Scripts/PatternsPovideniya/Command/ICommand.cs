namespace Assets.Scripts.PatternsPovideniya.Command
{
    interface ICommand
    {
        void Execute();
        void Undo();
    }
}
