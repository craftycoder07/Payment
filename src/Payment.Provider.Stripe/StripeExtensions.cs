using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Payment.Core;

namespace Payment.Provider.Stripe
{
    /// <summary>
    /// Contains extension methods to configure Stripe payment-related services in the service collection.
    /// </summary>
    public static class StripeExtensions
    {
        /// <summary>
        /// Adds Stripe payment-related services to the specified <paramref name="services"/> collection using the provided Stripe configuration.
        /// </summary>
        /// <param name="services">The service collection to which Stripe payment services will be added.</param>
        /// <param name="stripeConfigurationSection">The configuration section containing Stripe-related settings.</param>
        public static void AddStripePaymentService(this IServiceCollection services, IConfiguration stripeConfigurationSection)
        {
            // Adds payment-related services using the base extension method.
            services.AddPaymentServices();

            // Adds a transient instance of IPaymentProcessorProvider using StripeProcessorProvider implementation.
            services.AddTransient<IPaymentProcessorProvider, StripeProcessorProvider>();

            // Configures StripeOptions using the provided configuration section.
            services.Configure<StripeOptions>(stripeConfigurationSection);

            // Adds a singleton instance of StripeOptions using the value resolved from IOptions<StripeOptions>.
            services.AddSingleton(resolver => resolver.GetRequiredService<IOptions<StripeOptions>>().Value);

            // Adds a transient instance of StripeProcessor.
            services.AddTransient<StripeProcessor>();
        }
    }

}