using Solid.Interface_Segregation.After;

namespace Solid.Tests.InterfaceSegregation.After;

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
