
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
	public class Stable10x17Addon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {8663, -3, -8, 0}, {8663, -4, -8, 0}, {12789, -4, -6, 1}// 1	2	3	
			, {4976, 0, -4, 1}, {12789, 0, -3, 1}, {12789, 0, -4, 1}// 4	5	6	
			, {12789, 0, -5, 1}, {12789, 0, -6, 1}, {12789, -1, -3, 1}// 7	8	9	
			, {12789, -1, -4, 1}, {12789, -1, -5, 1}, {12789, -1, -6, 1}// 10	11	12	
			, {12789, -2, -3, 1}, {12789, -2, -4, 1}, {12789, -2, -5, 1}// 13	14	15	
			, {12789, -2, -6, 1}, {12789, -3, -3, 1}, {12789, -3, -4, 1}// 16	17	18	
			, {12789, -3, -5, 1}, {12789, -3, -6, 1}, {12789, -4, -5, 1}// 19	20	21	
			, {12789, -4, -4, 1}, {12789, -4, -3, 1}, {8663, -1, -8, 0}// 22	23	24	
			, {8663, -2, -8, 0}, {12789, 1, -6, 1}, {12789, 1, -5, 1}// 25	26	27	
			, {12789, 1, -4, 1}, {12789, 1, -3, 1}, {12789, 2, -6, 1}// 28	29	30	
			, {12789, 2, -5, 1}, {12789, 2, -4, 1}, {12789, 2, -3, 1}// 31	32	33	
			, {12789, 3, -6, 1}, {12789, 3, -5, 1}, {12789, 3, -4, 1}// 34	35	36	
			, {12789, 3, -3, 1}, {12789, 4, -6, 1}, {12789, 4, -5, 1}// 37	38	39	
			, {12789, 4, -4, 1}, {12789, 4, -3, 1}, {12789, -4, -7, 1}// 40	41	42	
			, {3899, -1, -6, 1}, {12789, -3, -7, 1}, {12789, -2, -7, 1}// 43	44	45	
			, {12789, -1, -7, 1}, {12789, 0, -7, 1}, {8663, 0, -8, 0}// 46	47	48	
			, {8663, 1, -8, 0}, {12789, 1, -7, 1}, {8663, 2, -8, 0}// 49	50	51	
			, {8663, 3, -8, 0}, {8663, 4, -8, 0}, {12789, 2, -7, 1}// 52	53	54	
			, {12789, 3, -7, 1}, {8662, -5, -3, 1}, {12789, 4, -7, 1}// 55	56	57	
			, {8662, -5, -4, 1}, {8662, -5, -5, 1}, {8662, -5, -6, 1}// 58	59	60	
			, {8662, -5, -7, 1}, {184, 0, -7, 1}, {184, 0, -6, 1}// 61	62	63	
			, {2881, -4, -7, 1}, {184, 0, -5, 1}, {2882, -4, -6, 1}// 64	65	66	
			, {3895, 3, -7, 1}, {3895, -2, -7, 1}, {5193, 2, -4, 1}// 67	68	69	
			, {5193, -3, -3, 1}, {3893, 2, -3, 1}, {4108, -1, -7, 1}// 70	71	72	
			, {4108, 1, -7, 1}, {4980, -1, -4, 1}, {4981, 3, -6, 1}// 73	74	75	
			, {4151, -2, -5, 1}, {4151, 2, -5, 1}, {4151, -2, -3, 1}// 76	77	78	
			, {3707, -4, -3, 1}, {5453, -4, -4, 1}, {2141, -2, 9, 1}// 79	80	81	
			, {2141, -3, 9, 1}, {6868, -4, 8, 21}, {2141, -4, 9, 1}// 82	83	84	
			, {3210, 4, 3, 1}, {4150, 2, 5, 1}, {2141, 4, 9, 1}// 85	86	87	
			, {12789, -4, -2, 1}, {12789, -4, -1, 1}, {4151, 1, 7, 1}// 88	89	90	
			, {6803, -4, 0, 1}, {6804, -4, 1, 1}, {12789, 0, 6, 1}// 91	92	93	
			, {12789, 0, 5, 1}, {12789, 0, 4, 1}, {12789, 0, 3, 1}// 94	95	96	
			, {12789, 0, 2, 1}, {12789, 0, 1, 1}, {12789, 0, 0, 1}// 97	98	99	
			, {12789, 0, -1, 1}, {12789, 0, -2, 1}, {12789, -1, 9, 1}// 100	101	102	
			, {12789, -1, 8, 1}, {12789, -1, 7, 1}, {12789, -1, 6, 1}// 103	104	105	
			, {12789, -1, 5, 1}, {12789, -1, 4, 1}, {12789, -1, 3, 1}// 106	107	108	
			, {12789, -1, 2, 1}, {12789, -1, 1, 1}, {12789, -1, 0, 1}// 109	110	111	
			, {12789, -1, -1, 1}, {12789, -1, -2, 1}, {12789, -2, 9, 1}// 112	113	114	
			, {12789, -2, 8, 1}, {12789, -2, 7, 1}, {12789, -2, 6, 1}// 115	116	117	
			, {12789, -2, 5, 1}, {12789, -2, 4, 1}, {12789, -2, 3, 1}// 118	119	120	
			, {12789, -2, 2, 1}, {12789, -2, 1, 1}, {12789, -2, 0, 1}// 121	122	123	
			, {12789, -2, -1, 1}, {12789, -2, -2, 1}, {12789, -3, 9, 1}// 124	125	126	
			, {12789, -3, 8, 1}, {12789, -3, 7, 1}, {12789, -3, 6, 1}// 127	128	129	
			, {12789, -3, 5, 1}, {12789, -3, 4, 1}, {12789, -3, 3, 1}// 130	131	132	
			, {12789, -3, 2, 1}, {12789, -3, 1, 1}, {12789, -3, 0, 1}// 133	134	135	
			, {12789, -3, -1, 1}, {12789, -3, -2, 1}, {12789, 0, 7, 1}// 136	137	138	
			, {12789, -4, 9, 1}, {12789, -4, 8, 1}, {12789, -4, 7, 1}// 139	140	141	
			, {12789, -4, 6, 1}, {12789, -4, 5, 1}, {12789, -4, 4, 1}// 142	143	144	
			, {12789, -4, 3, 1}, {12789, -4, 2, 1}, {12789, -4, 1, 1}// 145	146	147	
			, {12789, -4, 0, 1}, {8663, -3, 2, 1}, {3899, -4, -2, 1}// 148	149	150	
			, {12789, 0, 8, 1}, {12789, 0, 9, 1}, {12789, 1, -2, 1}// 151	152	153	
			, {12789, 1, -1, 1}, {12789, 1, 0, 1}, {12789, 1, 1, 1}// 154	155	156	
			, {12789, 1, 2, 1}, {12789, 1, 3, 1}, {12789, 1, 4, 1}// 157	158	159	
			, {12789, 1, 5, 1}, {12789, 1, 6, 1}, {12789, 1, 7, 1}// 160	161	162	
			, {12789, 1, 8, 1}, {12789, 1, 9, 1}, {12789, 2, -2, 1}// 163	164	165	
			, {12789, 2, -1, 1}, {12789, 2, 0, 1}, {12789, 2, 1, 1}// 166	167	168	
			, {12789, 2, 2, 1}, {12789, 2, 3, 1}, {12789, 2, 4, 1}// 169	170	171	
			, {12789, 2, 5, 1}, {12789, 2, 6, 1}, {12789, 2, 7, 1}// 172	173	174	
			, {12789, 2, 8, 1}, {12789, 2, 9, 1}, {12789, 3, -2, 1}// 175	176	177	
			, {12789, 3, -1, 1}, {12789, 3, 0, 1}, {12789, 3, 1, 1}// 178	179	180	
			, {12789, 3, 2, 1}, {12789, 3, 3, 1}, {12789, 3, 4, 1}// 181	182	183	
			, {12789, 3, 5, 1}, {12789, 3, 6, 1}, {12789, 3, 7, 1}// 184	185	186	
			, {12789, 3, 8, 1}, {12789, 3, 9, 1}, {12789, 4, -2, 1}// 187	188	189	
			, {12789, 4, -1, 1}, {12789, 4, 0, 1}, {12789, 4, 1, 1}// 190	191	192	
			, {12789, 4, 2, 1}, {12789, 4, 3, 1}, {12789, 4, 4, 1}// 193	194	195	
			, {12789, 4, 5, 1}, {12789, 4, 6, 1}, {12789, 4, 7, 1}// 196	197	198	
			, {12789, 4, 8, 1}, {12789, 4, 9, 1}, {2142, -5, 9, 0}// 199	200	201	
			, {2142, -5, 8, 0}, {2142, -5, 7, 0}, {2142, -5, 6, 0}// 202	203	204	
			, {2142, -5, 5, 0}, {2142, -5, 3, 0}, {2142, -5, 4, 0}// 205	206	207	
			, {3899, 3, 0, 1}, {3893, 1, 3, 1}, {3892, 4, 8, 1}// 208	209	210	
			, {8663, 4, 2, 1}, {3892, -2, 4, 1}, {8663, -4, 2, 1}// 211	212	213	
			, {8662, -5, 2, 1}, {8662, -5, 1, 1}, {8662, -5, 0, 1}// 214	215	216	
			, {8662, -5, -1, 1}, {8662, -5, -2, 1}, {2141, 3, 9, 1}// 217	218	219	
			, {2143, 2, 9, 1}, {5193, -1, 0, 1}, {5193, -4, 4, 1}// 220	221	222	
			, {5193, 3, 4, 1}, {3899, -2, 6, 1}, {3893, 0, 5, 1}// 223	224	225	
			, {3893, 1, 5, 1}, {3893, -3, 7, 1}, {3893, -1, 7, 1}// 226	227	228	
			, {3893, 0, 4, 1}, {3893, -2, -1, 1}, {3893, 2, -1, 1}// 229	230	231	
			, {3893, 1, 0, 1}, {3893, 3, 6, 1}, {3895, -3, 3, 1}// 232	233	234	
			, {4980, 1, 6, 1}, {4151, 0, -2, 1}, {4151, -2, 2, 1}// 235	236	237	
			, {4151, -1, 2, 1}, {4151, 1, 2, 1}, {4151, 3, -2, 1}// 238	239	240	
			, {4151, -3, 5, 1}, {4151, 2, 7, 1}, {4151, -1, 9, 1}// 241	242	243	
			, {4151, 1, 9, 1}, {3514, 0, 7, 1}, {12789, 5, -6, 1}// 244	245	246	
			, {12789, 5, -5, 1}, {12789, 5, -4, 1}, {12789, 5, -3, 1}// 247	248	249	
			, {8661, 5, -3, 1}, {8661, 5, -4, 1}, {8661, 5, -5, 1}// 250	251	252	
			, {8663, 5, -8, 0}, {8661, 5, -7, 0}, {8661, 5, -6, 1}// 253	254	255	
			, {12789, 5, -7, 1}, {2142, 5, 3, 1}, {2142, 5, 4, 1}// 256	257	258	
			, {2142, 5, 5, 1}, {2142, 5, 6, 1}, {2142, 5, 7, 1}// 259	260	261	
			, {2142, 5, 8, 1}, {2140, 5, 9, 1}, {12789, 5, -2, 1}// 262	263	264	
			, {12789, 5, -1, 1}, {12789, 5, 0, 1}, {12789, 5, 1, 1}// 265	266	267	
			, {12789, 5, 2, 1}, {12789, 5, 3, 1}, {12789, 5, 4, 1}// 268	269	270	
			, {12789, 5, 5, 1}, {12789, 5, 6, 1}, {12789, 5, 7, 1}// 271	272	273	
			, {12789, 5, 8, 1}, {12789, 5, 9, 1}, {166, 5, 2, 1}// 274	275	276	
			, {8661, 5, 1, 1}, {8661, 5, 0, 1}, {8661, 5, -1, 1}// 277	278	279	
			, {8661, 5, -2, 1}// 280	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new Stable10x17AddonDeed();
			}
		}

		[ Constructable ]
		public Stable10x17Addon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


		}

		public Stable10x17Addon( Serial serial ) : base( serial )
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

	public class Stable10x17AddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new Stable10x17Addon();
			}
		}

		[Constructable]
		public Stable10x17AddonDeed()
		{
			Name = "Stable10x17";
		}

		public Stable10x17AddonDeed( Serial serial ) : base( serial )
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