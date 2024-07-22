namespace Problema_5_Decoracion_Habitacion_Hotel;

public class GourmetChocolateDecorator : BaseDecorator
{
    public GourmetChocolateDecorator(IRoom room) : base(room) { }

    public override string GetDescription()
    {
        return _room.GetDescription() + ", Gourmet Chocolate";
    }

    public override double GetCost()
    {
        return _room.GetCost() + 35.0;
    }
}