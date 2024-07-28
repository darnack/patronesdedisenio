namespace Problema_2_Mensajeria.Implementers
{
    public class Device
    {
        private readonly string Name;

        public Device(string name)
        {
            Name = name;
        }

        public string GetName()
        {
            return Name;
        }

        public void UpdateDevice(string message, string owner)
        {
            Console.WriteLine($"El dispositivo {Name} de {owner} ha recibido un nuevo mensaje: {message}");
        }
    }
}