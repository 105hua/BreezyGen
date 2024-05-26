using Terraria;
using Terraria.GameContent.Generation;
using Terraria.IO;
using Terraria.ModLoader;
using Terraria.WorldBuilding;

namespace BreezyGen;

public class PreHardmodeWorldGenHook : ModSystem
{

    public override void Load()
    {
        WorldGen.DetourPass((PassLegacy)WorldGen.VanillaGenPasses["Shinies"], ShiniesGenDetour);
    }

    // Goes through a similar world generation process as the vanilla one but with some modifications to ore strength and steps.
    void ShiniesGenDetour(WorldGen.orig_GenPassDetour orig, object self, GenerationProgress progress, GameConfiguration configuration){
        ModContent.GetInstance<BreezyGen>().Logger.Info("BEGIN SHINIES GENERATION");
        CopperGen.GenerateCopper(); // Generates copper ore.
        IronGen.GenerateIron(); // Generates iron ore.
        SilverGen.GenerateSilver(); // Generates silver ore.
        GoldGen.GenerateGold(); // Generates gold ore.
        ModContent.GetInstance<BreezyGen>().Logger.Info("END SHINIES GENERATION");
    }
}
