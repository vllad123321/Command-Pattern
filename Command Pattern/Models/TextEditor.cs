namespace Command_Pattern.Models
{
    internal class TextEditor
    {
        private System.Text.StringBuilder _text = new();

        public string Text => _text.ToString();

        public void AppendText(string text)
        {
            _text.Append(text);
        }

        public void InsertText(int position, string text)
        {
            _text.Insert(position, text);
        }

        public void RemoveText(int startPosition, int length)
        {
            _text.Remove(startPosition, length);
        }

        public string GetText(int startPosition, int length)
        {
            return _text.ToString(startPosition, length);
        }
    }
}
