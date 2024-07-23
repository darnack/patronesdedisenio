namespace Problema_2_Mensajeria.Dispositivos
{
    /// <summary>
    /// Interfaz que define el comportamiento de un dispositivo.
    /// </summary>
    public interface IDispositivo
    {
        /// <summary>
        /// Obtiene el valor del nombre del dispositivo.
        /// </summary>
        /// <returns>Texto con el nombre del dispositivo.</returns>
        string ObtenerNombre();
        /// <summary>
        /// Acción al recibir un mensaje, define la notificación.
        /// </summary>
        /// <param name="PrmStrMensaje">Texto recibido en la notificación.</param>
        void Actualizar(string PrmStrMensaje);
    }
}