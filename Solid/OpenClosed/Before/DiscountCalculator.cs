namespace Solid.OpenClosed.Before;

public class DiscountCalculator
{
    public decimal CalculateDiscount(string customerType, decimal amount)
    {
        return customerType switch
        {
            "Regular" => amount * 0.1m,
            "Premium" => amount * 0.2m,
            // Caso se adicione um novo tipo de cliente, este código precisará ser modificado
            _ => 0,
        };
    }
}
