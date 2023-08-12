using Payment.Core;

namespace Payment.Provider.Stripe
{
    /// <summary>
    /// Represents a payment processor for handling Stripe payments.
    /// </summary>
    internal class StripeProcessor : IPaymentProcessor
    {
        private readonly StripeOptions _stripeOptions;

        /// <summary>
        /// Initializes a new instance of the <see cref="StripeProcessor"/> class with the specified Stripe options.
        /// </summary>
        /// <param name="stripeOptions">The Stripe options used for configuration.</param>
        public StripeProcessor(StripeOptions stripeOptions)
        {
            _stripeOptions = stripeOptions;
        }

        /// <summary>
        /// Charges the payment using the configured Stripe options.
        /// </summary>
        public void Charge()
        {
            // Outputs the base URL from the Stripe options.
            Console.WriteLine(_stripeOptions.BaseURL);
        }
    }

}
