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
	public class BoulderRock04Addon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new BoulderRock04AddonDeed();
			}
		}

		[ Constructable ]
		public BoulderRock04Addon()
		{
			AddonComponent ac = null;
			ac = new AddonComponent( 4951 );
			AddComponent( ac, 0, 1, 0 );
			ac = new AddonComponent( 4952 );
			AddComponent( ac, 1, 1, 0 );
			ac = new AddonComponent( 4953 );
			AddComponent( ac, 1, 0, 0 );

		}

		public BoulderRock04Addon( Serial serial ) : base( serial )
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

	public class BoulderRock04AddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new BoulderRock04Addon();
			}
		}

		[Constructable]
		public BoulderRock04AddonDeed()
		{
			Name = "BoulderRock04";
		}

		public BoulderRock04AddonDeed( Serial serial ) : base( serial )
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