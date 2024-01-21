namespace Command
{
    internal class ClipBoard
    {
        private string _content;

        public ClipBoard()
        {
            _content = string.Empty;
        }

        public void Cut(string content)
        {
            _content = content;
            Console.WriteLine("Text cut: {0}", content);
        }

        public void Copy(string content)
        {
            _content = content;
            Console.WriteLine("Text copied: {0}", content);
        }

        public void Paste()
        {
            if (_content != null)
            {
                Console.WriteLine("Text pasted: {0}", _content);
            }
            else
            {
                Console.WriteLine("Clipboard is empty.");
            }
        }

        public string GetContent
        {
            get { return _content; }
        }
    }
}
