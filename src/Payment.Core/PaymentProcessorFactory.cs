using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment.Core
{
    public sealed class PaymentProcessorFactory : IPaymentProcessorFactory
    {
        private readonly IEnumerable<IPaymentProcessorProvider> _paymentProcessorProviders;
        private readonly IServiceProvider _serviceProvider;

        public PaymentProcessorFactory(IServiceProvider serviceProvider, IEnumerable<IPaymentProcessorProvider> paymentProcessorProviders)
        {
            _serviceProvider = serviceProvider;
            _paymentProcessorProviders = paymentProcessorProviders;
        }

        public IPaymentProcessor Create(PaymentProcessingProvider paymentProcessingProvider)
        {
            return _paymentProcessorProviders.First(x => x.paymentProcessingProvider == paymentProcessingProvider).CreatePaymentProcessor(_serviceProvider);
        }
    }
}
