using Adapter.TokenFolder;
using System;

namespace Adapter.PayonnerFolder
{
    class Payonner : IPayonnerPayment
    {
        private Token token;

        public Token AuthToken()
        {
            return new Token();
        }

        public void ReceivePayment()
        {
            token = AuthToken();
            Console.WriteLine("Recebendo pagamento com o Payonner!");
        }

        public void SendPayment()
        {
            token = AuthToken();
            Console.WriteLine("Enviando pagamento com o Payonner!");
        }
    }
}
