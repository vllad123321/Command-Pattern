using System;
using Command_Pattern.Commands;
using Command_Pattern.Models;

namespace Command_Pattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var editor = new TextEditor();
            var commandManager = new CommandManager();

            Console.WriteLine("Text Editor Demo:");

            var insertCommand = new InsertTextCommand(editor, "Hello, World!");
            commandManager.ExecuteCommand(insertCommand);
            Console.WriteLine($"Text after insert: {editor.Text}");

            var deleteCommand = new DeleteTextCommand(editor, 7, 6);
            commandManager.ExecuteCommand(deleteCommand);
            Console.WriteLine($"Text after delete: {editor.Text}");

            Console.WriteLine("Undoing last command...");
            commandManager.Undo();
            Console.WriteLine($"Text after undo: {editor.Text}");

            Console.WriteLine("Undoing previous command...");
            commandManager.Undo();
            Console.WriteLine($"Text after undo: {editor.Text}");
        }
    }
}
