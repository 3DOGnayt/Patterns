namespace Assets.Scripts.PatternsPovideniya.Command
{
    class Pult
    {
        ICommand command;

        public Pult()
        {
            command = new NoCommand();
        }

        public void SetCommand(ICommand com)
        {
            command = com;
        }

        public void PressButton()
        {
            command.Execute();
        }

        public void Undo()
        {
            command.Undo();
        }

        private class NoCommand : ICommand
        {
            public void Execute()
            {
                
            }

            public void Undo()
            {
               
            }
        }
    }
}
