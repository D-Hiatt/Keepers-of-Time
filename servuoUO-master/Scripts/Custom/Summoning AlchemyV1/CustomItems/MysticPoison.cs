using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class MysticPoison : BaseReagent, ICommodity
	{
		int ICommodity.DescriptionNumber { get { return LabelNumber; } }
		bool ICommodity.IsDeedable { get { return true; } }

		[Constructable]
		public MysticPoison() : this( 1 )
		{
		}

		[Constructable]
		public MysticPoison( int amount ) : base( 0xF7D, amount )
		{
		Name = "Vial of Mystic Poison";
		Hue = 2799;
		}

		public MysticPoison( Serial serial ) : base( serial )
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