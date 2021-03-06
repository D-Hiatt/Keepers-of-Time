/////////////////////////////////////////////////
//                                             //
// Automatically generated by the              //
// AddonGenerator script by Arya               //
//                                             //
/////////////////////////////////////////////////
using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class SerenityWallSouthAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new SerenityWallSouthAddonDeed();
			}
		}

		[ Constructable ]
		public SerenityWallSouthAddon()
		{
			AddComponent( new AddonComponent( 2835 ), 1, 0, 0 );
			AddComponent( new AddonComponent( 13591 ), 1, 0, 9 );
			AddComponent( new AddonComponent( 925 ), 1, 0, 19 );
			AddComponent( new AddonComponent( 2834 ), 0, 1, 0 );
			AddComponent( new AddonComponent( 2833 ), 1, 1, 0 );
			AddComponent( new AddonComponent( 6039 ), 1, 1, 9 );
			AddComponent( new AddonComponent( 13488 ), 1, 1, 9 );

		}

		public SerenityWallSouthAddon( Serial serial ) : base( serial )
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

	public class SerenityWallSouthAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new SerenityWallSouthAddon();
			}
		}

		[Constructable]
		public SerenityWallSouthAddonDeed()
		{
			Name = "SerenityWallSouth";
		}

		public SerenityWallSouthAddonDeed( Serial serial ) : base( serial )
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