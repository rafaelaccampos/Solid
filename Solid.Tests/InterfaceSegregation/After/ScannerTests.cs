using Solid.Interface_Segregation.After;

namespace Solid.Tests.InterfaceSegregation.After;

public class ScannerTests
{
    [Fact]
    public void Scanner_ShouldScanCorrectly()
    {
        var scanner = new Scanner();

        var result = scanner.Scan();

        Assert.Equal("Scanning document!", result);
    }
}
