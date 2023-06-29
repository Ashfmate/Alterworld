using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Alterworld.Player_behaviour
{
	public class FruitManaRegen : GlobalItem
	{
		private static int mana_feed = 50;
		private static readonly List<int> unhealthy_drinks = new() { ItemID.Ale, ItemID.Sake, ItemID.BananaDaiquiri, ItemID.PeachSangria, ItemID.PinaColada, ItemID.BloodyMoscato, ItemID.CreamSoda };
		public override void OnConsumeItem(Item item, Player player)
		{
			// TODO, later there would be a fruit counter that will make it so that food will have diminishing returns
			if (!unhealthy_drinks.Contains(item.netID) && ItemID.Sets.IsFood[item.netID])
			{
				player.statMana += mana_feed;
			}
		}
	}
}
