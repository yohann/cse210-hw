using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "Springfield", "IL", "USA");
        Customer customer1 = new Customer("John Smith", address1);

        Address address2 = new Address("456 Maple Ave", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Sarah Johnson", address2);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "LPT001", 899.99m, 1));
        order1.AddProduct(new Product("Wireless Mouse", "MSE004", 25.50m, 2));
        order1.AddProduct(new Product("USB Cable", "CBL010", 12.99m, 3));

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Gaming Keyboard", "KBD007", 149.99m, 1));
        order2.AddProduct(new Product("Monitor Stand", "STD002", 89.95m, 1));

        Console.WriteLine("ORDER 1");
        Console.WriteLine("========");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.CalculateTotal():F2}");
        Console.WriteLine();

        Console.WriteLine("ORDER 2");
        Console.WriteLine("========");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.CalculateTotal():F2}");
    }
}
