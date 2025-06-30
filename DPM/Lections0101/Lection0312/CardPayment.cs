using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;

namespace Lection0312
{
    public class CardPayment : IPaymentStrategy
    {
        public void Pay(int cost) 
            => Console.WriteLine("Pay by card");
    }

    public class CreditPayment : IPaymentStrategy
    {
        public void Pay(int cost)
            => Console.WriteLine("Pay by credit");
    }
}