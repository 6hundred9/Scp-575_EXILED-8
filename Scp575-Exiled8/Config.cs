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
        public int spawnChance = 0;
        public int minSpawnTime = 0;
        public int maxSpawnTime = 0;
        public int minBlackoutTime = 0;
        public int maxBlackoutTime = 0;
        public int timesPerRound = 0;
    }
}
