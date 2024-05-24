using Terraria;
using Terraria.ModLoader;
using Terraria.WorldBuilding;

namespace BreezyGen;

public class CopperGen
{
    public static void GenerateCopper()
    {
        ModContent.GetInstance<BreezyGen>().Logger.Info("PERFORMING COPPER GENERATION");

        ModContent.GetInstance<BreezyGen>().Logger.Info("COPPER #1");
        for(int i = 0; i < (int)(double)(Main.maxTilesX * Main.maxTilesY) * 6E-05; i++){
            // Drunk World Check
            if(WorldGen.drunkWorldGen){
                if (WorldGen.genRand.NextBool(2)){
                    GenVars.copper = 7;
                }else{
                    GenVars.copper = 166;
                }
            }
            // World Generation
            int x = WorldGen.genRand.Next(0, Main.maxTilesX);
            int y = WorldGen.genRand.Next((int)GenVars.worldSurfaceLow, (int)GenVars.worldSurfaceHigh);
            int strength = WorldGen.genRand.Next(6, 12);
            int steps = WorldGen.genRand.Next(4, 12); 
            WorldGen.TileRunner(x, y, strength, steps, GenVars.copper);
        }
        
        ModContent.GetInstance<BreezyGen>().Logger.Info("COPPER #2");
        for(int i = 0; i< (int)(double)(Main.maxTilesX * Main.maxTilesY * 8E-05); i++){
            // Drunk World Check
            if(WorldGen.drunkWorldGen){
                if (WorldGen.genRand.NextBool(2)){
                    GenVars.copper = 7;
                }else{
                    GenVars.copper = 166;
                }
            }
            // World Generation
            int x = WorldGen.genRand.Next(0, Main.maxTilesX);
            int y = WorldGen.genRand.Next((int)GenVars.worldSurfaceHigh, (int)GenVars.rockLayerHigh);
            int strength = WorldGen.genRand.Next(6, 14);
            int steps = WorldGen.genRand.Next(6, 14);
            WorldGen.TileRunner(x, y, strength, steps, GenVars.copper);
        }

        ModContent.GetInstance<BreezyGen>().Logger.Info("COPPER #3");
        for(int i = 0; i < (int)(double)(Main.maxTilesX * Main.maxTilesY * 0.0002); i++){
            // Drunk World Check
            if(WorldGen.drunkWorldGen){
                if (WorldGen.genRand.NextBool(2)){
                    GenVars.copper = 7;
                }else{
                    GenVars.copper = 166;
                }
            }
            // World Generation
            int x = WorldGen.genRand.Next(0, Main.maxTilesX);
            int y = WorldGen.genRand.Next((int)GenVars.rockLayerLow, Main.maxTilesY);
            int strength = WorldGen.genRand.Next(8, 18);
            int steps = WorldGen.genRand.Next(8, 16);
            WorldGen.TileRunner(x, y, strength, steps, GenVars.copper);
        }

        ModContent.GetInstance<BreezyGen>().Logger.Info("COPPER GENERATION COMPLETE");
    }
}
