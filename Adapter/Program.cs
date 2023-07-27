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
            //PayPal payment = new PayPal();
            //Payonner payment = new Payonner();
            //MercadoPago payment = new MercadoPago();

            //IPayPalPayment payment = new PayonnerAdapter(new Payonner());
            IPayPalPayment payment = new MercadoPagoAdapter(new MercadoPago());

            payment.PayPalPayment();
            payment.PayPalReceive();

            //payment.SendPayment();
            //payment.ReceivePayment();

            //payment.MPagoPayment();
            //payment.MPagoReceivement();

            Console.ReadLine();
        }
    }
}
