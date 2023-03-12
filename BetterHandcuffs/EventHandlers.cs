using Exiled.Events.EventArgs.Player;
using Exiled.Permissions.Extensions;
using PlayerRoles;

namespace BetterHandcuffs
{
    public class EventHandlers
    {
        private readonly Config _cfg = Plugin.Instance.Config;
        public void OnHandcuffing(HandcuffingEventArgs ev)
        {
            if (ev.Player.CheckPermission("bh.immunity"))
            {
                ev.IsAllowed = false;
            }
            
            if (ev.Target.Role.Type == RoleTypeId.Tutorial && _cfg.IgnoreTutorials)
            {
                ev.IsAllowed = false;
            }

            if (ev.Player.IsGodModeEnabled && _cfg.IgnoreGodMode)
            {
                ev.IsAllowed = false;
            }
        }
    }
}