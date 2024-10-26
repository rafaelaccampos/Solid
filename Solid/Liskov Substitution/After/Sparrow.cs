using Solid.Liskov_Substitution.Before;

namespace Solid.Liskov_Substitution.After;

public class Sparrow : Bird, IFlyable
{
    public override string Eat()
    {
        return "Sparrow is eating!";
    }

    public override string Fly()
    {
        return "Sparrow flying!";
    }
}
