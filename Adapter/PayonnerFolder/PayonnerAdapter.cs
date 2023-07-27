using Adapter.PayPalFolder;
using Adapter.TokenFolder;
using System;

namespace Adapter.PayonnerFolder
{
    class PayonnerAdapter : IPayPalPayment
    {
        private Payonner payonner;

        public PayonnerAdapter(Payonner payonner)
        {
            this.payonner = payonner;
            Console.WriteLine("Realizando adaptação de Payonner para PayPal!");
        }

        public Token AuthToken()
        {
            return this.payonner.AuthToken();
        }

        public void PayPalPayment()
        {
            this.payonner.SendPayment();
        }

        public void PayPalReceive()
        {
            this.payonner.ReceivePayment();
        }
    }
}
