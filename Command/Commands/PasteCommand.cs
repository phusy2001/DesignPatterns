using Command.Interfaces;

namespace Command.Commands
{
    internal class PasteCommand : ICommand
    {
        private readonly ClipBoard _clipboard;

        public PasteCommand(ClipBoard clipboard)
        {
            _clipboard = clipboard;
        }

        public void Execute()
        {
            _clipboard.Paste();
        }
    }
}
