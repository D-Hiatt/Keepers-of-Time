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
	public class TallTree06Addon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new TallTree06AddonDeed();
			}
		}

		[ Constructable ]
		public TallTree06Addon()
		{
			AddonComponent ac = null;
			ac = new AddonComponent( 3450 );
			AddComponent( ac, -2, 3, 0 );
			ac = new AddonComponent( 3451 );
			AddComponent( ac, -1, 2, 0 );
			ac = new AddonComponent( 3452 );
			AddComponent( ac, 0, 1, 0 );
			ac = new AddonComponent( 3453 );
			AddComponent( ac, 1, 0, 0 );
			ac = new AddonComponent( 3454 );
			AddComponent( ac, 2, -1, 0 );
			ac = new AddonComponent( 3455 );
			AddComponent( ac, 3, -2, 0 );
			ac = new AddonComponent( 3441 );
			AddComponent( ac, 2, -1, 0 );
			ac = new AddonComponent( 3442 );
			AddComponent( ac, 3, -2, 0 );
			ac = new AddonComponent( 3440 );
			AddComponent( ac, 1, 0, 0 );
			ac = new AddonComponent( 3439 );
			AddComponent( ac, 0, 1, 0 );
			ac = new AddonComponent( 3438 );
			AddComponent( ac, -1, 2, 0 );

		}

		public TallTree06Addon( Serial serial ) : base( serial )
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

	public class TallTree06AddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new TallTree06Addon();
			}
		}

		[Constructable]
		public TallTree06AddonDeed()
		{
			Name = "TallTree06";
		}

		public TallTree06AddonDeed( Serial serial ) : base( serial )
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