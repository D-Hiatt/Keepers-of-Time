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
	public class NewTree02NoLeavesAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new NewTree02NoLeavesAddonDeed();
			}
		}

		[ Constructable ]
		public NewTree02NoLeavesAddon()
		{
			AddonComponent ac = null;
			ac = new AddonComponent( 12487 );
			AddComponent( ac, 1, -1, 0 );
			ac = new AddonComponent( 12486 );
			AddComponent( ac, 1, 0, 0 );
			ac = new AddonComponent( 12484 );
			AddComponent( ac, 0, 1, 0 );
			ac = new AddonComponent( 12483 );
			AddComponent( ac, 1, 1, 0 );

		}

		public NewTree02NoLeavesAddon( Serial serial ) : base( serial )
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

	public class NewTree02NoLeavesAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new NewTree02NoLeavesAddon();
			}
		}

		[Constructable]
		public NewTree02NoLeavesAddonDeed()
		{
			Name = "NewTree02NoLeaves";
		}

		public NewTree02NoLeavesAddonDeed( Serial serial ) : base( serial )
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