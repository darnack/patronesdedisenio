using Problema_4_Gestion_Tareas.interfaces;
using Problema_4_Gestion_Tareas.managers;
using Problema_4_Gestion_Tareas.models;

namespace Problema_4_Gestion_Tareas.commands
{
    public class DeleteTodoCommand(ToDo toDo, ToDoManager toDoManager) : ICommand
    {
        private ToDo _toDo = toDo;
        private ToDoManager _toDoManager = toDoManager;
        public void Execute()
        {
            _toDoManager.RemoveToDo(_toDo);
        }

        public void Undo()
        {
            _toDoManager.AddToDo(_toDo);
        }
    }
}
