namespace Solid.Liskov_Substitution.After;

public class Penguin : Bird
{
    public override string Eat()
    {
        return "Penguin is eating!";
    }

    public override string Fly()
    {
        throw new NotImplementedException("Penguins can't not fly!");
    }
}
