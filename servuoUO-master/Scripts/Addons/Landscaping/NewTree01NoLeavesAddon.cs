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
	public class NewTree01NoLeavesAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new NewTree01NoLeavesAddonDeed();
			}
		}

		[ Constructable ]
		public NewTree01NoLeavesAddon()
		{
			AddonComponent ac = null;
			ac = new AddonComponent( 12481 );
			AddComponent( ac, 2, 0, 0 );
			ac = new AddonComponent( 12480 );
			AddComponent( ac, -1, 1, 0 );
			ac = new AddonComponent( 12479 );
			AddComponent( ac, 0, 1, 0 );
			ac = new AddonComponent( 12478 );
			AddComponent( ac, 1, 1, 0 );
			ac = new AddonComponent( 12477 );
			AddComponent( ac, 2, 1, 0 );

		}

		public NewTree01NoLeavesAddon( Serial serial ) : base( serial )
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

	public class NewTree01NoLeavesAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new NewTree01NoLeavesAddon();
			}
		}

		[Constructable]
		public NewTree01NoLeavesAddonDeed()
		{
			Name = "NewTree01NoLeaves";
		}

		public NewTree01NoLeavesAddonDeed( Serial serial ) : base( serial )
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