﻿using System.ComponentModel;
using Exiled.API.Interfaces;

namespace BetterHandcuffs
{
    public class Config : IConfig
    {
        [Description("Enables or disables the plugin.")]
        public bool IsEnabled { get; set; } = true;

        [Description("Whether or not debug messages should be shown in the console.")]
        public bool Debug { get; set; } = false;

        [Description("Should tutorials be immune to handcuffing? Default: true")]
        public bool IgnoreTutorials { get; set; } = true;
        
        [Description("Should players with GodMode enabled be immune to handcuffing? Default: true")]
        public bool IgnoreGodMode { get; set; } = true;

        [Description("Should the plugin not check if the cuffed player has the perms to ignore cuffing.")]
        public bool DontCheckForPerms { get; set; } = false;
    }
}