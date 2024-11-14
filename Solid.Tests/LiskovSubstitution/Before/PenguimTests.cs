using Solid.Liskov_Substitution.Before;

namespace Solid.Tests.LiskovSubstitution.Before;

public class PenguimTests
{
    [Fact]
    public void PenguinShouldNotThrowExceptionWhenFlying()
    {
        var penguin = new Sparrow();

        var result = penguin.Fly();

        //Esse assert vai falhar porque gera uma exceção
        Assert.Equal("Penguim does not fly!", result);
    }
}
