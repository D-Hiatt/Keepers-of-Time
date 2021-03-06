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
	public class DarkMarbleSnowleopardStatueAddon : BaseAddon
	{
		public override BaseAddonDeed Deed{ get{ return new DarkMarbleSnowleopardStatueAddonDeed(); } }

		public override bool RetainDeedHue{ get{ return true; } }

		[Constructable]
		public DarkMarbleSnowleopardStatueAddon() : this( 0 )
		{
		}

		[ Constructable ]
		public DarkMarbleSnowleopardStatueAddon( int hue )
		{
			AddonComponent ac;
			ac = new AddonComponent( 9635 );
			ac.Hue = hue;
			ac.Name = "Marble Snow Leopard Statue";
			AddComponent( ac, 0, 0, 11 );
			ac = new AddonComponent( 4643 );
			ac.Hue = 2406;
			ac.Name = "Marble Statue Pedestal";
			AddComponent( ac, 0, 0, 0 );
		}

		public DarkMarbleSnowleopardStatueAddon( Serial serial ) : base( serial )
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

	public class DarkMarbleSnowleopardStatueAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon { get{ return new DarkMarbleSnowleopardStatueAddon( this.Hue ); } }

		[Constructable]
		public DarkMarbleSnowleopardStatueAddonDeed()
		{
			Name = "Marble Snow Leopard Statue (Dark Pedestal)";
		}

		public DarkMarbleSnowleopardStatueAddonDeed( Serial serial ) : base( serial )
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