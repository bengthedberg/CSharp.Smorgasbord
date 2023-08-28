namespace CSharp.Smorgasbord.Shared;

public class Payment
{
    public string PaymentId { get; internal set; } = string.Empty;
    public decimal Amount { get; internal set; }

    public static Payment Load(string paymentId, decimal amount)
    {
        return new Payment { PaymentId = paymentId, Amount = amount};
    }

    
}