using Command_Pattern.Models;

namespace Command_Pattern.Commands
{
    internal class DeleteTextCommand : ICommand
    {
        private readonly TextEditor _editor;
        private string _deletedText = string.Empty;
        private int _startPosition;

        public DeleteTextCommand(TextEditor editor, int startPosition, int length)
        {
            _editor = editor;
            _startPosition = startPosition;
            _deletedText = _editor.GetText(startPosition, length);
        }

        public void Execute()
        {
            _editor.RemoveText(_startPosition, _deletedText.Length);
        }

        public void Undo()
        {
            _editor.InsertText(_startPosition, _deletedText);
        }
    }
}
