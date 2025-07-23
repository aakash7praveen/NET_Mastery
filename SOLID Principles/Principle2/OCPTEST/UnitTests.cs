using Xunit; 
using Moq;
using FluentAssertions; 
using System;
using System.IO; 

namespace OpenClose.Tests
{
    public class PaymentProcessorTests
    {
        [Fact]
        public void CreditCardPayment_Pay_PrintsCorrectMessage()
        {
            var creditCardPayment = new CreditCardPayment();
            using var consoleOutput = new StringWriter(); 
            Console.SetOut(consoleOutput); 

            creditCardPayment.Pay();

            consoleOutput.ToString().Trim().Should().Be("Paid with Credit Card");

            var originalOutput = new StreamWriter(Console.OpenStandardOutput());
            originalOutput.AutoFlush = true;
            Console.SetOut(originalOutput);
        }

        [Fact]
        public void PayPalPayment_Pay_PrintsCorrectMessage()
        {
            var payPalPayment = new PayPalPayment();
            using var consoleOutput = new StringWriter(); 
            Console.SetOut(consoleOutput); 

            payPalPayment.Pay();

            consoleOutput.ToString().Trim().Should().Be("Paid with PayPal");

            var originalOutput = new StreamWriter(Console.OpenStandardOutput());
            originalOutput.AutoFlush = true;
            Console.SetOut(originalOutput);
        }

        [Fact]
        public void PaymentProcessor_Payment_DelegatesToInjectedMethod()
        {
            var mockPaymentMethod = new Mock<IPaymentMethod>();

            var paymentProcessor = new PaymentProcessor(mockPaymentMethod.Object);

            paymentProcessor.Payment();

            mockPaymentMethod.Verify(m => m.Pay(), Times.Once);
        }

        [Fact]
        public void PaymentProcessor_Constructor_WithNullPaymentMethod_ThrowsNullReferenceExceptionOnPayment()
        {
            var paymentProcessor = new PaymentProcessor(null);

            Action act = () => paymentProcessor.Payment();
            act.Should().Throw<NullReferenceException>();
        }
    }
}