using CSharp.Smorgasbord.Shared;

namespace CSharp.Smorgasbord.ExceptionHandling;

public class PaymentApi
{
    public IEnumerable<Payment> GetPayments()
    {
        try
        {
            // Get user credentials
            // Access the external api
            throw new Exception("Payment connection failed, bla bla very detailed error.");
            // return payments;
        }
        catch (Exception ex)
        {
            // Log the exception
            
            // Instead of this call:
            // throw new Exception("Could not get payments", ex);
            // use this call:
            throw new PaymentApiException("Could not get payments", ex);

        }

        return new List<Payment>();
    }


}