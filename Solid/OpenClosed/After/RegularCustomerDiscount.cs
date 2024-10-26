namespace Solid.OpenClosed.After
{
    public class RegularCustomerDiscount : IDiscount
    {
        public decimal ApplyDiscount(decimal amount)
        {
            return amount * 0.1m;
        }
    }
}
