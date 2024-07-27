using Problema_2_Mensajeria.Dispositivos;

namespace Problema_2_Mensajeria.Users
{
    public class Usuario(string PrmStrNombreUsuario) : IUsuario
    {
        private readonly string StrNombre = PrmStrNombreUsuario;

        public List<IDispositivo> LstDispositivos = [];

        public void AgregarDispositivo(IDispositivo PrmObjDispositivo)
        {
            LstDispositivos.Add(PrmObjDispositivo);
            Console.WriteLine($"Se ha agregado un nuevo dispositivo {PrmObjDispositivo.ObtenerNombre()} al usuario {StrNombre}.{Environment.NewLine}");
        }

        public void EliminarDispositivo(IDispositivo PrmObjDispositivo)
        {
            LstDispositivos.Remove(PrmObjDispositivo);
            Console.WriteLine($"Se ha eliminado el dispositivo {PrmObjDispositivo.ObtenerNombre()} del usuario {StrNombre}.{Environment.NewLine}");
        }

        public void Notificar(string PrmStrMensaje)
        {
            Console.WriteLine($"Se inicia proceso de notificación al usuario {StrNombre}.");
            foreach (var ObjDispositivo in LstDispositivos)
                ObjDispositivo.Actualizar(PrmStrMensaje);
            Console.WriteLine($"Se finaliza proceso de notificación al usuario {StrNombre}.{Environment.NewLine}");
        }
    }
}