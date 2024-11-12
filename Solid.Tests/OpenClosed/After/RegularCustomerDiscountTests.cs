using Solid.OpenClosed.After;

namespace Solid.Tests.OpenClosed.After;

public class RegularCustomerDiscountTests
{
    [Fact]
    public void ShouldBeAbleToCalculateRegularCustomerDiscount()
    {
        const decimal AMOUNT = 100m;

        var regularCustomerDiscount = new RegularCustomerDiscount();
        var discount = regularCustomerDiscount.ApplyDiscount(AMOUNT);

        Assert.Equal(10m, discount);
    }
}
