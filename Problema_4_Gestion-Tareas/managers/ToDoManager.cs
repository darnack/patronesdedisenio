using Problema_4_Gestion_Tareas.models;

namespace Problema_4_Gestion_Tareas.managers
{
    public class ToDoManager
    {
        private List<ToDo> ToDos = [];

        public void AddToDo(ToDo toDo)
        {
            ToDos.Add(toDo);
        }

        public void RemoveToDo(ToDo toDo)
        {
            ToDos.Remove(toDo);
        }

        public void EditTodo(ToDo oldToDo, ToDo newToDo)
        {
            int index = ToDos.IndexOf(oldToDo);
            if (index != -1)
            {
                ToDos[index] = newToDo;
            }
        }

        public void CompleteToDo(ToDo ToDo)
        {
            ToDo.Complete();
        }

        public void UncompleteToDo(ToDo ToDo)
        {
            ToDo.Uncomplete();
        }

        public void ShowToDos()
        {
            Console.WriteLine("ToDos:");
            foreach (var ToDo in ToDos)
            {
                Console.WriteLine($"- {ToDo.Name} (Completed: {ToDo.IsCompleted})");
            }
        }
    }
}
