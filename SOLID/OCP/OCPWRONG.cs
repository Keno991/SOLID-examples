using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.OCP.WRONG
{
    public enum PaymentType { Cash, CreditCard }
    class PaymentManager
    {
        public PaymentType paymentType { get; set; }

        public void Pay(decimal money)
        {
            if(paymentType == PaymentType.Cash)
            {
                // do something
            }
            else if (paymentType == PaymentType.CreditCard)
            {
                // do something else
            }
        }
    }
}
