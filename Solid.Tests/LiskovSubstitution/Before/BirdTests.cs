using Solid.Liskov_Substitution.Before;

namespace Solid.Tests.LiskovSubstitution.Before;

public class BirdTests
{
    [Fact]
    public void BirdShouldFly()
    {
        var bird = new Bird();

        var result = bird.Fly();

        Assert.Equal("I can fly!", result);
    }
}
