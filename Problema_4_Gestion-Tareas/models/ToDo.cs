namespace Problema_4_Gestion_Tareas.models
{
    public class ToDo(string name)
    {
        public string Name { get; set; } = name;
        public bool IsCompleted { get; set; } = false;

        public void Complete()
        {
            IsCompleted = true;
        }

        public void Uncomplete()
        {
            IsCompleted = false;
        }
    }
}
