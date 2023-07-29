namespace Crm.Entities;

public class Order
{
    private string orderId;
    private decimal totalAmount;

    public string OrderId
    {
        get { return orderId; }
        init
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Order ID cannot be null or empty.");
            
            orderId = value;
        }
    }

    public decimal TotalAmount
    {
        get { return totalAmount; }
        init
        {
            if (value <= 0)
                throw new ArgumentOutOfRangeException("Total amount must be greater than zero.");

            totalAmount = value;
        }
    }
}