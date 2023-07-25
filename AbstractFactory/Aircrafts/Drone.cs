using System;

namespace AbstractFactory.Aircrafts
{
    class Drone : IAircraft
    {
        public void CheckWind()
        {
            Console.WriteLine("Verificando ventos, ventos a 5km, ventos ok!");
        }

        public void GetCargo()
        {
            Console.WriteLine("Estamos com a encomanda!");
        }

        public void StartRoute()
        {
            CheckWind();
            GetCargo();
            Console.WriteLine("Estamos a caminho do destino!");
        }
    }
}
