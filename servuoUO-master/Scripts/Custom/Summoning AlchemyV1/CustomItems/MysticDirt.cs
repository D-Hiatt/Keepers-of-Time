using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class MysticDirt : BaseReagent, ICommodity
	{
		int ICommodity.DescriptionNumber { get { return LabelNumber; } }
		bool ICommodity.IsDeedable { get { return true; } }

		[Constructable]
		public MysticDirt() : this( 1 )
		{
		}

		[Constructable]
		public MysticDirt( int amount ) : base( 0xF7D, amount )
		{
		Name = "Vial of Mystic Dirt";
		Hue = 2054;
		}

		public MysticDirt( Serial serial ) : base( serial )
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