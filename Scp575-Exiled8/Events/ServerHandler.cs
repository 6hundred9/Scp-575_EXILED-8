
using Exiled.API.Features;
using PluginAPI.Events;
using System;
using System.Collections;
using System.Threading;
using MEC;
using System.Collections.Generic;

namespace Scp575_Exiled8.Events
{
    public class ServerHandler
    {
        private static Config config = Scp575.Instance.Config;

        public static void OnRoundStarted()
        {
            _ = Timing.RunCoroutine(iHaveNoIdeaWhatToNameThis());
        }

        public static IEnumerator<float> iHaveNoIdeaWhatToNameThis()
        {
            for (; ; )
            {
                if (config.timesPerRound <= 0) { break; }
                Random rnd = new Random();

                Thread.Sleep(rnd.Next(config.minSpawnTime, config.maxSpawnTime));
                if (rnd.Next(config.spawnChance, 101) == 100)
                {
                    Map.TurnOffAllLights(rnd.Next(config.minBlackoutTime, config.maxBlackoutTime));
                    config.timesPerRound--;
                }
                yield return 0.0f;
            }
        }
    }
}
