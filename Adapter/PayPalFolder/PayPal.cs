using Adapter.TokenFolder;
using System;

namespace Adapter.PayPalFolder
{
    class PayPal : IPayPalPayment
    {
        private Token token;

        public Token AuthToken()
        {
            return new Token();
        }

        public void PayPalPayment()
        {
            token = AuthToken();
            Console.WriteLine("Enviando pagamentos com o PayPal!");
        }

        public void PayPalReceive()
        {
            token = AuthToken();
            Console.WriteLine("Recebendo pagamentos com o PayPal!");
        }
    }
}
