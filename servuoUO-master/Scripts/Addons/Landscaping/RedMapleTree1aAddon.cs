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
	public class RedMapleTree1aAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new RedMapleTree1aAddonDeed();
			}
		}

		[ Constructable ]
		public RedMapleTree1aAddon()
		{
			AddonComponent ac = null;
			ac = new AddonComponent( 9341 );
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 9336 );
			AddComponent( ac, 0, 0, 0 );

		}

		public RedMapleTree1aAddon( Serial serial ) : base( serial )
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

	public class RedMapleTree1aAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new RedMapleTree1aAddon();
			}
		}

		[Constructable]
		public RedMapleTree1aAddonDeed()
		{
			Name = "RedMapleTree1a";
		}

		public RedMapleTree1aAddonDeed( Serial serial ) : base( serial )
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