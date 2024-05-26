using Terraria.ModLoader;

namespace BreezyGen
{
	public class BreezyGen : Mod
	{
        public override void Load()
        {
			Config.Load();
			base.Load();
        }
    }
}
