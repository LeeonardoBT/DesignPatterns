using AbstractFactory.Aircrafts;
using AbstractFactory.Factories;
using AbstractFactory.LandVehicles;

namespace AbstractFactory.App
{
    class Application
    {
        private IAircraft aircraft;
        private ILandVehicle vehicle;

        public Application(ITransportFactory factory)
        {
            aircraft = factory.CreateTransportAircraft();
            vehicle = factory.CreateTransportVehicle();
        }

        public void StartRoute()
        {
            vehicle.StartRoute();
            aircraft.StartRoute();
        }
    }
}
