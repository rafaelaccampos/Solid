using Solid.OpenClosed.After;

namespace Solid.Tests.OpenClosed.After;

public class DiscountCalculatorTests
{

    [Fact]
    public void ShouldBeAbleToCalculateADiscountForRegularCustomer()
    {
        const decimal AMOUNT = 100m;

        var regularCustomerDiscount = new RegularCustomerDiscount();
        var discountCalculator = new DiscountCalculator(regularCustomerDiscount);

        var discount = discountCalculator.CalculateDiscount(AMOUNT);

        Assert.Equal(10m, discount);
    }

    [Fact]
    public void ShouldBeAbleToCalculateADiscountForPremiumCustomer()
    {
        const decimal AMOUNT = 100m;

        var premiumCustomerDiscount = new PremiumCustomerDiscount();
        var discountCalculator = new DiscountCalculator(premiumCustomerDiscount);

        var discount = discountCalculator.CalculateDiscount(AMOUNT);

        Assert.Equal(20m, discount);
    }
}
