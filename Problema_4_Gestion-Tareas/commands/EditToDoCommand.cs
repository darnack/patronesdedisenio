using Problema_4_Gestion_Tareas.interfaces;
using Problema_4_Gestion_Tareas.managers;
using Problema_4_Gestion_Tareas.models;

namespace Problema_4_Gestion_Tareas.commands
{
    public class EditToDoCommand(ToDo newTodo, ToDo oldTodo, ToDoManager toDoManager) : ICommand
    {
        private ToDo _oldToDo = oldTodo;
        private ToDo _newToDo = newTodo;
        private ToDoManager _toDoManager = toDoManager;

        public void Execute()
        {
            _toDoManager.EditTodo(_oldToDo, _newToDo);
        }

        public void Undo()
        {
            _toDoManager.EditTodo(_newToDo, _oldToDo);

        }
    }
}
