namespace Solid.OpenClosed.After;

public class PremiumCustomerDiscount : IDiscount
{
    public decimal ApplyDiscount(decimal amount)
    {
        return amount * 0.2m;
    }
}
