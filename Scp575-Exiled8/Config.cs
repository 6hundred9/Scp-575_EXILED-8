using Exiled.API.Interfaces;
using Exiled.API.Features;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scp575_Exiled8
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;
        public bool Debug { get; set; } = false;
        public int spawnChance { get; set; } = 100;
        public int minSpawnTime { get; set; } = 120;
        public int maxSpawnTime { get; set; } = 180;
        public int minBlackoutTime { get; set; } = 260;
        public int maxBlackoutTime { get; set; } = 300;
        public int timesPerRound { get; set; } = 1;
        public string breachCassie { get; set; } = "Attention . All personnel . SCP 5 7 5 has breached containment";
        public string recontainCassie { get; set; } = "SCP 5 7 5 has been recontained";
    }
}
