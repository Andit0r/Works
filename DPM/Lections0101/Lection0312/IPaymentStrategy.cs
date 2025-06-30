using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lection0312
{
    public interface IPaymentStrategy
    {
        void Pay(int cost);
    }
}