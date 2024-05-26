using Terraria;
using Terraria.ModLoader;
using Terraria.WorldBuilding;

namespace BreezyGen;

public class GoldGen
{
    public static void GenerateGold()
    {
        ModContent.GetInstance<BreezyGen>().Logger.Info("PERFORMING GOLD GENERATION");

        ModContent.GetInstance<BreezyGen>().Logger.Info("GOLD ORE #1");
        for(int i = 0; i < (int)(double)(Main.maxTilesX * Main.maxTilesY * 0.00012); i++)
        {
            if(WorldGen.drunkWorldGen)
            {
                if(WorldGen.genRand.NextBool(2))
                {
                    GenVars.gold = 8;
                }
                else
                {
                    GenVars.gold = 169;
                }
            }
            int x = WorldGen.genRand.Next(0, Main.maxTilesX);
            int y = WorldGen.genRand.Next((int)Main.worldSurface, (int)Main.rockLayer);
            int strength = WorldGen.genRand.Next(8, 16);
            int steps = WorldGen.genRand.Next(8, 16);
            WorldGen.TileRunner(x, y, strength, steps, GenVars.gold);
        }

        ModContent.GetInstance<BreezyGen>().Logger.Info("GOLD ORE #2");
        for(int i = 0; i < (int)(double)Main.maxTilesX * Main.maxTilesY * 0.00012; i++)
        {
            if(WorldGen.drunkWorldGen)
            {
                if(WorldGen.genRand.NextBool(2))
                {
                    GenVars.gold = 8;
                }
                else
                {
                    GenVars.gold = 169;
                }
            }
            int x = WorldGen.genRand.Next(0, Main.maxTilesX);
            int y = WorldGen.genRand.Next(0, (int)GenVars.worldSurfaceLow - 20);
            int strength = WorldGen.genRand.Next(8, 16);
            int steps = WorldGen.genRand.Next(8, 16);
            WorldGen.TileRunner(x, y, strength, steps, GenVars.gold);
        }

        ModContent.GetInstance<BreezyGen>().Logger.Info("GOLD ORE #3");
        if(WorldGen.drunkWorldGen){
            for(int i = 0; i < (int)(double)Main.maxTilesX * Main.maxTilesY * 2.25E-05 / 2.0; i++)
            {
                int x = WorldGen.genRand.Next(0, Main.maxTilesX);
                int y = WorldGen.genRand.Next((int)Main.rockLayer, Main.maxTilesY);
                int strength = WorldGen.genRand.Next(6, 12);
                int steps = WorldGen.genRand.Next(8, 16);
                WorldGen.TileRunner(x, y, strength, steps, 204);
            }

            for(int i = 0; i < (int)(double)Main.maxTilesX * Main.maxTilesY * 2.25E-05 / 2.0; i++)
            {
                int x = WorldGen.genRand.Next(0, Main.maxTilesX);
                int y = WorldGen.genRand.Next((int)Main.rockLayer, Main.maxTilesY);
                int strength = WorldGen.genRand.Next(6, 12);
                int steps = WorldGen.genRand.Next(8, 16);
                WorldGen.TileRunner(x, y, strength, steps, 22);
            }
        }
        if(WorldGen.crimson)
        {
            for(int i = 0; i < (int)(double)Main.maxTilesX * Main.maxTilesY * 2.25E-05; i++)
            {
                int x = WorldGen.genRand.Next(0, Main.maxTilesX);
                int y = WorldGen.genRand.Next((int)Main.rockLayer, Main.maxTilesY);
                int strength = WorldGen.genRand.Next(6, 12);
                int steps = WorldGen.genRand.Next(8, 16);
                WorldGen.TileRunner(x, y, strength, steps, 204);
            }
        }
        else
        {
            for(int i = 0; i < (int)(double)Main.maxTilesX * Main.maxTilesY * 2.25E-05; i++)
            {
                int x = WorldGen.genRand.Next(0, Main.maxTilesX);
                int y = WorldGen.genRand.Next((int)Main.rockLayer, Main.maxTilesY);
                int strength = WorldGen.genRand.Next(6, 12);
                int steps = WorldGen.genRand.Next(8, 16);
                WorldGen.TileRunner(x, y, strength, steps, 22);
            }
        }
    }
}