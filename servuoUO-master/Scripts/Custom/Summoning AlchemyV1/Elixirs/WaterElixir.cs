using System;
using Server;

namespace Server.Items
{
			
	public class WaterElixir : BaseReagent, ICommodity
	{
		int ICommodity.DescriptionNumber { get { return LabelNumber; } }
		bool ICommodity.IsDeedable { get { return true; } }

	

		[Constructable]
		public WaterElixir() : base( 0xEFE )
		{
			Name = "Water Elixir";
			Hue = 2319;
		}

		public WaterElixir( Serial serial ) : base( serial )
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

