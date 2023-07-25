using AbstractFactory.Aircrafts;
using AbstractFactory.LandVehicles;

namespace AbstractFactory.Factories
{
    interface ITransportFactory
    {
        IAircraft CreateTransportAircraft();
        ILandVehicle CreateTransportVehicle();
    }
}
