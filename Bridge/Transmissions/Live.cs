using Bridge.Platforms;
using System;

namespace Bridge.Transmissions
{
    class Live : ITransmissions
    {
        protected IPlatform platform;

        public Live(IPlatform platform)
        {
            this.platform = platform;
        }

        public void Broadcasting()
        {
            Console.WriteLine($"Iniciando a transmissão na {platform}.");
        }

        public void Result()
        {
            Console.WriteLine("**** ON AIR ****");
            Console.WriteLine("-----------------------------------------------------");
        }
    }
}
