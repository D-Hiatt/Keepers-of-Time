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
	public class RedMapleTree1bAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new RedMapleTree1bAddonDeed();
			}
		}

		[ Constructable ]
		public RedMapleTree1bAddon()
		{
			AddonComponent ac = null;
			ac = new AddonComponent( 9341 );
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 9337 );
			AddComponent( ac, 0, 0, 0 );

		}

		public RedMapleTree1bAddon( Serial serial ) : base( serial )
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

	public class RedMapleTree1bAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new RedMapleTree1bAddon();
			}
		}

		[Constructable]
		public RedMapleTree1bAddonDeed()
		{
			Name = "RedMapleTree1b";
		}

		public RedMapleTree1bAddonDeed( Serial serial ) : base( serial )
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