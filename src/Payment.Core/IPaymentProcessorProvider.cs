using Payment.Core;

/// <summary>
/// Represents a provider for creating instances of payment processors.
/// </summary>
public interface IPaymentProcessorProvider
{
    /// <summary>
    /// Gets or sets the payment processing provider associated with this processor provider.
    /// </summary>
    PaymentProcessingProvider PaymentProcessingProvider { get; set; }

    /// <summary>
    /// Creates an instance of a payment processor using the provided service provider.
    /// </summary>
    /// <returns>An instance of <see cref="IPaymentProcessor"/> representing the created payment processor.</returns>
    IPaymentProcessor CreatePaymentProcessor();
}
