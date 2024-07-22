namespace Problema_5_Decoracion_Habitacion_Hotel;

public class BasicRoom : IRoom
{
    public double GetCost()
    {
        return 100.0;
    }

    public string GetDescription()
    {
        return "Basic Room: Double Beb Size and Pillow";
    }
}
