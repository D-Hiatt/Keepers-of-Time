using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class MysticSand : BaseReagent, ICommodity
	{
		int ICommodity.DescriptionNumber { get { return LabelNumber; } }
		bool ICommodity.IsDeedable { get { return true; } }

		[Constructable]
		public MysticSand() : this( 1 )
		{
		}

		[Constructable]
		public MysticSand( int amount ) : base( 0xF7D, amount )
		{
		Name = "Vial of Mystic Sand";
		Hue = 2971;
		}

		public MysticSand( Serial serial ) : base( serial )
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