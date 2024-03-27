
using Exiled.API.Features;
using PluginAPI.Events;
using System;
using System.Collections;
using System.Threading;
using MEC;
using System.Collections.Generic;
using Exiled.Events.EventArgs.Server;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Scp575_Exiled8.Events
{
    public class ServerHandler
    {
        private static Config config = Scp575.Instance.Config;
        private static int funny = Scp575.editable;
        private static MEC.CoroutineHandle yes;
        public static void OnRoundStarted()
        {
            yes = Timing.RunCoroutine(iHaveNoIdeaWhatToNameThis());
        }

        public static void OnRoundEnded(RoundEndedEventArgs ev)
        {
            Timing.KillCoroutines(yes);
            funny = config.timesPerRound;
        }

        public static IEnumerator<float> iHaveNoIdeaWhatToNameThis()
        {
            for (; ; )
            {
                if (funny <= 0) break;
                

                yield return Random.Range(config.minSpawnTime, config.maxSpawnTime);
                

                if (Random.Range(config.spawnChance, 101) == 100)
                {
                    Map.TurnOffAllLights(Random.Range(config.minBlackoutTime, config.maxSpawnTime));
                    Cassie.Message("Attention . All personnel . SCP 5 7 5 has breached containment");
                    funny--;
                }
            }
        }
    }
}
