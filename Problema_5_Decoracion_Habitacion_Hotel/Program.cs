using Problema_5_Decoracion_Habitacion_Hotel;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(Environment.NewLine);

        IRoom basicRoom = new BasicRoom();
        Console.WriteLine($"{basicRoom.GetDescription()} costs {basicRoom.GetCost()}");

        basicRoom = new HighQualityWineDecorator(basicRoom);
        Console.WriteLine($"{basicRoom.GetDescription()} costs {basicRoom.GetCost()}");

        basicRoom = new FreshFlowersDecorator(basicRoom);
        Console.WriteLine($"{basicRoom.GetDescription()} costs {basicRoom.GetCost()}");

        basicRoom = new GourmetChocolateDecorator(basicRoom);
        Console.WriteLine($"{basicRoom.GetDescription()} costs {basicRoom.GetCost()}");

        Console.WriteLine(Environment.NewLine);

        IRoom suiteRoom = new SuiteRoom();
        Console.WriteLine($"{suiteRoom.GetDescription()} costs {suiteRoom.GetCost()}");

        suiteRoom = new HighQualityWineDecorator(suiteRoom);
        Console.WriteLine($"{suiteRoom.GetDescription()} costs {suiteRoom.GetCost()}");

        suiteRoom = new FreshFlowersDecorator(suiteRoom);
        Console.WriteLine($"{suiteRoom.GetDescription()} costs {suiteRoom.GetCost()}");

        suiteRoom = new GourmetChocolateDecorator(suiteRoom);
        Console.WriteLine($"{suiteRoom.GetDescription()} costs {suiteRoom.GetCost()}");
        
    }
}
