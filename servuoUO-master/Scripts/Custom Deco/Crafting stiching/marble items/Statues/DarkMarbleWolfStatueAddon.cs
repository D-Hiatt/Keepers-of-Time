/////////////////////////////////////////////////
//                                             //
// Automatically generated by the              //
// AddonGenerator script by Arya,              //
// modified for coloring by Manu               //
// Splitterwelt.com                            //
// german roleplay freeshard                   //
//                                             //
/////////////////////////////////////////////////
using System;
using Server;

namespace Server.Items
{
	public class DarkMarbleWolfStatueAddon : BaseAddon
	{
		public override BaseAddonDeed Deed{ get{ return new DarkMarbleWolfStatueAddonDeed(); } }

		public override bool RetainDeedHue{ get{ return true; } }

		[Constructable]
		public DarkMarbleWolfStatueAddon() : this( 0 )
		{
		}

		[ Constructable ]
		public DarkMarbleWolfStatueAddon( int hue )
		{
			AddonComponent ac;
			ac = new AddonComponent( 8482 );
			ac.Hue = hue;
			ac.Name = "Marble Wolf Statue";
			AddComponent( ac, 0, 0, 10 );
			ac = new AddonComponent( 4643 );
			ac.Hue = 2406;
			ac.Name = "Marble Statue Pedestal";
			AddComponent( ac, 0, 0, 0 );
		}

		public DarkMarbleWolfStatueAddon( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 1 ); // Version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();
		}
	}

	public class DarkMarbleWolfStatueAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon { get{ return new DarkMarbleWolfStatueAddon( this.Hue ); } }

		[Constructable]
		public DarkMarbleWolfStatueAddonDeed()
		{
			Name = "Marble Wolf Statue (Dark Pedestal)";
		}

		public DarkMarbleWolfStatueAddonDeed( Serial serial ) : base( serial )
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