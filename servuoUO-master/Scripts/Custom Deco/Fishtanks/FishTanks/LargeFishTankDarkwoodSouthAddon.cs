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
	public class LargeFishTankDarkwoodSouthAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new LargeFishTankDarkwoodSouthAddonDeed();
			}
		}

		[ Constructable ]
		public LargeFishTankDarkwoodSouthAddon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 3543 );
			AddComponent( ac, 1, 1, 7 );
			ac = new AddonComponent( 13410 );
			ac.Name = "Sand";
			ac.Hue = 345;
			AddComponent( ac, 1, 1, 6 );
			ac = new AddonComponent( 13592 );
			AddComponent( ac, 1, 0, 3 );
			ac = new AddonComponent( 13562 );
			AddComponent( ac, -1, 1, 3 );
			ac = new AddonComponent( 10642 );
			ac.Hue = 2406;
			AddComponent( ac, -1, 1, 6 );
			ac = new AddonComponent( 10642 );
			ac.Hue = 2406;
			AddComponent( ac, -1, 1, 11 );
			ac = new AddonComponent( 10642 );
			ac.Hue = 2406;
			AddComponent( ac, -1, 1, 9 );
			ac = new AddonComponent( 10642 );
			ac.Hue = 2406;
			AddComponent( ac, -1, 1, 3 );
			ac = new AddonComponent( 10642 );
			ac.Hue = 2406;
			AddComponent( ac, -1, 1, 2 );
			ac = new AddonComponent( 4044 );
			AddComponent( ac, 0, 1, 7 );
			ac = new AddonComponent( 3254 );
			AddComponent( ac, 0, 1, 8 );
			ac = new AddonComponent( 13410 );
			ac.Name = "Sand";
			ac.Hue = 345;
			AddComponent( ac, 0, 1, 6 );
			ac = new AddonComponent( 10648 );
			ac.Hue = 2406;
			AddComponent( ac, 0, 1, 1 );
			ac = new AddonComponent( 10642 );
			ac.Hue = 2406;
			AddComponent( ac, 2, 1, 12 );
			ac = new AddonComponent( 13410 );
			ac.Name = "Sand";
			ac.Hue = 345;
			AddComponent( ac, 2, 1, 6 );
			ac = new AddonComponent( 13592 );
			AddComponent( ac, 0, 0, 3 );
			ac = new AddonComponent( 13592 );
			AddComponent( ac, 2, 0, 3 );
			ac = new AddonComponent( 10642 );
			ac.Hue = 2406;
			AddComponent( ac, 2, 0, 9 );
			ac = new AddonComponent( 10642 );
			ac.Hue = 2406;
			AddComponent( ac, 2, 0, 10 );
			ac = new AddonComponent( 10642 );
			ac.Hue = 2406;
			AddComponent( ac, 2, 0, 1 );
			ac = new AddonComponent( 10642 );
			ac.Hue = 2406;
			AddComponent( ac, 2, 0, 3 );
			ac = new AddonComponent( 10648 );
			ac.Hue = 2406;
			AddComponent( ac, 1, 1, 1 );
			ac = new AddonComponent( 3379 );
			AddComponent( ac, 2, 1, 7 );
			ac = new AddonComponent( 10642 );
			ac.Hue = 2406;
			AddComponent( ac, 2, 1, 12 );
			ac = new AddonComponent( 10651 );
			ac.Hue = 2406;
			AddComponent( ac, 2, 1, 1 );
			ac = new AddonComponent( 2000 );
			ac.Hue = 2406;
			AddComponent( ac, 2, 1, 16 );
			ac = new AddonComponent( 2000 );
			ac.Hue = 2406;
			AddComponent( ac, 1, 1, 16 );
			ac = new AddonComponent( 2000 );
			ac.Hue = 2406;
			AddComponent( ac, 0, 1, 16 );
			ac = new AddonComponent( 10643 );
			ac.Hue = 2406;
			AddComponent( ac, -1, 1, 1 );
			ac = new AddonComponent( 10642 );
			ac.Hue = 2406;
			AddComponent( ac, 2, 0, 1 );
			ac = new AddonComponent( 10642 );
			ac.Hue = 2406;
			AddComponent( ac, 2, 1, 5 );
			ac = new AddonComponent( 10642 );
			ac.Hue = 2406;
			AddComponent( ac, 2, 1, 9 );
			ac = new AddonComponent( 10642 );
			ac.Hue = 2406;
			AddComponent( ac, 2, 1, 3 );
			ac = new AddonComponent( 10642 );
			ac.Hue = 2406;
			AddComponent( ac, 2, 1, 1 );
			ac = new AddonComponent( 10642 );
			ac.Hue = 2406;
			AddComponent( ac, -1, 1, 3 );
			ac = new AddonComponent( 10642 );
			ac.Hue = 2406;
			AddComponent( ac, -1, 1, 2 );
			ac = new AddonComponent( 10642 );
			ac.Hue = 2406;
			AddComponent( ac, 2, 0, 3 );
			ac = new AddonComponent( 10642 );
			ac.Hue = 2406;
			AddComponent( ac, 2, 0, 4 );
			ac = new AddonComponent( 10642 );
			ac.Hue = 2406;
			AddComponent( ac, -1, 1, 0 );
			ac = new AddonComponent( 10643 );
			ac.Hue = 2406;
			AddComponent( ac, 2, 0, 0 );

		}

		public LargeFishTankDarkwoodSouthAddon( Serial serial ) : base( serial )
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

	public class LargeFishTankDarkwoodSouthAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new LargeFishTankDarkwoodSouthAddon();
			}
		}

		[Constructable]
		public LargeFishTankDarkwoodSouthAddonDeed()
		{
			Name = "A Large Dark Wood FishTank Deed (South)";
		}

		public LargeFishTankDarkwoodSouthAddonDeed( Serial serial ) : base( serial )
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