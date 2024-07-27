using Problema_4_Gestion_Tareas.interfaces;

namespace Problema_4_Gestion_Tareas.commands
{
    public class CommandHandler
    {
        private Stack<ICommand> _commandHistory = new();

        public void ExecuteCommand(ICommand command)
        {
            command.Execute();
            _commandHistory.Push(command);
        }

        public void UndoLastCommand()
        {
            if (_commandHistory.Count > 0)
            {
                ICommand lastCommand = _commandHistory.Pop();
                lastCommand.Undo();
            }
        }
    }
}
