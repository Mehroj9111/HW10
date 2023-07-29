using Crm.Entities;
namespace Crm.Services;

public sealed class OrderService
{
    public Order CreateOrder(
        string orderId,
        decimal totalAmount
    )
    {

        return new()
        {
            OrderId = orderId,
            TotalAmount = totalAmount
        };
    }
}
   