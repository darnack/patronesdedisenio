namespace Problema_5_Decoracion_Habitacion_Hotel;

public class FreshFlowersDecorator : BaseDecorator
{
    public FreshFlowersDecorator(IRoom room) : base(room) { }

    public override string GetDescription()
    {
        return _room.GetDescription() + ", Fresh Flowers";
    }

    public override double GetCost()
    {
        return _room.GetCost() + 25.0;
    }
}