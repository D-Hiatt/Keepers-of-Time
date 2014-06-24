/////////////////////////////////////////////////
//
// Automatically generated by the
// AddonGenerator script by Arya
//
/////////////////////////////////////////////////
using System;
using Server;
using Server.Items;

namespace server.items
{
	public class LoveBedAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new LoveBedAddonDeed();
			}
		}

		[ Constructable ]
		public LoveBedAddon()
		{
			AddonComponent ac = null;
			ac = new AddonComponent( 5992 );
			ac.Hue = 137;
			AddComponent( ac, 2, 0, 1 );
			ac = new AddonComponent( 5992 );
			ac.Hue = 137;
			AddComponent( ac, 2, 1, 2 );
			ac = new AddonComponent( 3530 );
			ac.Hue = 1175;
			AddComponent( ac, 0, 0, 4 );
			ac = new AddonComponent( 3530 );
			ac.Hue = 1175;
			AddComponent( ac, 0, -1, 4 );
			ac = new AddonComponent( 3530 );
			ac.Hue = 1175;
			AddComponent( ac, -1, -1, 4 );
			ac = new AddonComponent( 3530 );
			ac.Hue = 1175;
			AddComponent( ac, -1, 0, 4 );
			ac = new AddonComponent( 5992 );
			ac.Hue = 137;
			AddComponent( ac, 2, -1, 2 );
			ac = new AddonComponent( 5992 );
			ac.Hue = 137;
			AddComponent( ac, 2, -1, 1 );
			ac = new AddonComponent( 5992 );
			ac.Hue = 137;
			AddComponent( ac, -1, 0, 2 );
			ac = new AddonComponent( 5992 );
			ac.Hue = 137;
			AddComponent( ac, 0, 0, 1 );
			ac = new AddonComponent( 5029 );
			ac.Hue = 1157;
			AddComponent( ac, -1, -1, 4 );
			ac = new AddonComponent( 3530 );
			ac.Hue = 1175;
			AddComponent( ac, -1, 2, 4 );
			ac = new AddonComponent( 3530 );
			ac.Hue = 1175;
			AddComponent( ac, 0, 2, 4 );
			ac = new AddonComponent( 3530 );
			ac.Hue = 1175;
			AddComponent( ac, 1, 2, 4 );
			ac = new AddonComponent( 3530 );
			ac.Hue = 1175;
			AddComponent( ac, 2, 2, 4 );
			ac = new AddonComponent( 5992 );
			ac.Hue = 137;
			AddComponent( ac, 1, 2, 2 );
			ac = new AddonComponent( 5992 );
			ac.Hue = 137;
			AddComponent( ac, 2, 2, 2 );
			ac = new AddonComponent( 5992 );
			ac.Hue = 137;
			AddComponent( ac, 2, 2, 1 );
			ac = new AddonComponent( 5992 );
			ac.Hue = 137;
			AddComponent( ac, 1, 2, 1 );
			ac = new AddonComponent( 5992 );
			ac.Hue = 137;
			AddComponent( ac, 1, 2, 1 );
			ac = new AddonComponent( 5992 );
			ac.Hue = 137;
			AddComponent( ac, 0, 2, 2 );
			ac = new AddonComponent( 5992 );
			ac.Hue = 137;
			AddComponent( ac, 0, 2, 1 );
			ac = new AddonComponent( 5992 );
			ac.Hue = 1175;
			AddComponent( ac, 0, 2, 0 );
			ac = new AddonComponent( 5992 );
			ac.Hue = 137;
			AddComponent( ac, -1, 2, 2 );
			ac = new AddonComponent( 5992 );
			ac.Hue = 137;
			AddComponent( ac, -1, 2, 1 );
			ac = new AddonComponent( 5992 );
			ac.Hue = 1175;
			AddComponent( ac, -1, 2, 0 );
			ac = new AddonComponent( 5992 );
			ac.Hue = 1175;
			AddComponent( ac, 0, 2, 0 );
			ac = new AddonComponent( 5992 );
			ac.Hue = 1175;
			AddComponent( ac, 1, 2, 0 );
			ac = new AddonComponent( 5992 );
			ac.Hue = 1175;
			AddComponent( ac, 2, 2, 0 );
			ac = new AddonComponent( 5035 );
			ac.Hue = 1157;
			AddComponent( ac, 1, -1, 4 );
			ac = new AddonComponent( 5034 );
			ac.Hue = 1157;
			AddComponent( ac, 2, -1, 3 );
			ac = new AddonComponent( 5030 );
			ac.Hue = 1157;
			AddComponent( ac, 0, -1, 4 );
			ac = new AddonComponent( 3530 );
			ac.Hue = 1175;
			AddComponent( ac, 2, 1, 4 );
			ac = new AddonComponent( 3530 );
			ac.Hue = 1175;
			AddComponent( ac, 2, 0, 4 );
			ac = new AddonComponent( 3530 );
			ac.Hue = 1175;
			AddComponent( ac, 2, -1, 3 );
			ac = new AddonComponent( 3530 );
			ac.Hue = 1175;
			AddComponent( ac, 1, -1, 4 );
			ac = new AddonComponent( 3530 );
			ac.Hue = 1175;
			AddComponent( ac, 1, 0, 4 );
			ac = new AddonComponent( 3530 );
			ac.Hue = 1175;
			AddComponent( ac, 1, 1, 4 );
			ac = new AddonComponent( 3530 );
			ac.Hue = 1175;
			AddComponent( ac, 0, 1, 4 );
			ac = new AddonComponent( 3530 );
			ac.Hue = 1175;
			AddComponent( ac, -1, 1, 4 );
			ac = new AddonComponent( 5992 );
			ac.Hue = 137;
			AddComponent( ac, 2, 0, 2 );
			ac = new AddonComponent( 5992 );
			ac.Hue = 137;
			AddComponent( ac, 2, 1, 1 );
			ac = new AddonComponent( 5992 );
			ac.Hue = 137;
			AddComponent( ac, 1, 1, 2 );
			ac = new AddonComponent( 5992 );
			ac.Hue = 137;
			AddComponent( ac, 1, 1, 1 );
			ac = new AddonComponent( 5992 );
			ac.Hue = 137;
			AddComponent( ac, 1, 0, 2 );
			ac = new AddonComponent( 5992 );
			ac.Hue = 137;
			AddComponent( ac, 1, 0, 1 );
			ac = new AddonComponent( 5992 );
			ac.Hue = 137;
			AddComponent( ac, 1, -1, 2 );
			ac = new AddonComponent( 5992 );
			ac.Hue = 137;
			AddComponent( ac, 1, -1, 1 );
			ac = new AddonComponent( 5992 );
			ac.Hue = 137;
			AddComponent( ac, -1, -1, 2 );
			ac = new AddonComponent( 5992 );
			ac.Hue = 137;
			AddComponent( ac, -1, 1, 2 );
			ac = new AddonComponent( 5992 );
			ac.Hue = 137;
			AddComponent( ac, 0, 1, 2 );
			ac = new AddonComponent( 5992 );
			ac.Hue = 137;
			AddComponent( ac, 0, 1, 1 );
			ac = new AddonComponent( 5992 );
			ac.Hue = 137;
			AddComponent( ac, 0, 0, 2 );
			ac = new AddonComponent( 5992 );
			ac.Hue = 137;
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 5992 );
			ac.Hue = 137;
			AddComponent( ac, 0, -1, 2 );
			ac = new AddonComponent( 5992 );
			ac.Hue = 137;
			AddComponent( ac, 0, -1, 1 );
			ac = new AddonComponent( 5992 );
			ac.Hue = 137;
			AddComponent( ac, -1, -1, 1 );
			ac = new AddonComponent( 5992 );
			ac.Hue = 137;
			AddComponent( ac, -1, 0, 1 );
			ac = new AddonComponent( 5992 );
			ac.Hue = 137;
			AddComponent( ac, -1, 1, 1 );
			ac = new AddonComponent( 5992 );
			ac.Hue = 1175;
			AddComponent( ac, 2, 1, 0 );
			ac = new AddonComponent( 5992 );
			ac.Hue = 137;
			AddComponent( ac, 1, 1, 0 );
			ac = new AddonComponent( 5992 );
			ac.Hue = 1175;
			AddComponent( ac, 2, 0, 0 );
			ac = new AddonComponent( 5992 );
			ac.Hue = 137;
			AddComponent( ac, 1, 0, 0 );
			ac = new AddonComponent( 5992 );
			ac.Hue = 1175;
			AddComponent( ac, 2, -1, 0 );
			ac = new AddonComponent( 5992 );
			ac.Hue = 137;
			AddComponent( ac, 1, -1, 0 );
			ac = new AddonComponent( 5992 );
			ac.Hue = 137;
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 5992 );
			ac.Hue = 137;
			AddComponent( ac, 0, 1, 0 );
			ac = new AddonComponent( 5992 );
			ac.Hue = 137;
			AddComponent( ac, -1, 1, 0 );
			ac = new AddonComponent( 5992 );
			ac.Hue = 137;
			AddComponent( ac, -1, 0, 0 );
			ac = new AddonComponent( 5992 );
			ac.Hue = 137;
			AddComponent( ac, 0, -1, 0 );
			ac = new AddonComponent( 5992 );
			ac.Hue = 137;
			AddComponent( ac, -1, -1, 0 );
			ac = new AddonComponent( 4632 );
			ac.Hue = 1109;
			AddComponent( ac, -1, -1, 0 );
			ac = new AddonComponent( 4632 );
			ac.Hue = 1109;
			AddComponent( ac, 0, -1, 0 );
			ac = new AddonComponent( 4632 );
			ac.Hue = 1109;
			AddComponent( ac, 1, -1, 0 );
			ac = new AddonComponent( 4632 );
			ac.Hue = 1109;
			AddComponent( ac, 2, -1, 0 );

		}

		public LoveBedAddon( Serial serial ) : base( serial )
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

	public class LoveBedAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new LoveBedAddon();
			}
		}

		[Constructable]
		public LoveBedAddonDeed()
		{
			Name = "LoveBed";
		}

		public LoveBedAddonDeed( Serial serial ) : base( serial )
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