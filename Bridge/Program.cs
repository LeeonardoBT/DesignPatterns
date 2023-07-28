using Bridge.Platforms;
using Bridge.Transmissions;
using System;

namespace Bridge
{
    class Program
    {
        static void StartLive(IPlatform platform)
        {
            Console.WriteLine("Aguarde...");

            Live live = new Live(platform);

            live.Broadcasting();
            live.Result();
        }

        static void StartAdvancedLive(IPlatform platform)
        {
            Console.WriteLine("Aguarde...");

            AdvancedLive live = new AdvancedLive(platform);

            live.Broadcasting();
            live.Subtitle();
            live.Comments();
            live.Record();
            live.Result();
        }

        static void Main(string[] args)
        {
            StartAdvancedLive(new YouTube());
            StartLive(new Facebook());
            StartLive(new TwitchTV());
            StartAdvancedLive(new DLive());

            Console.ReadLine();
        }
    }
}
