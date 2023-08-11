using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment.Core
{
    public interface IPaymentProcessorProvider
    {
        public PaymentProcessingProvider paymentProcessingProvider { get; set; }
        public IPaymentProcessor CreatePaymentProcessor(IServiceProvider serviceProvider);
    }
}
