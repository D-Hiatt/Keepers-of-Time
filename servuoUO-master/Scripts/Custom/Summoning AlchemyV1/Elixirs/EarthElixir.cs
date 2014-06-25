using System;
using Server;

namespace Server.Items
{
	public class EarthElixir : BaseReagent, ICommodity
	{
		int ICommodity.DescriptionNumber { get { return LabelNumber; } }
		bool ICommodity.IsDeedable { get { return true; } }
		
		[Constructable]
		public EarthElixir() : base( 0xEFE )
		{
			Name = "Earth Elixir";
			LootType = LootType.Blessed;
			Hue = 2054;
		}

		public EarthElixir( Serial serial ) : base( serial )
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

