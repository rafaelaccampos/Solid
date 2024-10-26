namespace Solid.Liskov_Substitution.Before;

public class Penguin : Bird
{
    public override string Fly()
    {
        throw new NotImplementedException("Penguins can not fly");
    }
}
