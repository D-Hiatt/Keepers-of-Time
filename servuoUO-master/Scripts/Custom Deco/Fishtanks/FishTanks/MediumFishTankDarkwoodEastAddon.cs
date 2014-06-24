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
	public class MediumFishTankDarkwoodEastAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new MediumFishTankDarkwoodEastAddonDeed();
			}
		}

		[ Constructable ]
		public MediumFishTankDarkwoodEastAddon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 13562 );
			AddComponent( ac, 0, 0, 2 );
			ac = new AddonComponent( 10645 );
			ac.Hue = 2406;
			AddComponent( ac, 1, 0, 1 );
			ac = new AddonComponent( 4044 );
			AddComponent( ac, 1, 0, 7 );
			ac = new AddonComponent( 3254 );
			AddComponent( ac, 1, 0, 8 );
			ac = new AddonComponent( 13410 );
			ac.Name = "Sand";
			ac.Hue = 345;
			AddComponent( ac, 1, 1, 6 );
			ac = new AddonComponent( 3543 );
			AddComponent( ac, 1, 1, 7 );
			ac = new AddonComponent( 13410 );
			ac.Name = "Sand";
			ac.Hue = 345;
			AddComponent( ac, 1, 0, 6 );
			ac = new AddonComponent( 13562 );
			AddComponent( ac, 0, 1, 3 );
			ac = new AddonComponent( 10642 );
			ac.Hue = 2406;
			AddComponent( ac, 0, 1, 5 );
			ac = new AddonComponent( 10642 );
			ac.Hue = 2406;
			AddComponent( ac, 0, 1, 11 );
			ac = new AddonComponent( 10642 );
			ac.Hue = 2406;
			AddComponent( ac, 0, 1, 3 );
			ac = new AddonComponent( 10642 );
			ac.Hue = 2406;
			AddComponent( ac, 0, 1, 9 );
			ac = new AddonComponent( 10642 );
			ac.Hue = 2406;
			AddComponent( ac, 0, 1, 1 );
			ac = new AddonComponent( 13592 );
			AddComponent( ac, 1, -1, 3 );
			ac = new AddonComponent( 10642 );
			ac.Hue = 2406;
			AddComponent( ac, 1, -1, 9 );
			ac = new AddonComponent( 10642 );
			ac.Hue = 2406;
			AddComponent( ac, 1, -1, 10 );
			ac = new AddonComponent( 10642 );
			ac.Hue = 2406;
			AddComponent( ac, 1, -1, 1 );
			ac = new AddonComponent( 10642 );
			ac.Hue = 2406;
			AddComponent( ac, 1, 1, 12 );
			ac = new AddonComponent( 10651 );
			ac.Hue = 2406;
			AddComponent( ac, 1, 1, 1 );
			ac = new AddonComponent( 2000 );
			ac.Hue = 2406;
			AddComponent( ac, 1, 1, 16 );
			ac = new AddonComponent( 2000 );
			ac.Hue = 2406;
			AddComponent( ac, 1, 0, 16 );
			ac = new AddonComponent( 10642 );
			ac.Hue = 2406;
			AddComponent( ac, 1, -1, 1 );
			ac = new AddonComponent( 10642 );
			ac.Hue = 2406;
			AddComponent( ac, 1, 1, 5 );
			ac = new AddonComponent( 10642 );
			ac.Hue = 2406;
			AddComponent( ac, 1, 1, 9 );
			ac = new AddonComponent( 10642 );
			ac.Hue = 2406;
			AddComponent( ac, 1, 1, 6 );
			ac = new AddonComponent( 10642 );
			ac.Hue = 2406;
			AddComponent( ac, 1, 1, 3 );
			ac = new AddonComponent( 10642 );
			ac.Hue = 2406;
			AddComponent( ac, 1, 1, 1 );
			ac = new AddonComponent( 10642 );
			ac.Hue = 2406;
			AddComponent( ac, 0, 1, 3 );
			ac = new AddonComponent( 10642 );
			ac.Hue = 2406;
			AddComponent( ac, 1, -1, 3 );
			ac = new AddonComponent( 10642 );
			ac.Hue = 2406;
			AddComponent( ac, 1, -1, 4 );
			ac = new AddonComponent( 10642 );
			ac.Hue = 2406;
			AddComponent( ac, 0, 1, 1 );
			ac = new AddonComponent( 10643 );
			ac.Hue = 2406;
			AddComponent( ac, 1, -1, 0 );
		}

		public MediumFishTankDarkwoodEastAddon( Serial serial ) : base( serial )
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

	public class MediumFishTankDarkwoodEastAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new MediumFishTankDarkwoodEastAddon();
			}
		}

		[Constructable]
		public MediumFishTankDarkwoodEastAddonDeed()
		{
			Name = "A Medium Dark Wood FishTank Deed (East)";
			Weight = 50;
		}

		public MediumFishTankDarkwoodEastAddonDeed( Serial serial ) : base( serial )
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