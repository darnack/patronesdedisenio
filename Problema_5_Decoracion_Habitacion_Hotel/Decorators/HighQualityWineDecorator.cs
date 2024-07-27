namespace Problema_5_Decoracion_Habitacion_Hotel;

public class HighQualityWineDecorator : BaseDecorator
{
    public HighQualityWineDecorator(IRoom room) : base(room) { }

    public override string GetDescription()
    {
        return _room.GetDescription() + ", High-Quality Wine";
    }

    public override double GetCost()
    {
        return _room.GetCost() + 70.0;
    }
}