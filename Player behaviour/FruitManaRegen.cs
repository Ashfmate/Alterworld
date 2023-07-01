using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Alterworld.Player_behaviour
{
	// This is for replenshing mana when a food item is consumed, with diminishing returns for a bit
	public class FruitManaRegen : GlobalItem
	{
		// Very high because if it were to be just 50 then it
		private static int ManaFeed = 5000; 
		// List of drinks that are not healthy so should not give 
		private static readonly List<int> unhealthy_drinks = new() { ItemID.Ale, ItemID.Sake, ItemID.BananaDaiquiri, ItemID.PeachSangria, ItemID.PinaColada, ItemID.BloodyMoscato, ItemID.CreamSoda };
		public override void OnConsumeItem(Item item, Player player)
		{
			if (!unhealthy_drinks.Contains(item.netID) && ItemID.Sets.IsFood[item.netID])
			{
				player.statMana += ManaFeed / 100; // Brought down to one hundredth so that the addition is reasonable
				ManaFeed -= (ManaFeed >= 1000)? 1000 : 0; // If the player consumes food, then it will have a lesser effect
			}
		}
		
		public static void AddManaFeed()
		{
			ManaFeed += (ManaFeed >= 5000)? 1 : 0; // Will be changed multiple times though the concept works, it replenishes the mana feed field
		}
	}
}
