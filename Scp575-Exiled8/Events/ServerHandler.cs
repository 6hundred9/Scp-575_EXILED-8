
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
using Exiled.Events.EventArgs.Player;
using PlayerRoles;
using System.Linq;
using System.Diagnostics.Eventing.Reader;

namespace Scp575_Exiled8.Events
{
    public class ServerHandler
    {
        private static Config config = Scp575.Instance.Config;
        private static bool scpsAlive = true;
        private static MEC.CoroutineHandle yes;
        private static bool breached = false;

        public static void OnRoundStarted()
        {
            yes = Timing.RunCoroutine(iHaveNoIdeaWhatToNameThis());
        }

        public static void OnRoundEnded(RoundEndedEventArgs ev)
        {
            Timing.KillCoroutines(yes);
        }



        public static IEnumerator<float> iHaveNoIdeaWhatToNameThis()
        {
            for (; ; )
            {
                yield return Random.Range(config.minSpawnTime, config.maxSpawnTime);
                if (Player.List.Count(x => x.IsScp) == 0) scpsAlive = false;  else scpsAlive = true;
                if (Random.Range(config.spawnChance, 101) == 100 && scpsAlive)
                {
                    Log.Info("Spawn chance met");
                    if (scpsAlive)
                    {
                        Map.TurnOffAllLights(Random.Range(config.minBlackoutTime, config.maxSpawnTime));
                        if (breached) Cassie.Message(config.breachCassie); Log.Info("Breached");
                        if (!breached) Log.Info("Breach already happened");
                        OnRoundStarted();
                        breached = true;
                        Timing.KillCoroutines(yes);
                    } else
                    {
                        if (breached)
                        {
                            Cassie.Message(config.recontainCassie);
                            Log.Info("No More SCPs are left");
                            break;
                        }
                        else Log.Info("Breach never happened");
                        
                    }
                } else
                {
                    Log.Info("Spawn chance not met");
                }
            }
        }
    }
}
