using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Alterworld.Buff_behaviour
{
	public class ManaBuff : GlobalBuff
	{
		public override void Update(int type, Player player, ref int buffIndex)
		{
			if (type == BuffID.MagicPower) 
			{
				player.manaCost += 0.2f;
				player.GetTotalDamage<MagicDamageClass>().Scale(1.2f);
			}
		}
	}
}
