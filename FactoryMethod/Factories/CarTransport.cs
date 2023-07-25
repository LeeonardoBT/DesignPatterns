using FactoryMethod.Vehicles;

namespace FactoryMethod.Factories
{
    class CarTransport : Transport
    {
        protected override IVehicle CreateTransport()
        {
            return new Car();
        }
    }
}
