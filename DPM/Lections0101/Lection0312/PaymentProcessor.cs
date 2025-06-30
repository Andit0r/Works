namespace Lection0312
{
    public class PaymentProcessor
    {
        private readonly IPaymentStrategy _strategy;

        public PaymentProcessor(IPaymentStrategy strategy)
            => _strategy = strategy;
        public void ProcessPayment(int cost)
            => _strategy?.Pay(cost); //вызов алгоритма

    }
}