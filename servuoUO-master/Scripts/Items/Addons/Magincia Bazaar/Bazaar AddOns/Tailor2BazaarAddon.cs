
////////////////////////////////////////
//                                    //
//   Generated by CEO's YAAAG - V1.2  //
// (Yet Another Arya Addon Generator) //
//                                    //
////////////////////////////////////////
using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class Tailor2BazaarAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {10351, -1, -1, 2}, {10351, -1, 0, 2}, {10351, -1, 1, 2}// 1	2	3	
			, {10351, -1, 2, 2}, {10351, 0, -1, 2}, {10351, 0, 0, 2}// 4	5	6	
			, {10351, 0, 1, 2}, {10351, 0, 2, 2}, {10351, 1, -1, 2}// 7	8	9	
			, {10351, 1, 0, 2}, {10351, 1, 1, 2}, {10351, 1, 2, 2}// 10	11	12	
			, {10351, 2, -1, 2}, {10351, 2, 0, 2}, {10351, 2, 1, 2}// 13	14	15	
			, {10351, 2, 2, 2}, {4117, 2, 1, 2}, {3997, -1, -1, 0}// 16	23	24	
			, {3999, 1, -1, 2}// 25	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new Tailor2BazaarAddonDeed();
			}
		}

		[ Constructable ]
		public Tailor2BazaarAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 3783, -1, -1, 2, 56, -1, "", 1);// 17
			AddComplexComponent( (BaseAddon) this, 3995, 0, -1, 2, 1283, -1, "", 1);// 18
			AddComplexComponent( (BaseAddon) this, 3996, 1, -1, 2, 1583, -1, "", 1);// 19
			AddComplexComponent( (BaseAddon) this, 4011, 2, -1, 2, 2588, -1, "", 1);// 20
			AddComplexComponent( (BaseAddon) this, 5989, -1, 0, 2, 2622, -1, "", 1);// 21
			AddComplexComponent( (BaseAddon) this, 5984, -1, 0, 2, 1153, -1, "", 1);// 22
			AddComplexComponent( (BaseAddon) this, 9858, -1, 2, 2, 1283, -1, "", 1);// 26
			AddComplexComponent( (BaseAddon) this, 9715, 0, 2, 0, 2622, -1, "", 1);// 27
			AddComplexComponent( (BaseAddon) this, 9854, 1, 2, 2, 1583, -1, "", 1);// 28

		}

		public Tailor2BazaarAddon( Serial serial ) : base( serial )
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

	public class Tailor2BazaarAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new Tailor2BazaarAddon();
			}
		}

		[Constructable]
		public Tailor2BazaarAddonDeed()
		{
			Name = "Tailor2Bazaar";
		}

		public Tailor2BazaarAddonDeed( Serial serial ) : base( serial )
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