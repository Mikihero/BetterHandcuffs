# BetterHandcuffs
 An SCP:SL EXILED plugin that adds a few QoL features to allow server owners to make handcuffing better suit their needs.

# Features
- You can make people immune to handcuffing if they are tutorial/have god mod/have the required permission

# Permissions
- bh.immunity - makes you immune to handcuffing from any source (if you don't want people with all perms to be immune just set dont_check_for_perms to true)

# Default Config
```yaml
better_handcuffs:
  # Enables or disables the plugin.
  is_enabled: true
  # Whether or not debug messages should be shown in the console.
  debug: false
  # Should tutorials be immune to handcuffing? Default: true
  ignore_tutorials: true
  # Should players with GodMode enabled be immune to handcuffing? Default: true
  ignore_god_mode: true
  # Should the plugin not check if the cuffed player has the perms to ignore cuffing.
  dont_check_for_perms: false
```