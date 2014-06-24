using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class MysticBlood : BaseReagent, ICommodity
	{
		int ICommodity.DescriptionNumber { get { return LabelNumber; } }
		bool ICommodity.IsDeedable { get { return true; } }

		[Constructable]
		public MysticBlood() : this( 1 )
		{
		}

		[Constructable]
		public MysticBlood( int amount ) : base( 0xF7D, amount )
		{
		Name = "Vial of Mystic Blood";
		Hue = 2180;
		}

		public MysticBlood( Serial serial ) : base( serial )
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