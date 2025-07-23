public interface IPaymentMethod
{
    void Pay();
}

public class CreditCardPayment : IPaymentMethod
{
    public void Pay()
    {
        Console.WriteLine("Paid with Credit Card");
    }
}

public class PayPalPayment : IPaymentMethod
{
    public void Pay()
    {
        Console.WriteLine("Paid with PayPal");
    }
}

public class PaymentProcessor
{
    private readonly IPaymentMethod _paymentMethod;

    public PaymentProcessor(IPaymentMethod paymentMethod)//di
    {
        _paymentMethod = paymentMethod;
    }

    public void Payment()
    {
        _paymentMethod.Pay();
    }
}



namespace OpenClose
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Open/Close Principle!");

            IPaymentMethod paymentMethod = new CreditCardPayment();
            PaymentProcessor paymentProcessor = new PaymentProcessor(paymentMethod);
            paymentProcessor.Payment();

            paymentMethod = new PayPalPayment();
            paymentProcessor = new PaymentProcessor(paymentMethod);
            paymentProcessor.Payment();

            Console.ReadKey();
        }
    }
}