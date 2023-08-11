using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Payment.Core;

namespace Payment.Provider.Stripe
{
    internal class StripeProcessor : IPaymentProcessor
    {
        private readonly StripeOptions _stripeOptions;

        public StripeProcessor(StripeOptions stripeOptions) 
        {
            _stripeOptions = stripeOptions;
        }

        public void Charge()
        {
            Console.WriteLine(_stripeOptions.BaseURL);
        }
    }
}
