using System;

namespace FactoryMethod.Vehicles
{
    class Bicycle : IVehicle
    {
        public void GetCargo()
        {
            Console.WriteLine("Pegamos a carga!");
        }

        public void StartRoute()
        {
            GetCargo();
            Console.WriteLine("Estamos a caminho para a entrega!");
        }
    }
}
