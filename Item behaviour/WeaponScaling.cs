using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Alterworld.Item_behaviour
{
	public class WeaponScaling : GlobalItem
	{
		public override void OnConsumeItem(Item item, Player player)
		{
			switch (item.netID)
			{
				case ItemID.LesserManaPotion:
					player.AddBuff(BuffID.MagicPower, 5 * 60);
					player.statMana -= 50;
					break;
				case ItemID.ManaPotion:
					player.AddBuff(BuffID.MagicPower, 7 * 60);
					player.statMana -= 100;
					break;
				case ItemID.GreaterManaPotion:
					player.AddBuff(BuffID.MagicPower, 12 * 60);
					player.statMana -= 150;
					break;
				case ItemID.SuperManaPotion:
					player.AddBuff(BuffID.MagicPower, 20 * 60);
					player.statMana -= 300;
					break;
				default:
					base.ConsumeItem(item, player);
					break;
			}
			player.ClearBuff(BuffID.ManaSickness);
		}
	}
}
