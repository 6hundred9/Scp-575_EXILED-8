
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
        private static int funny = Scp575.editable;
        public static void OnRoundStarted()
        {
            _ = Timing.RunCoroutine(iHaveNoIdeaWhatToNameThis());
        }

        public static void OnRoundEnded()
        {
            _ = Timing.KillCoroutines();
            
            funny = config.timesPerRound;
        }

        public static IEnumerator<float> iHaveNoIdeaWhatToNameThis()
        {
            for (; ; )
            {
                if (funny <= 0) { 
                    
                    break; }
                Random rnd = new Random();

                yield return rnd.Next(config.minSpawnTime, config.maxSpawnTime);

                if (rnd.Next(config.spawnChance, 101) == 100)
                {
                    Map.TurnOffAllLights(rnd.Next(config.minBlackoutTime, config.maxBlackoutTime));
                    funny--;
                }
            }
        }
    }
}
