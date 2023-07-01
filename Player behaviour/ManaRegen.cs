using Terraria;
using Terraria.ModLoader;

namespace Alterworld.Player_behaviour
{
	// This class changes the player behaviour where the player will no longer passively recharge mana
	// but instead will rely on strategising on the weapon use with the mana consumption that the player has
	// The weapons will have different mana consumptions to accomodate for this change
	public class ManaRegen : ModPlayer
	{
		// This field will be the maximum wait time for when the player starts replenishing mana when sleeping
		private readonly int slow_recharge_max = 2;
		// This field hols the current time
		private int slow_recharge = 0;
		
		public override void OnConsumeMana(Item item, int manaConsumed) // !!! Will be used later
		{
			base.OnConsumeMana(item, manaConsumed);
		}
		public override void PreUpdate()
		{
			// All mana replenishing fields are changed so that the player does not replenish mana passively
			Player.manaRegen = 0;
			Player.manaRegenBonus = 0;
			Player.manaRegenBonus = 0;
			Player.manaRegenDelay = int.MaxValue;
			// The mana that is replenished passively will only be done so in a controlled way when fully asleep
			if (Player.sleeping.FullyFallenAsleep) 
			{
				if (slow_recharge > 0) --slow_recharge;
				else { Player.statMana += 1; slow_recharge = slow_recharge_max; }
			}
		}
		public override void PostUpdate()
		{
			FruitManaRegen.AddManaFeed();
		}
	}
}
