using System;

class Program
{
    static void Main()
    {
        // Creating customers
        Customer customer1 = new Customer("John Doe", new Address("123 Main St", "New York", "NY", "USA"));
        Customer customer2 = new Customer("Jane Smith", new Address("45 Queen's Rd", "London", "England", "UK"));

        // Creating orders
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "P1001", 999.99, 1));
        order1.AddProduct(new Product("Wireless Mouse", "P1002", 29.99, 2));

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Smartphone", "P2001", 799.99, 1));
        order2.AddProduct(new Product("Headphones", "P2002", 149.99, 1));
        order2.AddProduct(new Product("Phone Case", "P2003", 19.99, 2));

        // Display results
        Console.WriteLine("Order 1:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalCost()}\n");

        Console.WriteLine("Order 2:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalCost()}");
    }
}
