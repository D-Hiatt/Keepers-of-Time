using System;
using Server;
using Server.Targets;
using Server.Targeting;
using Server.Items;
using System.Collections.Generic;
using Server.ContextMenus;
using Server.Gumps;
using Server.Mobiles;
using Xanthos.Interfaces;

namespace Xanthos.Evo
{
	[CorpseName( "Phoenix Ashes" )]
	public class Phoenix : BaseEvo, IEvoCreature
	{
		public override BaseEvoSpec GetEvoSpec()
		{
			return PhoenixSpec.Instance;
		}

		public override BaseEvoEgg GetEvoEgg()
		{
			return new PhoenixEgg();
		}
		public override bool CanHeal{ get{ return true; } }
		public override bool CanHealOwner{ get{ return true; } }
		public override bool AddPointsOnDamage { get { return true; } }
		public override bool AddPointsOnMelee { get { return false; } }
		public override Type GetEvoDustType() { return typeof( PhoenixDust ); }

		public Phoenix( string name ) : base( name, AIType.AI_Mage, 0.01 )
		{
		}

		public Phoenix( Serial serial ) : base( serial )
		{
		}
		
		public override void Serialize(GenericWriter writer)
		{
			base.Serialize(writer);

			writer.Write( (int)0 );			
		}

		public override void Deserialize(GenericReader reader)
		{
			base.Deserialize(reader);

			int version = reader.ReadInt();
		}
	}
}