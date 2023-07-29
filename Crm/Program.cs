using Crm.Entities;
using Crm.Services;
class Program
{
    static void Main(string[] args)
    {
        try
        {
            // Создание экземпляра класса Order с обязательными свойствами
            Order order = new Order
            {
                OrderId = "12345",
                TotalAmount = 100.50m
            };

            Console.WriteLine($"Order ID: {order.OrderId}");
            Console.WriteLine($"Total Amount: {order.TotalAmount}");

            // Создание экземпляра класса Client с обязательными свойствами
            Client client = new Client
            {
                ClientId = "98765",
                Name = "John Doe"
            };

            Console.WriteLine($"Client ID: {client.ClientId}");
            Console.WriteLine($"Name: {client.Name}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}