namespace Problema_2_Mensajeria.Implementers
{
    public class User : ISubscriber
    {
        private readonly string UserName;

        public List<Device> Devices = [];

        public User(string userName)
        {
            UserName = userName;
        }

        public void AddDevice(Device device)
        {
            Devices.Add(device);
            Console.WriteLine($"Se ha agregado un nuevo dispositivo {device.GetName()} al usuario {UserName}.{Environment.NewLine}");
        }

        public void RemoveDevice(Device device)
        {
            Devices.Remove(device);
            Console.WriteLine($"Se ha eliminado el dispositivo {device.GetName()} del usuario {UserName}.{Environment.NewLine}");
        }

        public void Update(string context)
        {
            foreach (var device in Devices)
            {
                device.UpdateDevice(context, UserName);
            }
        }
    }
}