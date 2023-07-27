using Adapter.TokenFolder;
using System;

namespace Adapter.MercadoPagoFolder
{
    class MercadoPago : IMercadoPagoPayment
    {
        private Token token;

        public Token AuthToken()
        {
            return new Token();
        }

        public void MPagoPayment()
        {
            token = AuthToken();
            Console.WriteLine("Enviando pagamento com o MercadoPago!");
        }

        public void MPagoReceivement()
        {
            token = AuthToken();
            Console.WriteLine("Recebendo pagamento com o MercadoPago!");
        }
    }
}
