using Adapter.TokenFolder;

namespace Adapter.MercadoPagoFolder
{
    interface IMercadoPagoPayment
    {
        Token AuthToken();
        void MPagoPayment();
        void MPagoReceivement();
    }
}
