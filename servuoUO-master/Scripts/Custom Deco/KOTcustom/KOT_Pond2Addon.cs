
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
	public class KOT_Pond2Addon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {1250, -3, -3, 0}, {1250, -3, -2, 0}, {1250, -3, -1, 0}// 1	2	3	
			, {1250, -3, 0, 0}, {1250, -3, 1, 0}, {1250, -3, 2, 0}// 4	5	6	
			, {1250, -3, 3, 0}, {1250, -3, 4, 0}, {1250, -2, -3, 0}// 7	8	9	
			, {1250, -2, -2, 0}, {1250, -2, -1, 0}, {1250, -2, 0, 0}// 10	11	12	
			, {1250, -2, 1, 0}, {1250, -2, 2, 0}, {1250, -2, 3, 0}// 13	14	15	
			, {1250, -2, 4, 0}, {1250, -1, -3, 0}, {1250, -1, -2, 0}// 16	17	18	
			, {1250, -1, -1, 0}, {1250, -1, 0, 0}, {1250, -1, 1, 0}// 19	20	21	
			, {1250, -1, 2, 0}, {1250, -1, 3, 0}, {1250, -1, 4, 0}// 22	23	24	
			, {1250, 0, -3, 0}, {1250, 0, -2, 0}, {1250, 0, -1, 0}// 25	26	27	
			, {1250, 0, 0, 0}, {1250, 0, 1, 0}, {1250, 0, 2, 0}// 28	29	30	
			, {1250, 0, 3, 0}, {1250, 0, 4, 0}, {1250, 1, -3, 0}// 31	32	33	
			, {1250, 1, -2, 0}, {1250, 1, -1, 0}, {1250, 1, 0, 0}// 34	35	36	
			, {1250, 1, 1, 0}, {1250, 1, 2, 0}, {1250, 1, 3, 0}// 37	38	39	
			, {1250, 1, 4, 0}, {1250, 2, -3, 0}, {1250, 2, -2, 0}// 40	41	42	
			, {1250, 2, -1, 0}, {1250, 2, 0, 0}, {1250, 2, 1, 0}// 43	44	45	
			, {1250, 2, 2, 0}, {1250, 2, 4, 0}, {1250, 3, -2, 0}// 46	47	48	
			, {1250, 3, -1, 0}, {1250, 3, 0, 0}, {1250, 3, 1, 0}// 49	50	51	
			, {1250, 3, 2, 0}, {1250, 3, 4, 0}, {13583, -2, -1, 0}// 52	53	54	
			, {13583, -1, -1, 0}, {13351, -2, 3, 2}, {13428, -2, 0, 0}// 55	56	57	
			, {13428, -2, 1, 0}, {13428, -2, 2, 0}, {13428, -1, 0, 0}// 58	59	60	
			, {13428, -1, 1, 0}, {13428, -1, 2, 0}, {13428, 0, 1, 0}// 61	62	63	
			, {13428, 0, 2, 0}, {13428, -2, 3, 0}, {13428, -1, 3, 0}// 64	65	66	
			, {13428, 0, 3, 0}, {13428, 1, 0, 0}, {13428, 1, 1, 0}// 67	68	69	
			, {13428, 1, 2, 0}, {13428, 1, 3, 0}, {13428, 2, 0, 0}// 70	71	72	
			, {13428, 2, 1, 0}, {13428, 2, 2, 0}, {13428, -3, 3, 0}// 73	74	75	
			, {13428, -3, 2, 0}, {3255, -3, 2, 1}, {3254, -2, 3, 1}// 76	77	78	
			, {3254, 1, 0, 3}, {3339, 1, 2, 3}, {13553, 3, 3, 1}// 79	80	81	
			, {13553, 3, 2, 1}, {13553, 3, 1, 1}, {6013, 3, 4, 0}// 82	83	84	
			, {6013, 2, 4, 0}, {6013, 1, 4, 0}, {6013, 0, 4, 0}// 85	86	87	
			, {6013, -1, 4, 0}, {6013, -2, 4, 0}, {6013, -3, 4, 0}// 88	89	90	
			, {6013, -3, 1, 0}, {6013, -3, 0, 0}, {6013, -3, -1, 0}// 91	92	93	
			, {6013, -3, -2, 0}, {6013, -3, -3, 0}, {6013, -2, -3, 0}// 94	95	96	
			, {6013, -1, -3, 0}, {6013, -1, -2, 0}, {6013, -1, -1, 0}// 97	98	99	
			, {6013, 0, -1, 0}, {6013, 0, 0, 0}, {6013, 0, -2, 0}// 100	101	102	
			, {6013, 0, -3, 0}, {6013, 1, -3, 0}, {6013, 1, -2, 0}// 103	104	105	
			, {6013, 1, -2, 0}, {6013, 1, -1, 0}, {6013, 2, -1, 0}// 106	107	108	
			, {6013, 2, -3, 0}, {6013, 2, -2, 0}, {6013, 3, -2, 0}// 109	110	111	
			, {6013, 3, -1, 0}, {6013, 3, 0, 0}, {3521, -2, 2, 1}// 112	113	114	
			, {3203, 0, 0, 0}, {6811, -3, 1, 0}, {3235, 3, 0, 1}// 115	116	117	
			, {3148, 0, 2, 1}, {6818, 1, 3, 1}, {7951, -1, 3, 3}// 118	119	120	
			, {3267, 2, 0, 3}, {3268, -3, 0, 0}, {3237, 0, -1, 0}// 121	122	123	
			, {3206, 1, -1, 0}, {3167, 2, 1, 2}, {13422, 2, 0, 0}// 124	125	126	
			, {13422, 2, 1, 0}, {13422, 2, 2, 0}, {13422, 3, 0, 0}// 127	128	129	
			, {13422, 3, 1, 0}, {13422, 3, 2, 0}, {13422, 3, 3, 0}// 130	131	132	
			, {13422, 4, 0, 0}, {13422, 4, 1, 0}, {13422, 4, 2, 0}// 133	134	135	
			, {13422, 4, 3, 0}, {13422, 2, 3, 0}, {7949, 5, 0, 2}// 136	137	138	
			, {3211, 3, -1, 0}, {3369, 4, 1, 1}, {2339, 1, 0, 3}// 139	140	141	
			, {3204, -1, 4, 0}, {3204, 5, -1, 0}, {3204, -3, -1, 0}// 142	143	144	
			, {3204, 0, -2, 0}, {3338, 5, 4, 5}, {82, -2, 4, 0}// 145	146	147	
			, {83, -3, 4, 0}, {86, -4, 4, 0}, {86, -4, 3, 0}// 148	149	150	
			, {86, -4, 2, 0}, {86, -4, 1, 0}, {86, -4, 0, 0}// 151	152	153	
			, {86, -4, -1, 0}, {80, -3, -2, 0}, {13422, -3, 4, 0}// 154	155	156	
			, {13422, -2, 4, 0}, {4619, 0, 4, 0}, {82, 5, 4, 0}// 157	158	159	
			, {83, 4, 4, 0}, {84, 5, 3, 0}, {84, 5, 2, 0}// 160	161	162	
			, {84, 5, 1, 0}, {84, 5, 0, 0}, {84, 3, 4, 0}// 163	164	165	
			, {3239, -3, -2, 0}, {3204, 3, 4, 0}, {4617, 1, 4, 0}// 166	167	168	
			, {4618, 2, 4, 0}, {3232, 4, -1, 0}, {6811, 4, -1, 0}// 169	170	171	
			, {3259, 1, -2, 0}, {1955, -1, -2, 0}, {1955, -2, -2, 0}// 172	173	174	
			, {6868, -2, -2, 5}, {3208, -2, -2, 5}, {13422, 4, 4, 0}// 177	178	179	
			, {13422, 5, 4, 0}, {13422, 5, 3, 0}, {13422, 5, 2, 0}// 180	181	182	
			, {13422, 5, 1, 0}, {13422, 5, 0, 0}, {3223, 2, -2, 0}// 183	184	185	
			, {3223, 2, -2, 5}, {3223, 3, -2, 0}, {3268, 4, -2, 0}// 186	189	192	
			, {3205, -1, 1, 6}, {3371, 5, 2, 1}, {3232, 5, -2, 0}// 193	194	195	
					};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new KOT_Pond2AddonDeed();
			}
		}

		[ Constructable ]
		public KOT_Pond2Addon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 11535, -1, -2, 5, 21, -1, "", 1);// 175
			AddComplexComponent( (BaseAddon) this, 2594, -1, -1, 25, 17, 29, "", 1);// 176
			AddComplexComponent( (BaseAddon) this, 3577, 2, -2, 10, 53, -1, "", 2);// 187
			AddComplexComponent( (BaseAddon) this, 2519, 2, -2, 11, 543, -1, "", 1);// 188
			AddComplexComponent( (BaseAddon) this, 3577, 3, -2, 5, 53, -1, "", 2);// 190
			AddComplexComponent( (BaseAddon) this, 2519, 3, -2, 6, 543, -1, "", 1);// 191

		}

		public KOT_Pond2Addon( Serial serial ) : base( serial )
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

	public class KOT_Pond2AddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new KOT_Pond2Addon();
			}
		}

		[Constructable]
		public KOT_Pond2AddonDeed()
		{
			Name = "KOT_Pond2";
		}

		public KOT_Pond2AddonDeed( Serial serial ) : base( serial )
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