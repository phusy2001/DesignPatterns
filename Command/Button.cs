using Command.Interfaces;

namespace Command
{
    internal class Button
    {
        private ICommand _command;

        public Button()
        {

        }

        public Button(ICommand command) {
            _command = command;
        }

        public void Click()
        {
            _command.Execute();
        }
    }
}
