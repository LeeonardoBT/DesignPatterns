using Adapter.TokenFolder;

namespace Adapter.PayonnerFolder
{
    interface IPayonnerPayment
    {
        Token AuthToken();
        void SendPayment();
        void ReceivePayment();

    }
}
