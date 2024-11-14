using Solid.Liskov_Substitution.Before;

namespace Solid.Tests.LiskovSubstitution.Before;

public class SparrowTests
{
    [Fact]
    public void SparrowShouldFly()
    {
        var sparrow = new Sparrow();

        var result = sparrow.Fly();

        Assert.Equal("Sparrow flying!", result);
    }
}
