using System;
using Server;

namespace Server.Items
{
	public class SandElixir : BaseReagent, ICommodity
	{
		int ICommodity.DescriptionNumber { get { return LabelNumber; } }
		bool ICommodity.IsDeedable { get { return true; } }
		
		[Constructable]
		public SandElixir() : base( 0xEFE )
		{
			Name = "Sand Elixir";
			LootType = LootType.Blessed;
			Hue = 2971;
		}

		public SandElixir( Serial serial ) : base( serial )
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

