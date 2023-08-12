namespace Payment.Core
{
    /// <summary>
    /// Represents a factory for creating payment processors based on different payment processor providers.
    /// </summary>
    public sealed class PaymentProcessorFactory : IPaymentProcessorFactory
    {
        private readonly IEnumerable<IPaymentProcessorProvider> _paymentProcessorProviders;
        private readonly IServiceProvider _serviceProvider;

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentProcessorFactory"/> class.
        /// </summary>
        /// <param name="serviceProvider">The service provider used for dependency injection.</param>
        /// <param name="paymentProcessorProviders">A collection of payment processor providers.</param>
        public PaymentProcessorFactory(IServiceProvider serviceProvider, IEnumerable<IPaymentProcessorProvider> paymentProcessorProviders)
        {
            _serviceProvider = serviceProvider;
            _paymentProcessorProviders = paymentProcessorProviders;
        }

        /// <summary>
        /// Creates an instance of a payment processor based on the specified payment processing provider.
        /// </summary>
        /// <param name="paymentProcessingProvider">The payment processing provider to use for creating the payment processor.</param>
        /// <returns>An instance of <see cref="IPaymentProcessor"/> representing the created payment processor.</returns>
        public IPaymentProcessor Create(PaymentProcessingProvider paymentProcessingProvider)
        {
            return _paymentProcessorProviders.First(x => x.PaymentProcessingProvider == paymentProcessingProvider)
                                              .CreatePaymentProcessor(_serviceProvider);
        }
    }
}
