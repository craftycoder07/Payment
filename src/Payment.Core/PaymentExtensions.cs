using Microsoft.Extensions.DependencyInjection;

namespace Payment.Core
{
    public static class PaymentExtensions
    {
        public static void AddPaymentServices(this IServiceCollection services)
        {
            services.AddSingleton<IPaymentProcessorFactory, PaymentProcessorFactory>();
        }
    }
}
