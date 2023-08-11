using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment.Core
{
    public interface IPaymentProcessorFactory
    {
        public IPaymentProcessor Create(PaymentProcessingProvider paymentProcessingProvider);
    }
}
