
////////////////////////////////////////
//                                     //
//   Generated by CEO's YAAAG - Ver 2  //
// (Yet Another Arya Addon Generator)  //
//    Modified by Hammerhand for       //
//      SA & High Seas content         //
//                                     //
////////////////////////////////////////
using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class KOT_StoveAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {280, 0, -1, 5}, {2534, 1, 0, 11}// 5	11	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new KOT_StoveAddonDeed();
			}
		}

		[ Constructable ]
		public KOT_StoveAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 9229, 1, 1, 2, 2373, -1, "", 1);// 1
			AddComplexComponent( (BaseAddon) this, 7027, 1, 0, 10, 902, -1, "stove burner", 1);// 2
			AddComplexComponent( (BaseAddon) this, 9231, 0, 1, 0, 2373, -1, "", 1);// 3
			AddComplexComponent( (BaseAddon) this, 7027, 0, 0, 10, 902, -1, "stove burner", 1);// 4
			AddComplexComponent( (BaseAddon) this, 280, 1, -1, 5, 1153, -1, "", 1);// 6
			AddComplexComponent( (BaseAddon) this, 271, 0, -1, 9, 1175, -1, "", 1);// 7
			AddComplexComponent( (BaseAddon) this, 271, 1, -1, 9, 1175, -1, "", 1);// 8
			AddComplexComponent( (BaseAddon) this, 1801, 0, 0, 5, 1153, -1, "", 1);// 9
			AddComplexComponent( (BaseAddon) this, 1801, 1, 0, 5, 1153, -1, "", 1);// 10
			AddComplexComponent( (BaseAddon) this, 4000, 1, 0, 17, 2096, -1, "clock", 1);// 12

		}

		public KOT_StoveAddon( Serial serial ) : base( serial )
		{
		}

        private static void AddComplexComponent(BaseAddon addon, int item, int xoffset, int yoffset, int zoffset, int hue, int lightsource)
        {
            AddComplexComponent(addon, item, xoffset, yoffset, zoffset, hue, lightsource, null, 1);
        }

        private static void AddComplexComponent(BaseAddon addon, int item, int xoffset, int yoffset, int zoffset, int hue, int lightsource, string name, int amount)
        {
            AddonComponent ac;
            ac = new AddonComponent(item);
            if (name != null && name.Length > 0)
                ac.Name = name;
            if (hue != 0)
                ac.Hue = hue;
            if (amount > 1)
            {
                ac.Stackable = true;
                ac.Amount = amount;
            }
            if (lightsource != -1)
                ac.Light = (LightType) lightsource;
            addon.AddComponent(ac, xoffset, yoffset, zoffset);
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

	public class KOT_StoveAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new KOT_StoveAddon();
			}
		}

		[Constructable]
		public KOT_StoveAddonDeed()
		{
			Name = "KOT_Stove";
		}

		public KOT_StoveAddonDeed( Serial serial ) : base( serial )
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