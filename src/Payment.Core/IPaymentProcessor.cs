namespace Payment.Core
{
    /// <summary>
    /// Represents a type used to payment transation
    /// </summary>
    public interface IPaymentProcessor
    {
        /// <summary>
        /// Charges Credit Card.
        /// </summary>
        /// <returns>An instance of <see cref="string"/> representing transaction identifier.</returns>
        public string Charge();
    }
}
