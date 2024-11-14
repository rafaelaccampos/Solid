using Solid.Interface_Segregation.After;

namespace Solid.Tests.InterfaceSegregation.Before;

public class MultifunctionPrinterTests
{
    [Fact]
    public void MultifunctionPrinterShouldPrintCorrectly()
    {
        var multifunctionPrinter = new MultifunctionPrinter();

        var result = multifunctionPrinter.Print();

        Assert.Equal("Printing document!", result);
    }

    [Fact]
    public void MultifunctionPrinter_ShouldScanCorrectly()
    {
        var multifunctionPrinter = new MultifunctionPrinter();

        var result = multifunctionPrinter.Scan();

        Assert.Equal("Scanning document!", result);
    }

    [Fact]
    public void MultifunctionPrinter_ShouldFaxCorrectly()
    {
        var multifunctionPrinter = new MultifunctionPrinter();

        var result = multifunctionPrinter.Fax();

        Assert.Equal("Faxing document!", result);
    }
}
