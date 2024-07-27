namespace Problema_5_Decoracion_Habitacion_Hotel;

public class SuiteRoom : IRoom
{
    public double GetCost()
    {
        return 300.0;
    }

    public string GetDescription()
    {
        return "Suite Luxury Room: King Beb Size, Pillow and Smart TV";
    }

}
