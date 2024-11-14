using Solid.Interface_Segregation.After;

namespace Solid.Tests.InterfaceSegregation.After;

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
