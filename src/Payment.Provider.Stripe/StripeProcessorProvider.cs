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

        /// <summary>
        /// Creates an instance of a Stripe payment processor using the provided service provider.
        /// </summary>
        /// <param name="serviceProvider">The service provider used for dependency injection.</param>
        /// <returns>An instance of <see cref="IPaymentProcessor"/> representing the created Stripe payment processor.</returns>
        public IPaymentProcessor CreatePaymentProcessor(IServiceProvider serviceProvider)
        {
            // Retrieves the required StripeProcessor instance from the service provider.
            return serviceProvider.GetRequiredService<StripeProcessor>();
        }
    }

}
