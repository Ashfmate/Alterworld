using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Alterworld.Player_behaviour
{
	// This is for replenshing mana when a food item is consumed, with diminishing returns for a bit
	public class FruitManaRegen : GlobalItem
	{
		// List of drinks that are not healthy so should not give 
		private static readonly List<int> unhealthy_drinks = new() { ItemID.Ale, ItemID.Sake, ItemID.BananaDaiquiri, ItemID.PeachSangria, ItemID.PinaColada, ItemID.BloodyMoscato, ItemID.CreamSoda };
		// For now, the food will replenish the same amount for all players, later will be localized
		public override void OnConsumeItem(Item item, Player player)
		{
			if (!unhealthy_drinks.Contains(item.netID) && ItemID.Sets.IsFood[item.netID])
			{
				if (player.TryGetModPlayer<ManaRegen>(out var res))
					res.HasEaten();
			}
		}
	}
}
