using Problema_2_Mensajeria.Dispositivos;
using Problema_2_Mensajeria.Users;

Console.WriteLine("Sistema de mensajería.");

IDispositivo ObjComputador = new Dispositivo("Computador");
IDispositivo ObjCelular = new Dispositivo("Celular");
IDispositivo ObjAsistenteHogar = new Dispositivo("Asistente de hogar");

var ObjUsuario1 = new Usuario("Daniel");
ObjUsuario1.AgregarDispositivo(ObjComputador);
ObjUsuario1.AgregarDispositivo(ObjCelular);

var ObjUsuario2 = new Usuario("Jorge");
ObjUsuario2.AgregarDispositivo(ObjAsistenteHogar);


ObjUsuario1.Notificar("El producto Alfa ya se encuentra disponible!");
ObjUsuario2.Notificar("En 2 días se ha programado el mantenimiento de tu vehículo.");

ObjUsuario1.EliminarDispositivo(ObjComputador);


