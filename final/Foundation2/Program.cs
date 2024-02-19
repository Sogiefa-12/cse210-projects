using System;

class Program
{
    static void Main()
{
        Address address1 = new Address("123 Main St", "City", "State", "USA");
        Address address2 = new Address("456 Oak Ave", "Town", "Province", "Canada");

        Customer customer1 = new Customer("Sarah Ogiefa", address1);
        Customer customer2 = new Customer("Jane Larry", address2);

        List<Product> products = new List<Product>
        {
            new Product("Product 1", "P1", 3.0, 2),
            new Product("Product 2", "P2", 5.0, 1),
            new Product("Product 3", "P3", 7.0, 3),
        };

        Order order1 = new Order(customer1, products);
        Order order2 = new Order(customer2, products);

        Console.WriteLine($"Order 1 Packing Label:");
        foreach (var product in order1.products)
        {
            Console.WriteLine($"{product.name} - {product.id}");
        }

        Console.WriteLine($"Order 1 Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());

        Console.WriteLine($"Order 1 Total Price: ${order1.GetTotalPrice()}");

        Console.WriteLine($"Order 2 Packing Label:");
        foreach (var product in order2.products)
        {
            Console.WriteLine($"{product.name} - {product.id}");
        }

        Console.WriteLine($"Order 2 Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());

        Console.WriteLine($"Order 2 Total Price: ${order2.GetTotalPrice()}");
    }
}