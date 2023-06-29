﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.Chat;
using Terraria.Chat.Commands;
using Terraria.ModLoader;

namespace Alterworld.Player_behaviour
{
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
