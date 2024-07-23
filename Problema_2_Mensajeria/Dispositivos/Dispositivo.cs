namespace Problema_2_Mensajeria.Dispositivos
{
    /// <summary>
    /// Representa un dispositivo.
    /// </summary>
    /// <param name="PrmStrNombre">Nombre que tendrá el dispositivo.</param>
    public class Dispositivo(string PrmStrNombre) : IDispositivo
    {
        /// <summary>
        /// Nombre del dispositivo.
        /// </summary>
        private readonly string StrNombre = PrmStrNombre;

        /// <summary>
        /// Obtiene el valor del nombre del dispositivo.
        /// </summary>
        /// <returns>Texto con el nombre del dispositivo.</returns>
        public string ObtenerNombre() => StrNombre;

        /// <summary>
        /// Genera una notificación al recibir un mensaje.
        /// </summary>
        /// <param name="PrmStrMensaje">Mensaje que genera la actualización.</param>
        public void Actualizar(string PrmStrMensaje)
        {
            Console.WriteLine($"El dispositivo {StrNombre} ha recibido un nuevo mensaje: {PrmStrMensaje}");
        }
    }
}