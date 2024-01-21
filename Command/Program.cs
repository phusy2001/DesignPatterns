using Command.Commands;

namespace Command
{
    public class Program
    {
        static void Main(string[] args)
        {
            var clipboard = new ClipBoard();

            var cutButton = new Button(new CutCommand(clipboard, "This text will be cut."));
            var copyButton = new Button(new CopyCommand(clipboard, "This text will be copied."));
            var pasteButton = new Button(new PasteCommand(clipboard));

            cutButton.Click();   
            pasteButton.Click();
            copyButton.Click();
            pasteButton.Click();
        }
    }
}
