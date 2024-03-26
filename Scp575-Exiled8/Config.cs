using Exiled.API.Interfaces;
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
        public int spawnChance { get; set; } = 0;
        public int minSpawnTime { get; set; } = 0;
        public int maxSpawnTime { get; set; } = 0;
        public int minBlackoutTime { get; set; } = 0;
        public int maxBlackoutTime { get; set; } = 0;
        public int timesPerRound { get; set; } = 0;
    }
}
