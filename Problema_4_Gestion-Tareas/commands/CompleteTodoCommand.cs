using Problema_4_Gestion_Tareas.managers;
using Problema_4_Gestion_Tareas.models;
using Problema_4_Gestion_Tareas.interfaces;

namespace Problema_4_Gestion_Tareas.commands
{
    internal class CompleteTodoCommand(ToDo toDo, ToDoManager toDoManager) : ICommand
    {
        private ToDo _toDo = toDo;
        private ToDoManager _toDoManager = toDoManager;
        public void Execute()
        {
            _toDoManager.CompleteToDo(_toDo);
        }

        public void Undo()
        {
            _toDoManager.UncompleteToDo(_toDo);
        }
    }
}
