using Exiled.API.Features;
using Exiled.Events.EventArgs;
using Exiled.Events.EventArgs.Player;

namespace AutoKOS;

public class Plugin : Plugin<Config>
{
    public override string Name => "AutoKOS";
    public override string Author => "ALEXWARELLC";
    public override string Prefix => "autokos";
    public override Version Version => new Version(1, 0, 0);

    public override void OnEnabled()
    {
        // Initialize KOS Detection
        Exiled.Events.Handlers.Player.Died += OnPlayerKilled;
    }

    public void OnPlayerKilled(DiedEventArgs ev)
    {
        if(ev.Player.IsCuffed)
        {
            
        }
    }

}
