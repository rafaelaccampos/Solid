namespace Solid.OpenClosed.Before
{
    public class DiscountCalculator
    {
        public decimal CalculateDiscount(string customerType, decimal amount)
        {
            if (customerType == "Regular")
            {
                return amount * 0.1m;
            }
            else if (customerType == "Premium")
            {
                return amount * 0.2m;
            }
            // Caso se adicione um novo tipo de cliente, este código precisará ser modificado
            return 0;
        }
    }
}
