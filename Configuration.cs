using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace MultipleLures
{

    [Label("$Mods.MultipleLures.Config.Label")]
    public class Configuration : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ClientSide;

        public override void OnLoaded() => MultipleLuresGlobalProj.configuration = this;

        [Label("$Mods.MultipleLures.Config.LuresAmount")]
        [Range(0, 200)]
        [Increment(1)]
        [DefaultValue(5)]
        [Slider]
        public int LuresAmount;
    }
}
