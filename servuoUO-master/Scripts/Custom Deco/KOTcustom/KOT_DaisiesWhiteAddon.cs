
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
	public class KOT_DaisiesWhiteAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {4551, 1, 1, 1}, {3332, 1, 1, 4}, {3219, 1, 1, 4}// 1	2	3	
			, {4179, 1, 1, 4}, {4179, 1, 1, 4}// 6	7	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new KOT_DaisiesWhiteAddonDeed();
			}
		}

		[ Constructable ]
		public KOT_DaisiesWhiteAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 4179, 1, 1, 8, 1153, -1, "daisies", 1);// 4
			AddComplexComponent( (BaseAddon) this, 4179, 1, 0, 0, 1153, -1, "daisies", 1);// 5
			AddComplexComponent( (BaseAddon) this, 4179, 1, 1, 4, 1153, -1, "daisies", 1);// 8
			AddComplexComponent( (BaseAddon) this, 4179, 0, 1, 1, 1153, -1, "daisies", 1);// 9
			AddComplexComponent( (BaseAddon) this, 3371, 1, 1, 6, 1153, -1, "", 1);// 10
			AddComplexComponent( (BaseAddon) this, 3371, 1, 0, 1, 1153, -1, "", 1);// 11
			AddComplexComponent( (BaseAddon) this, 3371, 0, 1, 1, 1153, -1, "", 1);// 12
			AddComplexComponent( (BaseAddon) this, 3371, 0, 0, 1, 1153, -1, "", 1);// 13
			AddComplexComponent( (BaseAddon) this, 3371, 1, 1, 4, 1153, -1, "", 1);// 14

		}

		public KOT_DaisiesWhiteAddon( Serial serial ) : base( serial )
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

	public class KOT_DaisiesWhiteAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new KOT_DaisiesWhiteAddon();
			}
		}

		[Constructable]
		public KOT_DaisiesWhiteAddonDeed()
		{
			Name = "KOT_DaisiesWhite";
		}

		public KOT_DaisiesWhiteAddonDeed( Serial serial ) : base( serial )
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