using System;
using Exiled.API.Features;
using player = Exiled.Events.Handlers.Player;

namespace BetterHandcuffs
{
    public class Plugin : Plugin<Config>
    {
        public static Plugin Instance;
        public override Version RequiredExiledVersion => new Version(6,0,0,0);
        public override Version Version => new Version(1, 0, 0, 0);
        public override string Author => "Miki_hero";
        
        private EventHandlers _eventHandlers;
        
        public override void OnEnabled()
        {
            Instance = this;
            RegisterEvents();
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            UnRegisterEvents();
            Instance = null;
            base.OnDisabled();
        }

        private void RegisterEvents()
        {
            _eventHandlers = new EventHandlers();
            player.Handcuffing += _eventHandlers.OnHandcuffing;
        }

        private void UnRegisterEvents()
        {
            player.Handcuffing -= _eventHandlers.OnHandcuffing;
            _eventHandlers = null;
        }
    }
}