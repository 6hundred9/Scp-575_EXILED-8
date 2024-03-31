using Exiled.API.Interfaces;
using Exiled.API.Features;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using UserSettings.AudioSettings;

namespace Scp575_Exiled8
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;
        public bool Debug { get; set; } = false;
        public int spawnChance { get; set; } = 100;
        public int minSpawnTime { get; set; } = 120;
        public int maxSpawnTime { get; set; } = 180;
        public int minBlackoutTime { get; set; } = 60;
        public int maxBlackoutTime { get; set; } = 90;
        [Description("The breach message used for C.A.S.S.I.E announcement")]
        public string breachCassie { get; set; } = "Attention . All personnel . SCP 5 7 5 has breached containment";
        [Description("The recontainment message used for C.A.S.S.I.E announcement")]
        public string recontainCassie { get; set; } = "SCP 5 7 5 has been recontained";
    }
}
