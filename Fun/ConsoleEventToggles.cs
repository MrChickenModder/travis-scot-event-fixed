using hamburbur.Mod_Backend;
using hamburbur.Plugins;
using hamburburPluginTemplate.Backend;

namespace skidbur.Mods.Fun;

[HamburburPluginMod("Fun")]
[hamburburmod("Travis Event", "Spawns or disables the Travis event asset", ButtonType.Togglable,
        AccessSetting.Public, EnabledType.Disabled, 0)]
public class TravisEvent : hamburburmod
{
    protected override void OnEnable() => ConsoleEventBridge.SpawnTravis();
    protected override void OnDisable() => ConsoleEventBridge.DestroyTravis();
}

[HamburburPluginMod("Fun")]
[hamburburmod("Event View", "Clears or restores the local event view blockers", ButtonType.Togglable,
        AccessSetting.Public, EnabledType.Disabled, 0)]
public class EventView : hamburburmod
{
    protected override void OnEnable() => ConsoleEventBridge.ClearEventView();
    protected override void OnDisable() => ConsoleEventBridge.RestoreEventView();
}
