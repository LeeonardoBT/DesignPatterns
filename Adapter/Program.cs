using Adapter.MercadoPagoFolder;
using Adapter.PayonnerFolder;
using Adapter.PayPalFolder;
using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var paymentMethod = PaymentMethod.MERCADOPAGO;

            //PayPal payment = new PayPal();
            //Payonner payment = new Payonner();
            //MercadoPago payment = new MercadoPago();

            //IPayPalPayment payment = new PayonnerAdapter(new Payonner());
            //IPayPalPayment payment = new MercadoPagoAdapter(new MercadoPago());

            IPayPalPayment payment = null;

            switch (paymentMethod)
            {
                case PaymentMethod.PAYPAL:
                    payment = new PayPal();
                    break;
                case PaymentMethod.PAYONNER:
                    payment = new PayonnerAdapter(new Payonner());
                    break;
                case PaymentMethod.MERCADOPAGO:
                    payment = new MercadoPagoAdapter(new MercadoPago());
                    break;
            }

            payment.PayPalPayment();
            payment.PayPalReceive();

            //PAYONNER
            //payment.SendPayment();
            //payment.ReceivePayment();

            //MERCADOPAGO
            //payment.MPagoPayment();
            //payment.MPagoReceivement();

            Console.ReadLine();
        }
    }
}
