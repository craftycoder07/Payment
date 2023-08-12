namespace Payment.Core
{
    /// <summary>
    /// Represents a factory for creating instances of payment processors.
    /// </summary>
    public interface IPaymentProcessorFactory
    {
        /// <summary>
        /// Creates an instance of a payment processor based on the provided payment processing provider.
        /// </summary>
        /// <param name="paymentProcessingProvider">The payment processing provider to use for creating the payment processor.</param>
        /// <returns>An instance of <see cref="IPaymentProcessor"/> representing the created payment processor.</returns>
        public IPaymentProcessor Create(PaymentProcessingProvider paymentProcessingProvider);
    }
}
