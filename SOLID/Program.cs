using System;

namespace SOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    // Single Responsibility START
    class EmployeeSR
    {
        public void CalculatePay()
        {
            //business logic here
        }
    }

    class EmployeeSRRepository
    {
        public Employee Save(Employee employee)
        {
            //persistance here

            return default;
        }
    }
    // Single Responsibility END

    // Open/Closed Principle START
    public enum PaymentType {Cash, CreditCard}
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

    class CashPayment: Payment
    {
        public override void Pay(decimal money)
        {
            // cash payment logic
            base.Pay(money);
        }

    }

    class CardPayment: Payment
    {
        public override void Pay(decimal money)
        {
            // card payment logic
            base.Pay(money);
        }

    }
    // Open/Closed Principle END

    // Liskov Substitution Principle START

    class Worker
    {
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }

        public virtual void Work()
        {
            // employee work
        }
    }

    class Employee: Worker
    {
        public override string FirstName { get; set; }
        public override string LastName { get; set; }

        public override void Work()
        {
            // employee work
        }

        public void CalculatePay()
        {
            // calculation logic
        }
    }

    class Intern : Worker
    {
        public override string FirstName { get; set; }
        public override string LastName { get; set; }

        public override void Work()
        {
            // intern work
        }
    }

    // Liskov Substitution Principle END

    // Interface Segregation Principle START

    interface IAirplane
    {
        void Fly();
    }

    interface ICar
    { 
        void Drive();
    }

    class Mercedes: ICar
    {
        public void Drive()
        {
            Console.WriteLine("driving");
        }
    }

    class Boeing: IAirplane
    {
        public void Fly()
        {
            Console.WriteLine("flying");
        }
    }

    // Interface Segregation Principle END

    // Dependency Inversion Principle START

    // WRONG
    public class Email
    {
        public string ToAddress { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
        public void SendEmail()
        {
            //Send email
        }
    }

    public class SMS
    {
        public string PhoneNumber { get; set; }
        public string Message { get; set; }
        public void SendSMS()
        {
            //Send sms
        }
    }

    public class Notification
    {
        private Email _email;
        private SMS _sms;
        public Notification()
        {
            _email = new Email();
            _sms = new SMS();
        }

        public void Send()
        {
            _email.SendEmail();
            _sms.SendSMS();
        }
    }

    // RIGHT


    // Dependency Inversion Principle END

}
