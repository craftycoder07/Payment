using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Payment.Core;

namespace Payment.Provider.Stripe
{
    public class StripeProcessorProvider : IPaymentProcessorProvider
    {
        public PaymentProcessingProvider paymentProcessingProvider { get; set; } = PaymentProcessingProvider.Stripe;

        public IPaymentProcessor CreatePaymentProcessor(IServiceProvider serviceProvider)
        {
            return serviceProvider.GetRequiredService<StripeProcessor>();
        }
    }
}
