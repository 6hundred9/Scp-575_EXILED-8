
using Exiled.API.Features;
using PluginAPI.Events;
using System;
using System.Threading;

namespace Scp575_Exiled8.Events
{
    public class ServerHandler
    {
        private static Config config = Scp575.Instance.Config;

        public static int OnRoundStarted()
        {
            while (true)
            {
                if (config.timesPerRound <= 0) { return 1; }
                Random rnd = new Random();

                Thread.Sleep(rnd.Next(config.minSpawnTime, config.maxSpawnTime));
                if (rnd.Next(config.spawnChance, 101) == 100)
                {
                    Map.TurnOffAllLights(rnd.Next(config.minBlackoutTime, config.maxBlackoutTime));
                    config.timesPerRound--;
                }
            }
        }
    }
}
