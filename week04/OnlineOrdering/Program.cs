using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("ONLINE ORDERING SYSTEM\n");


        Address addr1 = new Address("123 Temple St", "Salt Lake City", "UT", "USA");
        Customer cust1 = new Customer("Emily Johnson", addr1);
        Order order1 = new Order(cust1);

        order1.AddProduct(new Product("Scripture Case", "A101", 12.50, 2));
        order1.AddProduct(new Product("CTR Ring", "B204", 9.99, 1));

        Address addr2 = new Address("Av. Santa Fe 1450", "Buenos Aires", "CABA", "Argentina");
        Customer cust2 = new Customer("Ornella Meregone Ango", addr2);
        Order order2 = new Order(cust2);

        order2.AddProduct(new Product("Temple Artwork Print", "T501", 25.00, 1));
        order2.AddProduct(new Product("Journal Notebook", "J002", 7.80, 3));
        order2.AddProduct(new Product("Sticker Pack", "S777", 4.00, 2));

        Console.WriteLine("ORDER 1:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalPrice()}\n");
        Console.WriteLine("-----------------------------\n");

        Console.WriteLine("ORDER 2:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.GetTotalPrice()}\n");
    }
}
