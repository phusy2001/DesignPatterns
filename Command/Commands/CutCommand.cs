using Command.Interfaces;

namespace Command.Commands
{
    internal class CutCommand : ICommand
    {
        private readonly ClipBoard _clipboard;
        private string _content;

        public CutCommand(ClipBoard clipboard, string content)
        {
            _clipboard = clipboard;
            _content = content;
        }

        public void Execute()
        {
            _clipboard.Cut(_content);
        }
    }
}
