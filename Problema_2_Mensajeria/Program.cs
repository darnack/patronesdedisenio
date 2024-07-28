using Problema_2_Mensajeria;
using Problema_2_Mensajeria.Implementers;

Console.WriteLine("Sistema de mensajería.");

Device ObjComputador = new Device("Computador");
Device ObjCelular = new Device("Celular");
var ObjUsuario1 = new User("Daniel");
ObjUsuario1.AddDevice(ObjComputador);
ObjUsuario1.AddDevice(ObjCelular);


Device ObjAsistenteHogar = new Device("Asistente de hogar");
var ObjUsuario2 = new User("Jorge");
ObjUsuario2.AddDevice(ObjAsistenteHogar);

var publisher = new Publisher();

publisher.Subscribe(ObjUsuario1);
publisher.Subscribe(ObjUsuario2);

publisher.NotifySubscribers("El producto Alfa ya se encuentra disponible!");
publisher.NotifySubscribers("En 2 días se ha programado el mantenimiento de tu vehículo.");

