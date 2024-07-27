using Problema_4_Gestion_Tareas.models;

namespace Problema_4_Gestion_Tareas.interfaces
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}
