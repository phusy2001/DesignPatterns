using Command.Interfaces;

namespace Command.Commands
{
    internal class CopyCommand : ICommand
    {
        private readonly ClipBoard _clipboard;
        private string _content;

        public CopyCommand(ClipBoard clipBoard, string content)
        {
            _clipboard = clipBoard;
            _content = content;
        }

        public void Execute()
        {
            _clipboard.Copy(_content);
        }
    }
}
