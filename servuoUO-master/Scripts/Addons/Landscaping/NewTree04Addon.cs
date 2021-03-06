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
	public class NewTree04Addon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new NewTree04AddonDeed();
			}
		}

		[ Constructable ]
		public NewTree04Addon()
		{
			AddonComponent ac = null;
			ac = new AddonComponent( 12505 );
			AddComponent( ac, 1, -1, 0 );
			ac = new AddonComponent( 12504 );
			AddComponent( ac, 1, 0, 0 );
			ac = new AddonComponent( 12503 );
			AddComponent( ac, 1, 1, 0 );
			ac = new AddonComponent( 12502 );
			AddComponent( ac, -1, 2, 0 );
			ac = new AddonComponent( 12501 );
			AddComponent( ac, 0, 2, 0 );
			ac = new AddonComponent( 12500 );
			AddComponent( ac, 1, 2, 0 );
			ac = new AddonComponent( 12494 );
			AddComponent( ac, 2, 0, 0 );
			ac = new AddonComponent( 12493 );
			AddComponent( ac, 2, 1, 0 );
			ac = new AddonComponent( 12492 );
			AddComponent( ac, -1, 2, 0 );
			ac = new AddonComponent( 12491 );
			AddComponent( ac, -1, 2, 0 );
			ac = new AddonComponent( 12490 );
			AddComponent( ac, 0, 2, 0 );
			ac = new AddonComponent( 12489 );
			AddComponent( ac, 1, 2, 0 );
			ac = new AddonComponent( 12488 );
			AddComponent( ac, 2, 2, 0 );

		}

		public NewTree04Addon( Serial serial ) : base( serial )
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

	public class NewTree04AddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new NewTree04Addon();
			}
		}

		[Constructable]
		public NewTree04AddonDeed()
		{
			Name = "NewTree04";
		}

		public NewTree04AddonDeed( Serial serial ) : base( serial )
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