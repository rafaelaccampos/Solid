using Solid.Interface_Segregation.Before;

namespace Solid.Tests.InterfaceSegregation.Before;

public class PrinterTests
{
    [Fact]
    public void PrinterShouldPrintCorrectly()
    {
        var printer = new Printer();

        var result = printer.Print();

        Assert.Equal("Printing document!", result);
    }
}
