namespace Solid.OpenClosed.After;

public class DiscountCalculator(IDiscount discount)
{
    private readonly IDiscount _discount = discount;

    public decimal CalculateDiscount(decimal amount)
    {
        return _discount.ApplyDiscount(amount);
    }
}
