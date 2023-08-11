using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Payment.Core;

namespace Payment.Provider.Stripe
{
    public static class StripeExtensions
    {
        public static void AddStripePaymentService(this IServiceCollection services, IConfiguration stripeConfigurationSection)
        {
            services.AddPaymentServices();
            services.AddTransient<IPaymentProcessorProvider, StripeProcessorProvider>();
            services.Configure<StripeOptions>(stripeConfigurationSection);
            services.AddSingleton(resolver => resolver.GetRequiredService<IOptions<StripeOptions>>().Value);
            services.AddTransient<StripeProcessor>();
        }
    }
}