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
	public class OrangeBlossomTreeAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new OrangeBlossomTreeAddonDeed();
			}
		}

		[ Constructable ]
		public OrangeBlossomTreeAddon()
		{
			AddonComponent ac = null;
			ac = new AddonComponent( 3280 );
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 3265 );
			AddComponent( ac, -1, 1, 25 );
			ac = new AddonComponent( 3265 );
			AddComponent( ac, 1, -1, 27 );
			ac = new AddonComponent( 3265 );
			AddComponent( ac, 1, 1, 45 );
			ac = new AddonComponent( 3265 );
			AddComponent( ac, 0, 1, 36 );
			ac = new AddonComponent( 3265 );
			AddComponent( ac, 1, 0, 36 );
			ac = new AddonComponent( 3265 );
			AddComponent( ac, 0, 1, 25 );
			ac = new AddonComponent( 3265 );
			AddComponent( ac, 1, 0, 25 );
			ac = new AddonComponent( 3265 );
			AddComponent( ac, 1, 1, 36 );
			ac = new AddonComponent( 3264 );
			AddComponent( ac, 1, -1, 21 );
			ac = new AddonComponent( 3264 );
			AddComponent( ac, -1, 1, 13 );
			ac = new AddonComponent( 3264 );
			AddComponent( ac, 1, 0, 20 );

		}

		public OrangeBlossomTreeAddon( Serial serial ) : base( serial )
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

	public class OrangeBlossomTreeAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new OrangeBlossomTreeAddon();
			}
		}

		[Constructable]
		public OrangeBlossomTreeAddonDeed()
		{
			Name = "OrangeBlossomTree";
		}

		public OrangeBlossomTreeAddonDeed( Serial serial ) : base( serial )
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