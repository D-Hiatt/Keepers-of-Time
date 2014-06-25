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
	public class MLTree10Addon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new MLTree10AddonDeed();
			}
		}

		[ Constructable ]
		public MLTree10Addon()
		{
			AddonComponent ac = null;
			ac = new AddonComponent( 14850 );
			AddComponent( ac, 2, -1, 0 );
			ac = new AddonComponent( 14849 );
			AddComponent( ac, 1, 0, 0 );
			ac = new AddonComponent( 14848 );
			AddComponent( ac, 0, 1, 0 );
			ac = new AddonComponent( 14847 );
			AddComponent( ac, -1, 2, 0 );

		}

		public MLTree10Addon( Serial serial ) : base( serial )
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

	public class MLTree10AddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new MLTree10Addon();
			}
		}

		[Constructable]
		public MLTree10AddonDeed()
		{
			Name = "MLTree10";
		}

		public MLTree10AddonDeed( Serial serial ) : base( serial )
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