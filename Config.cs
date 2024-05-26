using System;
using System.Configuration;
using System.IO;
using Terraria;
using Terraria.IO;
using Terraria.ModLoader;

namespace BreezyGen;

public static class Config
{

    // Copper Generation Settings
    public static int PhaseOneCopperStrengthMin = 3;
    public static int PhaseOneCopperStrengthMax = 6;
    public static int PhaseOneCopperStepsMin = 2;
    public static int PhaseOneCopperStepsMax = 6;

    public static int PhaseTwoCopperStrengthMin = 3;
    public static int PhaseTwoCopperStrengthMax = 7;
    public static int PhaseTwoCopperStepsMin = 3;
    public static int PhaseTwoCopperStepsMax = 7;
    
    public static int PhaseThreeCopperStrengthMin = 4;
    public static int PhaseThreeCopperStrengthMax = 9
    public static int PhaseThreeCopperStepsMin = 4;
    public static int PhaseThreeCopperStepsMax = 8;

    // Configuration Variables
    static string ConfigPath = Path.Combine(Main.SavePath, "Mod Configs", "BreezyGen.json");
    static Preferences Configuration = new Preferences(ConfigPath);

    public static void Load()
    {
        bool success = ReadConfig();
        if(!success)
        {
            ModContent.GetInstance<BreezyGen>().Logger.Info("Configuration not found, creating new configuration.");
            CreateConfig();
        }
        else
        {
            ModContent.GetInstance<BreezyGen>().Logger.Info("Configuration loaded successfully.");
        }
    }

    static bool ReadConfig()
    {
        if(Configuration.Load())
        {
            // Phase One Copper Config
            Configuration.Get("PhaseOneCopperStrengthMin", ref PhaseOneCopperStrengthMin);
            Configuration.Get("PhaseOneCopperStrengthMax", ref PhaseOneCopperStrengthMax);
            Configuration.Get("PhaseOneCopperStepsMin", ref PhaseOneCopperStepsMin);
            Configuration.Get("PhaseOneCopperStepsMax", ref PhaseOneCopperStepsMax);
            // Phase Two Copper Config
            Configuration.Get("PhaseTwoCopperStrengthMin", ref PhaseTwoCopperStrengthMin);
            Configuration.Get("PhaseTwoCopperStrengthMax", ref PhaseTwoCopperStrengthMax);
            Configuration.Get("PhaseTwoCopperStepsMin", ref PhaseTwoCopperStepsMin);
            Configuration.Get("PhaseTwoCopperStepsMax", ref PhaseTwoCopperStepsMax);
            // Phase Three Copper Config
            Configuration.Get("PhaseThreeCopperStrengthMin", ref PhaseThreeCopperStrengthMin);
            Configuration.Get("PhaseThreeCopperStrengthMax", ref PhaseThreeCopperStrengthMax);
            Configuration.Get("PhaseThreeCopperStepsMin", ref PhaseThreeCopperStepsMin);
            Configuration.Get("PhaseThreeCopperStepsMax", ref PhaseThreeCopperStepsMax);
            // Return Success
            return true;
        }
        return false;
    }

    static void CreateConfig()
    {
        Configuration.Clear();
        // Phase One Copper Config
        Configuration.Put("PhaseOneCopperStrengthMin", PhaseOneCopperStrengthMin);
        Configuration.Put("PhaseOneCopperStrengthMax", PhaseOneCopperStrengthMax);
        Configuration.Put("PhaseOneCopperStepsMin", PhaseOneCopperStepsMin);
        Configuration.Put("PhaseOneCopperStepsMax", PhaseOneCopperStepsMax);
        // Phase Two Copper Config
        Configuration.Put("PhaseTwoCopperStrengthMin", PhaseTwoCopperStrengthMin);
        Configuration.Put("PhaseTwoCopperStrengthMax", PhaseTwoCopperStrengthMax);
        Configuration.Put("PhaseTwoCopperStepsMin", PhaseTwoCopperStepsMin);
        Configuration.Put("PhaseTwoCopperStepsMax", PhaseTwoCopperStepsMax);
        // Phase Three Copper Config
        Configuration.Put("PhaseThreeCopperStrengthMin", PhaseThreeCopperStrengthMin);
        Configuration.Put("PhaseThreeCopperStrengthMax", PhaseThreeCopperStrengthMax);
        Configuration.Put("PhaseThreeCopperStepsMin", PhaseThreeCopperStepsMin);
        Configuration.Put("PhaseThreeCopperStepsMax", PhaseThreeCopperStepsMax);
        // Save Configuration
        Configuration.Save();
    }

}
