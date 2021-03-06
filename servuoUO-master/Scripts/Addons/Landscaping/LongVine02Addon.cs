/////////////////////////////////////////////////
//
// Automatically generated by the
// AddonGenerator script by Arya
//
/////////////////////////////////////////////////
using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class LongVine02Addon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new LongVine02AddonDeed();
			}
		}

		[ Constructable ]
		public LongVine02Addon()
		{
			AddonComponent ac = null;
			ac = new AddonComponent( 3436 );
			AddComponent( ac, 0, 1, 0 );
			ac = new AddonComponent( 3435 );
			AddComponent( ac, 1, 0, 0 );
			ac = new AddonComponent( 3434 );
			AddComponent( ac, 2, -1, 0 );
			ac = new AddonComponent( 3437 );
			AddComponent( ac, -1, 2, 0 );

		}

		public LongVine02Addon( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( 0 ); // Version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}

	public class LongVine02AddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new LongVine02Addon();
			}
		}

		[Constructable]
		public LongVine02AddonDeed()
		{
			Name = "LongVine02";
		}

		public LongVine02AddonDeed( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( 0 ); // Version
		}

		public override void	Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}
}