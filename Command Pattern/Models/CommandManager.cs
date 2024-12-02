using System.Collections.Generic;
using Command_Pattern.Commands;

namespace Command_Pattern.Models
{
    internal class CommandManager
    {
        private readonly Stack<ICommand> _commandHistory = new();

        public void ExecuteCommand(ICommand command)
        {
            command.Execute();
            _commandHistory.Push(command);
        }

        public void Undo()
        {
            if (_commandHistory.Count > 0)
            {
                var lastCommand = _commandHistory.Pop();
                lastCommand.Undo();
            }
        }
    }
}
