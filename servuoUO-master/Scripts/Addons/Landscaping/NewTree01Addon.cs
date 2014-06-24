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
	public class NewTree01Addon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new NewTree01AddonDeed();
			}
		}

		[ Constructable ]
		public NewTree01Addon()
		{
			AddonComponent ac = null;
			ac = new AddonComponent( 12481 );
			AddComponent( ac, 2, 1, 0 );
			ac = new AddonComponent( 12480 );
			AddComponent( ac, -1, 2, 0 );
			ac = new AddonComponent( 12479 );
			AddComponent( ac, 0, 2, 0 );
			ac = new AddonComponent( 12478 );
			AddComponent( ac, 1, 2, 0 );
			ac = new AddonComponent( 12477 );
			AddComponent( ac, 2, 2, 0 );
			ac = new AddonComponent( 12470 );
			AddComponent( ac, 2, -2, 0 );
			ac = new AddonComponent( 12469 );
			AddComponent( ac, 2, -1, 0 );
			ac = new AddonComponent( 12468 );
			AddComponent( ac, 2, 0, 0 );
			ac = new AddonComponent( 12467 );
			AddComponent( ac, 2, 1, 0 );
			ac = new AddonComponent( 12466 );
			AddComponent( ac, -1, 2, 0 );
			ac = new AddonComponent( 12465 );
			AddComponent( ac, 0, 2, 0 );
			ac = new AddonComponent( 12464 );
			AddComponent( ac, 1, 2, 0 );
			ac = new AddonComponent( 12463 );
			AddComponent( ac, 2, 2, 0 );

		}

		public NewTree01Addon( Serial serial ) : base( serial )
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

	public class NewTree01AddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new NewTree01Addon();
			}
		}

		[Constructable]
		public NewTree01AddonDeed()
		{
			Name = "NewTree01";
		}

		public NewTree01AddonDeed( Serial serial ) : base( serial )
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