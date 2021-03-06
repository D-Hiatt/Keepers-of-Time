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
	public class BoulderRock08Addon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new BoulderRock08AddonDeed();
			}
		}

		[ Constructable ]
		public BoulderRock08Addon()
		{
			AddonComponent ac = null;
			ac = new AddonComponent( 4961 );
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 4962 );
			AddComponent( ac, 1, 0, 0 );

		}

		public BoulderRock08Addon( Serial serial ) : base( serial )
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

	public class BoulderRock08AddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new BoulderRock08Addon();
			}
		}

		[Constructable]
		public BoulderRock08AddonDeed()
		{
			Name = "BoulderRock08";
		}

		public BoulderRock08AddonDeed( Serial serial ) : base( serial )
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