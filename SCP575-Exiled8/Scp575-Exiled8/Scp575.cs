using Exiled.API.Features;
using Exiled.Events.EventArgs.Player;
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
        public static Scp575 Instance { get; private set; } = null;
        public override void OnEnabled()
        {
            //Exiled.Events.Handlers.Player.ChangingRole += PlayerHandler.OnChangingRole;
            //Exiled.Events.Handlers.Player.Spawned += PlayerHandler.Spawned;
        }

        // This method will be called when your plugin is disabled
        public override void OnDisabled()
        {
            //Exiled.Events.Handlers.Player.ChangingRole -= PlayerHandler.OnChangingRole;
            //Exiled.Events.Handlers.Player.Spawned -= PlayerHandler.Spawned;
        }
    }
}
