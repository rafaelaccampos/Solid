using Solid.Liskov_Substitution.After;

namespace Solid.Tests.LiskovSubstitution.After;

public class SparrowTests
{
    [Fact]
    public void SparrowShouldEatCorrectly()
    {
        var sparrow = new Sparrow();

        var result = sparrow.Eat();

        Assert.Equal("Sparrow is eating!", result);
    }

    [Fact]
    public void SparrowShouldFlyCorrectly()
    {
        var sparrow = new Sparrow();

        var result = sparrow.Fly();

        Assert.Equal("Sparrow flying!", result);
    }
}
