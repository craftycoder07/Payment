namespace Payment.Core
{
    /// <summary>
    /// Supported payment processing providers.
    /// </summary>
    public enum PaymentProcessingProvider : byte
    {
        /// <summary>
        /// Represents the Stripe payment processing provider.
        /// </summary>
        Stripe = 1
    }
}
