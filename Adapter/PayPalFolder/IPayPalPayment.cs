using Adapter.TokenFolder;

namespace Adapter.PayPalFolder
{
    interface IPayPalPayment
    {
        Token AuthToken();
        void PayPalPayment();
        void PayPalReceive();
    }
}
