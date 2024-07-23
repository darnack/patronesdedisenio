using Problema_2_Mensajeria.Dispositivos;

namespace Problema_2_Mensajeria.Users
{
    /// <summary>
    /// Interfaz que define las acciones permitidas para un usuario.
    /// </summary>
    public interface IUsuario
    {
        /// <summary>
        /// Agrega un nuevo dispositivo a la lista del usuario.
        /// </summary>
        /// <param name="PrmObjDispositivo">Dispositivo que será agregado.</param>
        void AgregarDispositivo(IDispositivo PrmObjDispositivo);
        /// <summary>
        /// Elimin un dispositivo a la lista del usuario.
        /// </summary>
        /// <param name="PrmObjDispositivo">Dispositivo que será eliminado.</param>
        void EliminarDispositivo(IDispositivo PrmObjDispositivo);
        /// <summary>
        /// Realiza la notificación a los dispositivos del usuario.
        /// </summary>
        /// <param name="PrmStrMensaje">Mensaje de la notificación</param>
        void Notificar(string PrmStrMensaje);
    }
}