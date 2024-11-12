using Solid.OpenClosed.Before;

namespace Solid.Tests.OpenClosed.Before;

public class DiscountCalculatorTests
{
    [Fact]
    public void ShouldBeAbleToCalculateARegularCustomerDiscount()
    {
        const string CUSTOMER_TYPE = "Regular";
        const decimal AMOUNT = 100m;

        var discountCalculator = new DiscountCalculator();
        var discount = discountCalculator.CalculateDiscount(CUSTOMER_TYPE, AMOUNT);

        Assert.Equal(10m, discount);
    }

    [Fact]
    public void ShouldBeAbleToCalculateAPremiumCustomerDiscount()
    {
        const string CUSTOMER_TYPE = "Premium";
        const decimal AMOUNT = 100m;

        var discountCalculator = new DiscountCalculator();
        var discount = discountCalculator.CalculateDiscount(CUSTOMER_TYPE, AMOUNT);

        Assert.Equal(20m, discount);
    }


    [Fact]
    public void ShouldBeAbleToZeroDiscountWhenClientIsNotEspecified()
    {
        var customerType = string.Empty;
        const decimal AMOUNT = 100m;

        var discountCalculator = new DiscountCalculator();
        var discount = discountCalculator.CalculateDiscount(customerType, AMOUNT);

        Assert.Equal(0m, discount);
    }
}
