using System;

namespace AbstractFactory.LandVehicles
{
    class Scooter : ILandVehicle
    {
        public void GetCargo()
        {
            Console.WriteLine("Pegamos a encomenda, estamos pronto para partir!");
        }

        public void StartRoute()
        {
            GetCargo();
            Console.WriteLine("Iniciando a entrega!");
        }
    }
}
