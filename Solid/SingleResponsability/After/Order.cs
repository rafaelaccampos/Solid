﻿namespace Solid.SingleResponsability.After;

public class Order
{
    private readonly IList<string> _items = new List<string>();

    public void AddItem(string item) { _items.Add(item); }

    public void CalculateTotal()
    {
        // Lógica para calcular o total
    }
}
