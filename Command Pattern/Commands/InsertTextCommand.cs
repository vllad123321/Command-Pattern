
using Command_Pattern.Models;


namespace Command_Pattern.Commands
{
    internal class InsertTextCommand : ICommand
    {
        private readonly TextEditor _editor;
        private readonly string _text;
        private int _startPosition;

        public InsertTextCommand(TextEditor editor, string text)
        {
            _editor = editor;
            _text = text;
        }

        public void Execute()
        {
            _startPosition = _editor.Text.Length;
            _editor.AppendText(_text);
        }

        public void Undo()
        {
            _editor.RemoveText(_startPosition, _text.Length);
        }
    }
}
