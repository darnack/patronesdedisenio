using Problema_2_Mensajeria.Dispositivos;

namespace Problema_2_Mensajeria.Users
{
    /// <summary>
    /// Clase que representa a un usuario junto con las acciones de sus dispositivos.
    /// </summary>
    /// <param name="PrmStrNombreUsuario">Nombre que tendrá el usuario.</param>
    public class Usuario(string PrmStrNombreUsuario) : IUsuario
    {
        /// <summary>
        /// Nombre del usuario.
        /// </summary>
        private readonly string StrNombre = PrmStrNombreUsuario;
        /// <summary>
        /// Lista de dispositivos del usuario.
        /// </summary>
        public List<IDispositivo> LstDispositivos = [];

        /// <summary>
        /// Agrega un nuevo dispositivo a la lista del usuario.
        /// </summary>
        /// <param name="PrmObjDispositivo">Dispositivo que será agregado.</param>
        public void AgregarDispositivo(IDispositivo PrmObjDispositivo)
        {
            LstDispositivos.Add(PrmObjDispositivo);
            Console.WriteLine($"Se ha agregado un nuevo dispositivo {PrmObjDispositivo.ObtenerNombre()} al usuario {StrNombre}.{Environment.NewLine}");
        }

        /// <summary>
        /// Elimin un dispositivo a la lista del usuario.
        /// </summary>
        /// <param name="PrmObjDispositivo">Dispositivo que será eliminado.</param>
        public void EliminarDispositivo(IDispositivo PrmObjDispositivo)
        {
            LstDispositivos.Remove(PrmObjDispositivo);
            Console.WriteLine($"Se ha eliminado el dispositivo {PrmObjDispositivo.ObtenerNombre()} del usuario {StrNombre}.{Environment.NewLine}");
        }

        /// <summary>
        /// Realiza la notificación a los dispositivos del usuario.
        /// </summary>
        /// <param name="PrmStrMensaje">Mensaje de la notificación</param>
        public void Notificar(string PrmStrMensaje)
        {
            Console.WriteLine($"Se inicia proceso de notificación al usuario {StrNombre}.");
            foreach (var ObjDispositivo in LstDispositivos)
                ObjDispositivo.Actualizar(PrmStrMensaje);
            Console.WriteLine($"Se finaliza proceso de notificación al usuario {StrNombre}.{Environment.NewLine}");
        }
    }
}