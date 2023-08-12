using Microsoft.Extensions.DependencyInjection;

namespace Payment.Core
{
    /// <summary>
    /// Contains extension methods to configure payment-related services in the service collection.
    /// </summary>
    public static class PaymentExtensions
    {
        /// <summary>
        /// Adds payment-related services to the specified <paramref name="services"/> collection.
        /// </summary>
        /// <param name="services">The service collection to which payment services will be added.</param>
        public static void AddPaymentServices(this IServiceCollection services)
        {
            // Adds a singleton instance of IPaymentProcessorFactory, using the PaymentProcessorFactory implementation.
            services.AddSingleton<IPaymentProcessorFactory, PaymentProcessorFactory>();
        }
    }
}
