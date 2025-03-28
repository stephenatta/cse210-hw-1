using System;
using System.Collections.Generic;

public class Order
{
    private List<Product> products;
    private Customer customer;

    public Order(Customer customer)
    {
        this.customer = customer;
        products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public double GetTotalCost()
    {
        double total = 0;
        foreach (var product in products)
        {
            total += product.GetTotalCost();
        }
        return total + (customer.IsInUSA() ? 5 : 35);  // Shipping cost
    }

    public string GetPackingLabel()
    {
        string label = "Packing List:\n";
        foreach (var product in products)
        {
            label += $"- {product}\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return $"Shipping To:\n{customer.Name}\n{customer.Address}";
    }
}
