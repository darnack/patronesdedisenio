namespace Problema_5_Decoracion_Habitacion_Hotel;

public abstract class BaseDecorator : IRoom
{
    protected IRoom _room;

    public BaseDecorator(IRoom room){
        _room = room;
    }
    public virtual double GetCost()
    {
        return _room.GetCost();
    }

    public virtual string GetDescription()
    {
        return _room.GetDescription();
    }
}