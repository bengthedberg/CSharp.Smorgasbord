namespace CSharp.Smorgasbord.ExceptionHandling;

public class PaymentApiException : Exception
{
    public PaymentApiException(string message, Exception innerException) : base(message, innerException)
    {
    }
}