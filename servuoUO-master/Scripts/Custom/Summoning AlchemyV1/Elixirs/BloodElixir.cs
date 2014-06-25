using System;
using Server;

namespace Server.Items
{
	public class BloodElixir : BaseReagent, ICommodity
	{
		int ICommodity.DescriptionNumber { get { return LabelNumber; } }
		bool ICommodity.IsDeedable { get { return true; } }
		
		[Constructable]
		public BloodElixir() : base( 0xEFE )
		{
			Name = "Blood Elixir";
			LootType = LootType.Blessed;
			Hue = 2180;
		}

		public BloodElixir( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 0 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();
		}
	}
}

