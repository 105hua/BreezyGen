using System;
using Terraria;
using Terraria.ModLoader;
using Terraria.WorldBuilding;

namespace BreezyGen;

public class SilverGen
{

    public static void GenerateSilver()
    {

        ModContent.GetInstance<BreezyGen>().Logger.Info("PERFORMING SILVER GENERATION");

        ModContent.GetInstance<BreezyGen>().Logger.Info("SILVER #1");
        for(int i = 0; i < (int)(double)(Main.maxTilesX * Main.maxTilesY * 2.6E-05); i++)
        {
            if(WorldGen.drunkWorldGen)
            {
                if(WorldGen.genRand.NextBool(2))
                {
                    GenVars.silver = 9;
                }
                else
                {
                    GenVars.silver = 168;
                }
            }
            int x = WorldGen.genRand.Next(0, Main.maxTilesX);
            int y = WorldGen.genRand.Next((int)Main.rockLayer - 100, Main.maxTilesY - 250);
            int strength = WorldGen.genRand.Next(6, 12);
            int steps = WorldGen.genRand.Next(6, 12);
            WorldGen.TileRunner(x, y, strength, steps, GenVars.silver);
        }

        ModContent.GetInstance<BreezyGen>().Logger.Info("SILVER #2");
        for(int i = 0; i < (int)(double)(Main.maxTilesX * Main.maxTilesY * 0.00015); i++)
        {
            if(WorldGen.drunkWorldGen)
            {
                if(WorldGen.genRand.NextBool(2))
                {
                    GenVars.silver = 9;
                }
                else
                {
                    GenVars.silver = 168;
                }
            }
            int x = WorldGen.genRand.Next(0, Main.maxTilesX);
            int y = WorldGen.genRand.Next((int)Main.worldSurface, (int)Main.rockLayer);
            int strength = WorldGen.genRand.Next(8, 18);
            int steps = WorldGen.genRand.Next(8, 16);
            WorldGen.TileRunner(x, y, strength, steps, GenVars.silver);
        }

        ModContent.GetInstance<BreezyGen>().Logger.Info("SILVER #3");
        for(int i = 0; i < (int)(double)(Main.maxTilesX * Main.maxTilesY * 0.00012); i++)
        {
            if(WorldGen.drunkWorldGen)
            {
                if(WorldGen.genRand.NextBool(2))
                {
                    GenVars.silver = 9;
                }
                else
                {
                    GenVars.silver = 168;
                }
            }
            int x = WorldGen.genRand.Next(0, Main.maxTilesX);
            int y = WorldGen.genRand.Next(0, (int)GenVars.worldSurfaceLow);
            int strength = WorldGen.genRand.Next(8, 18);
            int steps = WorldGen.genRand.Next(8, 16);
            WorldGen.TileRunner(x, y, strength, steps, GenVars.silver);
        }

        ModContent.GetInstance<BreezyGen>().Logger.Info("SILVER GENERATION COMPLETE.");

    }

}
