namespace Problema_2_Mensajeria.Dispositivos
{
    public class Dispositivo(string PrmStrNombre) : IDispositivo
    {
        private readonly string StrNombre = PrmStrNombre;

        public string ObtenerNombre() => StrNombre;

        public void Actualizar(string PrmStrMensaje)
        {
            Console.WriteLine($"El dispositivo {StrNombre} ha recibido un nuevo mensaje: {PrmStrMensaje}");
        }
    }
}