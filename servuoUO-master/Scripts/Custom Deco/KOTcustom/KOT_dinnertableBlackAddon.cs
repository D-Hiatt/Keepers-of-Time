
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
	public class KOT_dinnertableBlackAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {2451, -2, 0, 6}, {2931, -1, -1, 0}, {2931, -2, -1, 0}// 3	5	6	
			, {2929, 2, 1, 0}, {2930, 2, -1, 0}, {2932, 1, 1, 0}// 8	9	10	
			, {2931, 2, 0, 0}, {2931, 1, 0, 0}, {2931, 1, -1, 0}// 11	12	13	
			, {2931, 0, -1, 0}, {2931, 0, 0, 0}, {2520, -2, -1, 6}// 14	15	16	
			, {5626, 2, 0, 6}, {2520, 2, 1, 6}, {5627, 1, 0, 6}// 18	19	20	
			, {2520, 1, 1, 6}, {2931, -2, 0, 0}, {2932, 0, 1, 0}// 21	23	24	
			, {2932, -1, 1, 0}, {2931, -1, 0, 0}, {2494, -1, -1, 6}// 25	26	27	
			, {2516, 0, 1, 6}, {2494, 0, -1, 6}, {2494, 1, -1, 6}// 28	31	32	
			, {2494, 2, -1, 6}, {2516, -2, 1, 6}, {2516, -1, 1, 6}// 33	34	35	
			, {2520, 0, -1, 6}, {2520, 1, -1, 6}, {2516, 1, 1, 6}// 38	40	43	
			, {2520, 0, 1, 6}, {2520, -1, 1, 6}, {2520, -2, 1, 6}// 44	45	46	
			, {2520, -1, -1, 6}, {2520, 2, -1, 6}, {2516, 2, 1, 6}// 47	51	52	
			, {2928, -2, 1, 0}, {2494, -2, -1, 6}, {5625, -1, 0, 6}// 53	54	55	
					};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new KOT_dinnertableBlackAddonDeed();
			}
		}

		[ Constructable ]
		public KOT_dinnertableBlackAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 2896, 0, 2, 0, 1, -1, "", 1);// 1
			AddComplexComponent( (BaseAddon) this, 2896, -1, 2, 0, 1, -1, "", 1);// 2
			AddComplexComponent( (BaseAddon) this, 2895, 0, -2, 0, 1, -1, "", 1);// 4
			AddComplexComponent( (BaseAddon) this, 2896, -2, 2, 0, 1, -1, "", 1);// 7
			AddComplexComponent( (BaseAddon) this, 2845, 0, 0, 8, 0, 1, "", 1);// 17
			AddComplexComponent( (BaseAddon) this, 2895, 1, -2, 0, 1, -1, "", 1);// 22
			AddComplexComponent( (BaseAddon) this, 2896, 2, 2, 0, 1, -1, "", 1);// 29
			AddComplexComponent( (BaseAddon) this, 2896, 1, 2, 0, 1, -1, "", 1);// 30
			AddComplexComponent( (BaseAddon) this, 2760, -1, 0, 6, 1, -1, "", 1);// 36
			AddComplexComponent( (BaseAddon) this, 2760, -2, 0, 6, 1, -1, "", 1);// 37
			AddComplexComponent( (BaseAddon) this, 2895, -1, -2, 0, 1, -1, "", 1);// 39
			AddComplexComponent( (BaseAddon) this, 2895, 2, -2, 0, 1, -1, "", 1);// 41
			AddComplexComponent( (BaseAddon) this, 2895, -2, -2, 0, 1, -1, "", 1);// 42
			AddComplexComponent( (BaseAddon) this, 2760, 0, 0, 6, 1, -1, "", 1);// 48
			AddComplexComponent( (BaseAddon) this, 2760, 1, 0, 6, 1, -1, "", 1);// 49
			AddComplexComponent( (BaseAddon) this, 2760, 2, 0, 6, 1, -1, "", 1);// 50

		}

		public KOT_dinnertableBlackAddon( Serial serial ) : base( serial )
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

	public class KOT_dinnertableBlackAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new KOT_dinnertableBlackAddon();
			}
		}

		[Constructable]
		public KOT_dinnertableBlackAddonDeed()
		{
			Name = "KOT_dinnertableBlack";
		}

		public KOT_dinnertableBlackAddonDeed( Serial serial ) : base( serial )
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