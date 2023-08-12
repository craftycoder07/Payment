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
        public void Charge();
    }
}
