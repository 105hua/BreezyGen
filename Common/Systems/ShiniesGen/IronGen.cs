using Terraria;
using Terraria.ModLoader;
using Terraria.WorldBuilding;

namespace BreezyGen;

public class IronGen
{

    public static void GenerateIron()
    {
        ModContent.GetInstance<BreezyGen>().Logger.Info("PERFORMING IRON GENERATION");

        ModContent.GetInstance<BreezyGen>().Logger.Info("IRON #1");
        for(int i = 0; i < (int)(double)(Main.maxTilesX * Main.maxTilesY) * 3E-05; i++){
            // Drunk World Check
            if(WorldGen.drunkWorldGen){
                if (WorldGen.genRand.NextBool(2)){
                    GenVars.iron = 6;
                }else{
                    GenVars.iron = 167;
                }
            }
            // World Generation
            int x = WorldGen.genRand.Next(0, Main.maxTilesX);
            int y = WorldGen.genRand.Next((int)GenVars.worldSurfaceLow, (int)GenVars.worldSurfaceHigh);
            int strength = WorldGen.genRand.Next(6, 14);
            int steps = WorldGen.genRand.Next(4, 10);
            WorldGen.TileRunner(x, y, strength, steps, GenVars.iron);
        }

        ModContent.GetInstance<BreezyGen>().Logger.Info("IRON #2");
        for(int i = 0; i < (int)(double)(Main.maxTilesX * Main.maxTilesY * 8E-05); i++){
            // Drunk World Check
            if(WorldGen.drunkWorldGen){
                if(WorldGen.genRand.NextBool(2)){
                    GenVars.iron = 6;
                }else{
                    GenVars.iron = 167;
                }
            }
            // World Generation
            int x = WorldGen.genRand.Next(0, Main.maxTilesX);
            int y = WorldGen.genRand.Next((int)GenVars.worldSurfaceHigh, (int)GenVars.rockLayerHigh);
            int strength = WorldGen.genRand.Next(6, 12);
            int steps = WorldGen.genRand.Next(6, 12);
            WorldGen.TileRunner(x, y, strength, steps, GenVars.iron);
        }

        ModContent.GetInstance<BreezyGen>().Logger.Info("IRON #3");
        for(int i = 0; i < (int)(double)(Main.maxTilesX * Main.maxTilesY * 0.0002); i++){
            // Drunk World Check
            if(WorldGen.drunkWorldGen){
                if(WorldGen.genRand.NextBool(2)){
                    GenVars.iron = 6;
                }else{
                    GenVars.iron = 167;
                }
            }
            // World Generation
            int x = WorldGen.genRand.Next(0, Main.maxTilesX);
            int y = WorldGen.genRand.Next((int)GenVars.rockLayerLow, Main.maxTilesY);
            int strength = WorldGen.genRand.Next(8, 18);
            int steps = WorldGen.genRand.Next(8, 16);
            WorldGen.TileRunner(x, y, strength, steps, GenVars.iron);
        }

        ModContent.GetInstance<BreezyGen>().Logger.Info("IRON GENERATION COMPLETE");
    }

}
