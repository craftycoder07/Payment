namespace Payment.Provider.Stripe
{
    /// <summary>
    /// Represents options related to Stripe configuration.
    /// </summary>
    internal class StripeOptions
    {
        /// <summary>
        /// Gets or sets the base URL for Stripe configuration.
        /// </summary>
        public required string BaseURL { get; set; }
    }

}
