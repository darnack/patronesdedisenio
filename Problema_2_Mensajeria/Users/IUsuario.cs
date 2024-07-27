using Problema_2_Mensajeria.Dispositivos;

namespace Problema_2_Mensajeria.Users
{
    public interface IUsuario
    {
        void AgregarDispositivo(IDispositivo PrmObjDispositivo);

        void EliminarDispositivo(IDispositivo PrmObjDispositivo);

        void Notificar(string PrmStrMensaje);
    }
}