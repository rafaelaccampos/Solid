using Solid.OpenClosed.After;

namespace Solid.Tests.OpenClosed.After;

public class PremiumCustomerDiscountTests
{
    [Fact]
    public void ShouldBeAbleToCalculatePremiumCustomerDiscount()
    {
        const decimal AMOUNT = 100m;

        var premiumCustomerDiscount = new PremiumCustomerDiscount();
        var discount = premiumCustomerDiscount.ApplyDiscount(AMOUNT);

        Assert.Equal(20m, discount);
    }
}
