using Solid.Interface_Segregation.Before;

namespace Solid.Tests.InterfaceSegregation.Before;

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
