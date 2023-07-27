using Adapter.PayPalFolder;
using Adapter.TokenFolder;
using System;

namespace Adapter.MercadoPagoFolder
{
    class MercadoPagoAdapter : IPayPalPayment
    {
        private MercadoPago mercadoPago;

        public MercadoPagoAdapter(MercadoPago mercadoPago)
        {
            this.mercadoPago = mercadoPago;
            Console.WriteLine("Realizando adaptação de MercadoPago para PayPal!");
        }

        public Token AuthToken()
        {
            return this.mercadoPago.AuthToken();
        }

        public void PayPalPayment()
        {
            this.mercadoPago.MPagoPayment();
        }

        public void PayPalReceive()
        {
            this.mercadoPago.MPagoReceivement();
        }
    }
}
