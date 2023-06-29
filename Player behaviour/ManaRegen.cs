using Terraria;
using Terraria.ModLoader;

namespace Alterworld.Player_behaviour
{
	public class ManaRegen : ModPlayer
	{
		private readonly int slow_recharge_max = 2;
		private int slow_recharge = 0;
		
		public override void OnConsumeMana(Item item, int manaConsumed) // !!! Will be used later
		{
			base.OnConsumeMana(item, manaConsumed);
		}
		public override void PreUpdate()
		{
			Player.manaRegen = 0;
			Player.manaRegenBonus = 0;
			Player.manaRegenBonus = 0;
			Player.manaRegenDelay = int.MaxValue;
			if (Player.sleeping.FullyFallenAsleep) 
			{
				if (slow_recharge > 0) --slow_recharge;
				else { Player.statMana += 1; slow_recharge = slow_recharge_max; }
			}
		}
	}
}
