using Solid.Liskov_Substitution.After;

namespace Solid.Tests.LiskovSubstitution.After;

public class PenguinTests
{
    [Fact]
    public void PenguinShouldEatCorrectly()
    {
        var penguin = new Penguin();

        var result = penguin.Eat();

        Assert.Equal("Penguin is eating!", result);
    }
}
