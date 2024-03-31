using Exiled.API.Features;
using Exiled;
using Exiled.Events.EventArgs.Player;
using Scp575_Exiled8.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Scp575_Exiled8
{
    public class Scp575 : Plugin<Config>
    {
        public override string Author => "6hundred9";
        public override string Name => "SCP575";

        public override string Prefix => "575";

        public override Version Version => new Version(2, 1, 0);

        public static Scp575 Instance { get; set; } = null;



        public override void OnEnabled()
        {
            Instance = this;
            Exiled.Events.Handlers.Server.RoundStarted += ServerHandler.OnRoundStarted;
            Exiled.Events.Handlers.Server.RoundEnded += ServerHandler.OnRoundEnded;
        }

        public override void OnDisabled()
        {
            Exiled.Events.Handlers.Server.RoundStarted -= ServerHandler.OnRoundStarted;
            Exiled.Events.Handlers.Server.RoundEnded -= ServerHandler.OnRoundEnded;

        }
    }
}
