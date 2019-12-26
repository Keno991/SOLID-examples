using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.OCP.RIGHT
{
    public enum PaymentType { Cash, CreditCard }
    class PaymentManager
    {
        public PaymentType paymentType { get; set; }

        public void Pay(decimal money)
        {
            Payment payment = default;

            switch (paymentType)
            {
                case PaymentType.Cash:
                    payment = new CashPayment();
                    break;
                case PaymentType.CreditCard:
                    payment = new CardPayment();
                    break;
                default:
                    payment = new Payment();
                    break;
            }
            payment.Pay(10.35m);
        }
    }

    class Payment
    {
        public virtual void Pay(decimal money)
        {
            // base (shared) logic - if any
        }
    }

    class CashPayment : Payment
    {
        public override void Pay(decimal money)
        {
            // cash payment logic
            base.Pay(money);
        }

    }

    class CardPayment : Payment
    {
        public override void Pay(decimal money)
        {
            // card payment logic
            base.Pay(money);
        }

    }
}
