using Microsoft.Extensions.DependencyInjection;
using Payment.Core;

namespace Payment.Provider.Stripe
{
    /// <summary>
    /// Represents a provider for creating Stripe payment processors.
    /// </summary>
    public class StripeProcessorProvider : IPaymentProcessorProvider
    {
        /// <summary>
        /// Gets or sets the payment processing provider as Stripe.
        /// </summary>
        public PaymentProcessingProvider PaymentProcessingProvider { get; set; } = PaymentProcessingProvider.Stripe;

        private readonly IServiceProvider _serviceProvider;

        /// <summary>
        /// Initializes a new instance of the <see cref="StripeProcessorProvider"/> class.
        /// </summary>
        /// <param name="serviceProvider">The service provider used for dependency injection.</param>
        public StripeProcessorProvider(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        /// <summary>
        /// Creates an instance of a Stripe payment processor using the provided service provider.
        /// </summary>
        /// <returns>An instance of <see cref="IPaymentProcessor"/> representing the created Stripe payment processor.</returns>
        public IPaymentProcessor CreatePaymentProcessor()
        {
            // Retrieves the required StripeProcessor instance from the service provider.
            return _serviceProvider.GetRequiredService<StripeProcessor>();
        }
    }

}
