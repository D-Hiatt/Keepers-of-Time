using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class MysticAsh : BaseReagent, ICommodity
	{
		int ICommodity.DescriptionNumber { get { return LabelNumber; } }
		bool ICommodity.IsDeedable { get { return true; } }

		[Constructable]
		public MysticAsh() : this( 1 )
		{
		}

		[Constructable]
		public MysticAsh( int amount ) : base( 0xF7D, amount )
		{
		Name = "Vial of Mystic Ash";
		Hue = 2719;
		}

		public MysticAsh( Serial serial ) : base( serial )
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