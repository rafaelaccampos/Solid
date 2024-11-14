using Solid.Interface_Segregation.Before;

namespace Solid.Tests.InterfaceSegregation.Before;

public class FaxMachineTests
{
    [Fact]
    public void FaxMachineShouldFaxCorrectly()
    {
        var faxMachine = new FaxMachine();

        var result = faxMachine.Fax();

        Assert.Equal("Faxing document", result);
    }
}
