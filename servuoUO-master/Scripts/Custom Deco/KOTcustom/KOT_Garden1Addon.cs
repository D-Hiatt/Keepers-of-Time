
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
	public class KOT_Garden1Addon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {2141, 4, -4, 0}, {2141, 3, -4, 0}, {2141, 2, -4, 0}// 1	2	3	
			, {2141, 1, -4, 0}, {2141, 0, -4, 0}, {2141, -1, -4, 0}// 4	5	6	
			, {2141, -2, -4, 0}, {2140, 4, 5, 1}, {3164, 2, 2, 1}// 7	8	9	
			, {3183, 4, 3, 1}, {12790, -1, 5, 1}, {15640, -2, 3, 1}// 10	11	12	
			, {15640, -2, 1, 1}, {15640, -2, -2, 1}, {3183, 4, 5, 1}// 13	14	15	
			, {3183, 4, 4, 1}, {3197, -2, 5, 1}, {3197, -2, 4, 1}// 16	17	18	
			, {2142, -3, 3, 0}, {3197, -2, 2, 1}, {12790, -1, 4, 1}// 19	20	21	
			, {12790, 0, -3, 1}, {12790, 0, -2, 1}, {3197, -2, -3, 1}// 22	23	24	
			, {2142, -3, 4, 0}, {12790, 3, 3, 1}, {12790, 3, 2, 1}// 25	26	27	
			, {12790, 3, 1, 1}, {12790, 3, 0, 1}, {12790, 0, -1, 1}// 28	29	30	
			, {3190, 0, 0, 1}, {12790, 0, 1, 1}, {12790, 0, 2, 1}// 31	32	33	
			, {12790, 3, -1, 1}, {12790, 3, -2, 1}, {12790, 3, -3, 1}// 34	35	36	
			, {12790, 2, 5, 1}, {12790, 2, 4, 1}, {12790, 2, 3, 1}// 37	38	39	
			, {12790, 2, 2, 1}, {12790, 0, 3, 1}, {12790, 0, 4, 1}// 40	41	42	
			, {12790, -1, 3, 1}, {12790, 0, 5, 1}, {12791, 0, 0, 1}// 43	44	45	
			, {3190, 0, 1, 1}, {12790, 1, -3, 1}, {12790, 1, -2, 1}// 46	47	48	
			, {12790, 1, -1, 1}, {12790, 1, 0, 1}, {12790, 1, 1, 1}// 49	50	51	
			, {12790, 1, 2, 1}, {12790, 1, 3, 1}, {12790, 1, 4, 1}// 52	53	54	
			, {12790, 1, 5, 1}, {12790, 2, -3, 1}, {12790, 2, -2, 1}// 55	56	57	
			, {12790, 2, 1, 1}, {12790, 2, -1, 1}, {12790, 2, 0, 1}// 58	59	60	
			, {3190, 0, 4, 1}, {3190, 0, 5, 1}, {3190, 0, 2, 1}// 61	62	63	
			, {3190, 0, 3, 1}, {3197, -2, 0, 1}, {3197, -2, -1, 1}// 64	65	66	
			, {12790, -1, 2, 1}, {12790, -1, 1, 1}, {12790, -1, 0, 1}// 67	68	69	
			, {12790, -1, -1, 1}, {12790, -1, -2, 1}, {12790, -1, -3, 1}// 70	71	72	
			, {12790, -2, 5, 1}, {12790, -2, 4, 1}, {12790, -2, 3, 1}// 73	74	75	
			, {12790, -2, 2, 1}, {12790, -2, 1, 1}, {12790, -2, 0, 1}// 76	77	78	
			, {12790, -2, -1, 1}, {12790, -2, -2, 1}, {12790, -2, -3, 1}// 79	80	81	
			, {12790, 3, 4, 1}, {12790, 3, 5, 1}, {12790, 4, -3, 1}// 82	83	84	
			, {12790, 4, -2, 1}, {12790, 4, -1, 1}, {12790, 4, 0, 1}// 85	86	87	
			, {12790, 4, 1, 1}, {12790, 4, 2, 1}, {12790, 4, 3, 1}// 88	89	90	
			, {12790, 4, 4, 1}, {12790, 4, 5, 1}, {3183, 4, 2, 1}// 91	92	93	
			, {3183, 4, 1, 1}, {3183, 4, 0, 1}, {3183, 4, -1, 1}// 94	95	96	
			, {3183, 4, -2, 1}, {3183, 4, -3, 1}, {3177, -1, -3, 1}// 97	98	99	
			, {3177, -1, -2, 1}, {3177, -1, -1, 1}, {3177, -1, 0, 1}// 100	101	102	
			, {3177, -1, 1, 1}, {3177, -1, 2, 1}, {3177, -1, 3, 1}// 103	104	105	
			, {3177, -1, 4, 1}, {3177, -1, 5, 1}, {3341, 3, 1, 1}// 106	107	108	
			, {3347, 3, 5, 1}, {3345, 3, 4, 1}, {3341, 3, 3, 1}// 109	110	111	
			, {3347, 3, 2, 1}, {3343, 3, 1, 1}, {3347, 3, -3, 1}// 112	113	114	
			, {3348, 3, -2, 1}, {3348, 3, 0, 1}, {3345, 3, -1, 1}// 115	116	117	
			, {3190, 0, -1, 1}, {5378, 0, -3, 1}, {5379, 0, -2, 1}// 118	119	120	
			, {3186, 2, -2, 1}, {3186, 2, 4, 1}, {3186, 1, 5, 1}// 129	130	131	
			, {3186, 1, 0, 1}, {3186, 1, -3, 1}, {3164, 2, 5, 1}// 132	133	134	
			, {3164, 2, -1, 1}, {3164, 1, -2, 1}, {3164, 2, -3, 1}// 135	136	137	
			, {3178, 2, 4, 1}, {3178, 2, 1, 1}, {3178, 1, -2, 1}// 138	139	140	
			, {7732, 1, 1, 3}, {2141, 3, 5, 1}, {2141, 2, 5, 1}// 141	142	143	
			, {2141, 1, 5, 1}, {2141, 0, 5, 1}, {2141, -1, 5, 1}// 144	145	146	
			, {2141, -2, 5, 1}, {2142, -3, 5, 0}, {2142, -3, 2, 0}// 147	148	149	
			, {2142, -3, 1, 0}, {2142, -3, 0, 0}, {2142, -3, -1, 0}// 150	151	152	
			, {2142, -3, -2, 0}, {2142, -3, -3, 0}, {2142, 4, 4, 1}// 153	154	155	
			, {2142, 4, -3, 1}, {2142, 4, -2, 1}, {2142, 4, 3, 1}// 156	157	158	
			, {2142, 4, 2, 1}, {2142, 4, -1, 2}, {2143, 4, 1, 1}// 159	160	161	
					};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new KOT_Garden1AddonDeed();
			}
		}

		[ Constructable ]
		public KOT_Garden1Addon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 7951, 2, -3, 1, 72, -1, "", 1);// 121
			AddComplexComponent( (BaseAddon) this, 7950, 2, -2, 1, 72, -1, "", 1);// 122
			AddComplexComponent( (BaseAddon) this, 7949, 2, -1, 1, 72, -1, "", 1);// 123
			AddComplexComponent( (BaseAddon) this, 3380, 2, 1, 1, 72, -1, "", 1);// 124
			AddComplexComponent( (BaseAddon) this, 7951, 2, 3, 1, 72, -1, "", 1);// 125
			AddComplexComponent( (BaseAddon) this, 3380, 2, 4, 1, 72, -1, "", 1);// 126
			AddComplexComponent( (BaseAddon) this, 7952, 2, -2, 1, 72, -1, "", 1);// 127
			AddComplexComponent( (BaseAddon) this, 7949, 1, -1, 1, 72, -1, "", 1);// 128

		}

		public KOT_Garden1Addon( Serial serial ) : base( serial )
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

	public class KOT_Garden1AddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new KOT_Garden1Addon();
			}
		}

		[Constructable]
		public KOT_Garden1AddonDeed()
		{
			Name = "KOT_Garden1";
		}

		public KOT_Garden1AddonDeed( Serial serial ) : base( serial )
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