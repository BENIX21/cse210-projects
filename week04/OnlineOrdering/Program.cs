using System;

class Program
{
    static void Main(string[] args)
    {
        // Order 1 (Cliente en USA -> envío $5)
        Address address1 = new Address("123 Main St", "Rexburg", "ID", "USA");
        Customer customer1 = new Customer("John Smith", address1);
        Order order1 = new Order(customer1);

        order1.AddProduct(new Product("Wireless Mouse", "WM-101", 25.50, 2));
        order1.AddProduct(new Product("Mechanical Keyboard", "MK-202", 75.00, 1));

        // Order 2 (Cliente fuera de USA -> envío $35)
        Address address2 = new Address("Av. Colón 450", "Córdoba", "Córdoba", "Argentina");
        Customer customer2 = new Customer("Lucía Gómez", address2);
        Order order2 = new Order(customer2);

        order2.AddProduct(new Product("USB-C Hub", "UH-303", 30.00, 1));
        order2.AddProduct(new Product("Laptop Stand", "LS-404", 40.00, 2));
        order2.AddProduct(new Product("Webcam HD", "WC-505", 55.00, 1));

        // Display Order 1
        Console.WriteLine("====================================");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine();
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"\nTotal Price: ${order1.CalculateTotalCost():F2}");
        Console.WriteLine("====================================\n");

        // Display Order 2
        Console.WriteLine("====================================");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine();
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"\nTotal Price: ${order2.CalculateTotalCost():F2}");
        Console.WriteLine("====================================");
    }
}