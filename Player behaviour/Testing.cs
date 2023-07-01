using Terraria.ModLoader;

namespace Alterworld.Player_behaviour
{
	// Pay no attention to this please, it is for testing only lol (I know that there are already mods for that but idc lol)
	public class Testing : ModCommand
	{
		public override string Command => "give";

		public override CommandType Type => CommandType.Chat;

		public override void Action(CommandCaller caller, string input, string[] args)
		{
			if (args.Length != 2) return;

			if (int.TryParse(args[0], out var id) && int.TryParse(args[1], out var stack)) 
			{
				caller.Player.QuickSpawnItem(null,id, stack);
			}
		}
	}
}
