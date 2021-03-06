
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
	public class KOT_FlowerCartHorseSouthAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {7950, 0, -1, 7}, {3220, 0, -1, 9}, {3203, 1, 0, 13}// 3	4	5	
			, {3204, 0, 0, 10}, {3210, 1, -1, 13}, {3206, 0, 1, 12}// 6	8	10	
			, {3208, 0, 1, 12}, {3206, 1, 1, 13}, {3208, 1, 1, 13}// 11	12	13	
			, {4973, 2, 1, 12}, {3219, 1, -2, 0}, {3219, 2, 0, 12}// 17	18	19	
			, {3252, 1, 1, 4}// 20	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new KOT_FlowerCartHorseSouthAddonDeed();
			}
		}

		[ Constructable ]
		public KOT_FlowerCartHorseSouthAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 10266, 0, -1, 0, 537, -1, "", 1);// 1
			AddComplexComponent( (BaseAddon) this, 4117, -1, -1, 0, 0, -1, "wagon wheel", 1);// 2
			AddComplexComponent( (BaseAddon) this, 4117, 1, -1, 0, 0, -1, "wagon wheel", 1);// 7
			AddComplexComponent( (BaseAddon) this, 10266, 0, 0, 0, 637, -1, "", 1);// 9
			AddComplexComponent( (BaseAddon) this, 5112, 0, 2, 0, 0, -1, "Strap", 1);// 14
			AddComplexComponent( (BaseAddon) this, 5112, -1, 2, 0, 0, -1, "strap", 1);// 15
			AddComplexComponent( (BaseAddon) this, 10296, 1, -1, 16, 0, -1, "butterfly", 1);// 16
			AddComplexComponent( (BaseAddon) this, 16382, 0, 3, 4, 1175, -1, "Royal Steed", 1);// 21

		}

		public KOT_FlowerCartHorseSouthAddon( Serial serial ) : base( serial )
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

	public class KOT_FlowerCartHorseSouthAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new KOT_FlowerCartHorseSouthAddon();
			}
		}

		[Constructable]
		public KOT_FlowerCartHorseSouthAddonDeed()
		{
			Name = "KOT_FlowerCartHorseSouth";
		}

		public KOT_FlowerCartHorseSouthAddonDeed( Serial serial ) : base( serial )
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