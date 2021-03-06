
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
	public class KOT_LavaMoteCastleAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {13371, -18, -2, 0}, {13371, -18, -3, 0}, {13371, -18, -4, 0}// 1	12	13	
			, {13371, -18, -1, 0}, {13371, -18, 0, 0}, {13371, -18, 1, 0}// 14	15	16	
			, {13371, -18, 2, 0}, {13371, -18, 3, 0}, {13371, -18, 4, 0}// 17	18	24	
			, {13371, -18, 5, 0}, {13371, -18, 6, 0}, {13371, -18, 7, 0}// 25	26	27	
			, {7390, -10, 2, 0}, {13371, -16, -2, 0}, {13371, -17, -2, 0}// 29	30	31	
			, {13371, -16, -3, 0}, {490, -2, 1, 0}, {490, -2, 2, 0}// 32	36	37	
			, {490, -2, 3, 0}, {13371, -16, -4, 0}, {13371, -17, -3, 0}// 38	39	40	
			, {13371, -17, -4, 0}, {13371, -16, -1, 0}, {13371, -17, -1, 0}// 41	42	43	
			, {13371, -17, 0, 0}, {13371, -16, 0, 0}, {13371, -17, 3, 0}// 44	45	46	
			, {13371, -16, 3, 0}, {13371, -17, 2, 0}, {13371, -16, 2, 0}// 47	48	49	
			, {13371, -16, 1, 0}, {13371, -17, 1, 0}, {13371, -15, 1, 0}// 50	51	52	
			, {13371, -15, 0, 0}, {13371, -14, 1, 0}, {13371, -13, 1, 0}// 53	54	55	
			, {13371, -12, 1, 0}, {13371, -11, 1, 0}, {13371, -10, 1, 0}// 56	57	58	
			, {13371, -15, 2, 0}, {13371, -15, 3, 0}, {13371, -14, 3, 0}// 59	60	61	
			, {13371, -14, 2, 0}, {13371, -13, 2, 0}, {13371, -13, 3, 0}// 62	63	64	
			, {13371, -12, 3, 0}, {13371, -12, 2, 0}, {13371, -11, 2, 0}// 65	66	67	
			, {13371, -11, 3, 0}, {13371, -10, 3, 0}, {13371, -10, 2, 0}// 68	69	70	
			, {13371, -9, 1, 0}, {13371, -8, 1, 0}, {13371, -7, 1, 0}// 71	72	73	
			, {13371, -6, 1, 0}, {13371, -5, 1, 0}, {13371, -4, 1, 0}// 74	75	76	
			, {13371, -3, 1, 0}, {13371, -2, 1, 0}, {13371, -2, 2, 0}// 77	78	79	
			, {13371, -2, 3, 0}, {13371, -3, 3, 0}, {13371, -3, 2, 0}// 80	81	82	
			, {13371, -4, 2, 0}, {13371, -7, 2, 0}, {13371, -7, 3, 0}// 83	84	85	
			, {13371, -8, 3, 0}, {13371, -9, 3, 0}, {13371, -8, 2, 0}// 86	87	88	
			, {13371, -9, 2, 0}, {13371, -6, 2, 0}, {13371, -6, 3, 0}// 89	90	91	
			, {13371, -5, 3, 0}, {13371, -5, 2, 0}, {13371, -4, 3, 0}// 92	93	94	
			, {14068, -5, 3, 0}, {14068, -16, 3, 0}, {4655, -2, 1, 5}// 95	96	103	
			, {7598, -2, 1, 10}, {7573, -13, 1, 0}, {7571, -6, 1, 0}// 104	111	112	
			, {7394, -10, 2, 0}, {13371, -8, 6, 0}, {13371, -9, 6, 0}// 113	114	115	
			, {13371, -11, 6, 0}, {13371, -12, 6, 0}, {7392, -15, 5, 0}// 116	117	119	
			, {13371, -9, 4, 0}, {13371, -13, 6, 0}, {13371, -8, 7, 0}// 120	121	124	
			, {490, -2, 4, 0}, {490, -2, 5, 0}, {490, -2, 6, 0}// 139	140	141	
			, {13371, -17, 6, 0}, {13371, -17, 7, 0}, {13371, -16, 7, 0}// 143	144	145	
			, {13371, -15, 7, 0}, {13371, -15, 6, 0}, {13371, -16, 6, 0}// 146	147	148	
			, {13371, -17, 5, 0}, {13371, -16, 5, 0}, {13371, -17, 4, 0}// 149	150	151	
			, {13371, -16, 4, 0}, {13371, -15, 4, 0}, {13371, -15, 5, 0}// 152	153	154	
			, {13371, -14, 6, 0}, {13371, -14, 7, 0}, {13371, -13, 7, 0}// 155	156	157	
			, {13371, -12, 7, 0}, {13371, -11, 7, 0}, {13371, -10, 7, 0}// 158	159	160	
			, {13371, -9, 7, 0}, {13371, -10, 6, 0}, {13371, -14, 5, 0}// 161	162	163	
			, {13371, -14, 4, 0}, {13371, -13, 5, 0}, {13371, -13, 4, 0}// 164	165	166	
			, {13371, -12, 5, 0}, {13371, -12, 4, 0}, {13371, -11, 4, 0}// 167	168	169	
			, {13371, -11, 5, 0}, {13371, -10, 5, 0}, {13371, -10, 4, 0}// 170	171	172	
			, {13371, -6, 7, 0}, {13371, -3, 4, 0}, {13371, -9, 5, 0}// 173	174	175	
			, {13371, -8, 5, 0}, {13371, -7, 6, 0}, {13371, -7, 7, 0}// 176	177	178	
			, {13371, -6, 6, 0}, {13371, -2, 4, 0}, {13371, -5, 7, 0}// 179	180	181	
			, {13371, -5, 6, 0}, {13371, -5, 5, 0}, {13371, -6, 5, 0}// 182	183	184	
			, {13371, -7, 5, 0}, {13371, -7, 4, 0}, {13371, -8, 4, 0}// 185	186	187	
			, {13371, -6, 4, 0}, {13371, -5, 4, 0}, {13371, -4, 4, 0}// 188	189	190	
			, {13371, -4, 5, 0}, {13371, -4, 6, 0}, {13371, -4, 7, 0}// 191	192	193	
			, {13371, -3, 5, 0}, {13371, -3, 7, 0}, {13371, -2, 7, 0}// 194	196	197	
			, {13371, -2, 6, 0}, {13371, -2, 5, 0}, {14068, -9, 4, 0}// 198	199	200	
			, {2284, -3, 6, 0}, {4654, -2, 6, 5}, {7587, -6, 5, 0}// 205	207	208	
			, {6933, -2, 4, 5}, {6937, -4, 6, 0}, {7392, 12, 2, 0}// 209	210	211	
			, {4651, -1, 3, 5}, {7039, 8, 1, 0}, {490, 2, 1, 0}// 212	214	215	
			, {490, 2, 2, 0}, {490, 2, 3, 0}, {6921, 2, 3, 5}// 216	217	218	
			, {13371, 4, 3, 0}, {13371, 4, 2, 0}, {13371, 4, 1, 0}// 219	220	221	
			, {13371, 5, 1, 0}, {13371, 6, 1, 0}, {13371, 7, 1, 0}// 222	223	224	
			, {13371, 8, 1, 0}, {13371, 9, 1, 0}, {13371, 10, 1, 0}// 225	226	227	
			, {13371, 11, 1, 0}, {13371, 12, 1, 0}, {13371, 13, 1, 0}// 228	229	230	
			, {13371, 14, 1, 0}, {13371, 5, 2, 0}, {13371, 5, 3, 0}// 231	232	233	
			, {13371, 6, 3, 0}, {13371, 6, 2, 0}, {13371, 7, 2, 0}// 234	235	236	
			, {13371, 7, 3, 0}, {13371, 8, 3, 0}, {13371, 8, 2, 0}// 237	238	239	
			, {13371, 9, 2, 0}, {13371, 9, 3, 0}, {13371, 10, 3, 0}// 240	241	242	
			, {13371, 10, 2, 0}, {13371, 11, 3, 0}, {13371, 11, 2, 0}// 243	244	245	
			, {13371, 14, 2, 0}, {13371, 13, 2, 0}, {13371, 12, 2, 0}// 246	247	248	
			, {13371, 12, 3, 0}, {13371, 13, 3, 0}, {13371, 14, 3, 0}// 249	250	251	
			, {1848, 1, 1, 0}, {1848, 0, 1, 0}, {6661, 11, 1, 0}// 260	261	270	
			, {4653, -1, 1, 5}, {7587, -1, 2, 5}, {7367, 2, 2, 5}// 274	275	276	
			, {7573, 9, 1, 0}, {7570, 12, 1, 0}, {7404, 6, 2, 0}// 277	278	279	
			, {4651, 0, 7, 2}, {7588, 7, 5, 0}, {490, 2, 4, 0}// 284	285	291	
			, {490, 2, 5, 0}, {490, 2, 6, 0}, {4653, 2, 4, 5}// 292	293	306	
			, {13371, 4, 7, 0}, {13371, 4, 6, 0}, {13371, 4, 5, 0}// 307	308	309	
			, {13371, 4, 4, 0}, {13371, 5, 4, 0}, {13371, 5, 5, 0}// 310	311	312	
			, {13371, 5, 6, 0}, {13371, 5, 7, 0}, {13371, 6, 6, 0}// 313	314	315	
			, {13371, 6, 7, 0}, {13371, 6, 5, 0}, {13371, 6, 4, 0}// 316	317	318	
			, {13371, 7, 4, 0}, {13371, 8, 4, 0}, {13371, 9, 4, 0}// 319	320	321	
			, {13371, 10, 4, 0}, {13371, 11, 4, 0}, {13371, 14, 7, 0}// 322	323	324	
			, {13371, 13, 7, 0}, {13371, 12, 7, 0}, {13371, 11, 7, 0}// 325	326	327	
			, {13371, 10, 7, 0}, {13371, 9, 7, 0}, {13371, 8, 7, 0}// 328	329	330	
			, {13371, 7, 7, 0}, {13371, 14, 6, 0}, {13371, 13, 6, 0}// 331	332	333	
			, {13371, 12, 6, 0}, {13371, 11, 6, 0}, {13371, 10, 6, 0}// 334	335	336	
			, {13371, 9, 6, 0}, {13371, 8, 6, 0}, {13371, 7, 6, 0}// 337	338	339	
			, {13371, 7, 5, 0}, {13371, 8, 5, 0}, {13371, 9, 5, 0}// 340	341	342	
			, {13371, 10, 5, 0}, {13371, 11, 5, 0}, {13371, 12, 5, 0}// 343	344	345	
			, {13371, 13, 5, 0}, {13371, 14, 5, 0}, {13371, 12, 4, 0}// 346	347	348	
			, {13371, 13, 4, 0}, {13371, 14, 4, 0}, {14068, 9, 4, 0}// 349	350	351	
			, {4651, 1, 7, 2}, {7391, 11, 4, 0}, {7586, 11, 4, 0}// 366	367	368	
			, {6939, 2, 6, 5}, {6930, 14, 5, 0}, {13371, 15, 1, 0}// 369	370	384	
			, {13371, 16, -5, 0}, {13371, 16, -4, 0}, {13371, 16, -3, 0}// 385	386	387	
			, {13371, 16, -2, 0}, {13371, 16, -1, 0}, {13371, 17, -1, 0}// 388	389	390	
			, {13371, 17, -2, 0}, {13371, 17, -3, 0}, {13371, 17, -4, 0}// 391	392	393	
			, {13371, 17, -5, 0}, {13371, 18, -5, 0}, {13371, 18, -4, 0}// 394	395	396	
			, {13371, 18, -3, 0}, {13371, 18, -2, 0}, {13371, 18, -1, 0}// 397	398	399	
			, {13371, 19, -1, 0}, {13371, 19, -2, 0}, {13371, 19, -3, 0}// 400	401	402	
			, {13371, 19, -4, 0}, {13371, 19, -5, 0}, {13371, 19, 0, 0}// 403	404	405	
			, {13371, 18, 0, 0}, {13371, 17, 0, 0}, {13371, 16, 0, 0}// 406	407	408	
			, {13371, 19, 1, 0}, {13371, 18, 1, 0}, {13371, 17, 1, 0}// 409	410	411	
			, {13371, 16, 1, 0}, {13371, 18, 2, 0}, {13371, 19, 2, 0}// 412	413	414	
			, {13371, 19, 3, 0}, {13371, 18, 3, 0}, {13371, 17, 3, 0}// 415	416	417	
			, {13371, 17, 2, 0}, {13371, 16, 2, 0}, {13371, 15, 2, 0}// 418	419	420	
			, {13371, 15, 3, 0}, {13371, 16, 3, 0}, {14068, 17, -1, 0}// 421	422	423	
			, {13371, 19, 4, 0}, {13371, 19, 5, 0}, {13371, 19, 6, 0}// 433	434	435	
			, {13371, 19, 7, 0}, {13371, 18, 7, 0}, {13371, 17, 7, 0}// 436	437	438	
			, {13371, 16, 7, 0}, {13371, 15, 7, 0}, {13371, 18, 4, 0}// 439	440	441	
			, {13371, 18, 5, 0}, {13371, 18, 6, 0}, {13371, 17, 6, 0}// 442	443	444	
			, {13371, 16, 6, 0}, {13371, 15, 6, 0}, {13371, 15, 5, 0}// 445	446	447	
			, {13371, 16, 5, 0}, {13371, 17, 5, 0}, {13371, 17, 4, 0}// 448	449	450	
			, {13371, 15, 4, 0}, {13371, 16, 4, 0}, {14068, 16, 5, 0}// 451	452	453	
			, {6921, 15, 4, 0}// 454	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new KOT_LavaMoteCastleAddonDeed();
			}
		}

		[ Constructable ]
		public KOT_LavaMoteCastleAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 489, -18, -5, 0, 2264, -1, "", 1);// 2
			AddComplexComponent( (BaseAddon) this, 490, -19, -2, 0, 2264, -1, "", 1);// 3
			AddComplexComponent( (BaseAddon) this, 490, -19, -3, 0, 2264, -1, "", 1);// 4
			AddComplexComponent( (BaseAddon) this, 491, -19, -5, 0, 2264, -1, "", 1);// 5
			AddComplexComponent( (BaseAddon) this, 490, -19, -4, 0, 2264, -1, "", 1);// 6
			AddComplexComponent( (BaseAddon) this, 490, -19, -1, 0, 2264, -1, "", 1);// 7
			AddComplexComponent( (BaseAddon) this, 490, -19, 0, 0, 2264, -1, "", 1);// 8
			AddComplexComponent( (BaseAddon) this, 490, -19, 1, 0, 2264, -1, "", 1);// 9
			AddComplexComponent( (BaseAddon) this, 490, -19, 2, 0, 2264, -1, "", 1);// 10
			AddComplexComponent( (BaseAddon) this, 490, -19, 3, 0, 2264, -1, "", 1);// 11
			AddComplexComponent( (BaseAddon) this, 490, -19, 4, 0, 2264, -1, "", 1);// 19
			AddComplexComponent( (BaseAddon) this, 490, -19, 5, 0, 2264, -1, "", 1);// 20
			AddComplexComponent( (BaseAddon) this, 490, -19, 6, 0, 2264, -1, "", 1);// 21
			AddComplexComponent( (BaseAddon) this, 490, -19, 7, 0, 2264, -1, "", 1);// 22
			AddComplexComponent( (BaseAddon) this, 489, -18, 7, 0, 2264, -1, "", 1);// 23
			AddComplexComponent( (BaseAddon) this, 489, -16, -5, 0, 2264, -1, "", 1);// 28
			AddComplexComponent( (BaseAddon) this, 2286, -3, 3, 5, 2264, -1, "", 1);// 33
			AddComplexComponent( (BaseAddon) this, 2286, -3, 2, 5, 2264, -1, "", 1);// 34
			AddComplexComponent( (BaseAddon) this, 489, -17, -5, 0, 2264, -1, "", 1);// 35
			AddComplexComponent( (BaseAddon) this, 14101, -3, 2, 0, 0, 1, "", 1);// 97
			AddComplexComponent( (BaseAddon) this, 14101, -14, 1, 0, 0, 1, "", 1);// 98
			AddComplexComponent( (BaseAddon) this, 1848, -2, 3, 0, 1932, -1, "", 1);// 99
			AddComplexComponent( (BaseAddon) this, 1848, -2, 2, 0, 1932, -1, "", 1);// 100
			AddComplexComponent( (BaseAddon) this, 1848, -2, 1, 0, 1932, -1, "", 1);// 101
			AddComplexComponent( (BaseAddon) this, 2286, -3, 1, 5, 2264, -1, "", 1);// 102
			AddComplexComponent( (BaseAddon) this, 3703, -2, 1, 5, 2260, -1, "barrel of body parts", 1);// 105
			AddComplexComponent( (BaseAddon) this, 3821, -2, 1, 6, 1782, -1, "", 6);// 106
			AddComplexComponent( (BaseAddon) this, 3613, -2, 1, 7, 1782, -1, "blood", 1);// 107
			AddComplexComponent( (BaseAddon) this, 7407, -2, 1, 9, 1782, -1, "blood", 1);// 108
			AddComplexComponent( (BaseAddon) this, 7407, -2, 1, 8, 1782, -1, "blood", 1);// 109
			AddComplexComponent( (BaseAddon) this, 7407, -2, 1, 10, 1782, -1, "blood", 1);// 110
			AddComplexComponent( (BaseAddon) this, 2171, -2, 7, 0, 1932, -1, "", 1);// 118
			AddComplexComponent( (BaseAddon) this, 2286, -3, 5, 5, 2264, -1, "", 1);// 122
			AddComplexComponent( (BaseAddon) this, 2286, -3, 4, 5, 2264, -1, "", 1);// 123
			AddComplexComponent( (BaseAddon) this, 489, -17, 7, 0, 2264, -1, "", 1);// 125
			AddComplexComponent( (BaseAddon) this, 489, -16, 7, 0, 2264, -1, "", 1);// 126
			AddComplexComponent( (BaseAddon) this, 489, -15, 7, 0, 2264, -1, "", 1);// 127
			AddComplexComponent( (BaseAddon) this, 489, -14, 7, 0, 2264, -1, "", 1);// 128
			AddComplexComponent( (BaseAddon) this, 489, -13, 7, 0, 2264, -1, "", 1);// 129
			AddComplexComponent( (BaseAddon) this, 489, -12, 7, 0, 2264, -1, "", 1);// 130
			AddComplexComponent( (BaseAddon) this, 489, -11, 7, 0, 2264, -1, "", 1);// 131
			AddComplexComponent( (BaseAddon) this, 489, -10, 7, 0, 2264, -1, "", 1);// 132
			AddComplexComponent( (BaseAddon) this, 489, -9, 7, 0, 2264, -1, "", 1);// 133
			AddComplexComponent( (BaseAddon) this, 489, -8, 7, 0, 2264, -1, "", 1);// 134
			AddComplexComponent( (BaseAddon) this, 489, -7, 7, 0, 2264, -1, "", 1);// 135
			AddComplexComponent( (BaseAddon) this, 489, -6, 7, 0, 2264, -1, "", 1);// 136
			AddComplexComponent( (BaseAddon) this, 489, -5, 7, 0, 2264, -1, "", 1);// 137
			AddComplexComponent( (BaseAddon) this, 489, -4, 7, 0, 2264, -1, "", 1);// 138
			AddComplexComponent( (BaseAddon) this, 489, -3, 7, 0, 2264, -1, "", 1);// 142
			AddComplexComponent( (BaseAddon) this, 13371, -3, 6, 0, 2264, -1, "", 1);// 195
			AddComplexComponent( (BaseAddon) this, 1848, -2, 6, 0, 1932, -1, "", 1);// 201
			AddComplexComponent( (BaseAddon) this, 1848, -2, 5, 0, 1932, -1, "", 1);// 202
			AddComplexComponent( (BaseAddon) this, 1848, -2, 4, 0, 1932, -1, "", 1);// 203
			AddComplexComponent( (BaseAddon) this, 2284, -3, 6, 5, 2264, -1, "", 1);// 204
			AddComplexComponent( (BaseAddon) this, 2284, -3, 7, 3, 2264, -1, "", 1);// 206
			AddComplexComponent( (BaseAddon) this, 7967, 1, 1, 24, 2264, -1, "", 1);// 213
			AddComplexComponent( (BaseAddon) this, 1848, 3, 1, 0, 1932, -1, "", 1);// 252
			AddComplexComponent( (BaseAddon) this, 1848, 3, 2, 0, 1932, -1, "", 1);// 253
			AddComplexComponent( (BaseAddon) this, 1848, 3, 3, 0, 1932, -1, "", 1);// 254
			AddComplexComponent( (BaseAddon) this, 14101, 5, 2, 0, 0, 1, "", 1);// 255
			AddComplexComponent( (BaseAddon) this, 1848, 1, 3, 0, 1932, -1, "", 1);// 256
			AddComplexComponent( (BaseAddon) this, 1848, 0, 3, 0, 1932, -1, "", 1);// 257
			AddComplexComponent( (BaseAddon) this, 1848, 0, 2, 0, 1932, -1, "", 1);// 258
			AddComplexComponent( (BaseAddon) this, 1848, 1, 2, 0, 1932, -1, "", 1);// 259
			AddComplexComponent( (BaseAddon) this, 1848, -1, 3, 0, 1932, -1, "", 1);// 262
			AddComplexComponent( (BaseAddon) this, 1848, -1, 2, 0, 1932, -1, "", 1);// 263
			AddComplexComponent( (BaseAddon) this, 1848, 2, 2, 0, 1932, -1, "", 1);// 264
			AddComplexComponent( (BaseAddon) this, 1848, 2, 3, 0, 1932, -1, "", 1);// 265
			AddComplexComponent( (BaseAddon) this, 1848, 2, 1, 0, 1932, -1, "", 1);// 266
			AddComplexComponent( (BaseAddon) this, 1848, 1, 1, 0, 1932, -1, "", 1);// 267
			AddComplexComponent( (BaseAddon) this, 1848, -1, 1, 0, 1932, -1, "", 1);// 268
			AddComplexComponent( (BaseAddon) this, 1848, 0, 1, 0, 1932, -1, "", 1);// 269
			AddComplexComponent( (BaseAddon) this, 2286, 3, 1, 5, 2264, -1, "", 1);// 271
			AddComplexComponent( (BaseAddon) this, 2286, 3, 2, 5, 2264, -1, "", 1);// 272
			AddComplexComponent( (BaseAddon) this, 2286, 3, 3, 5, 2264, -1, "", 1);// 273
			AddComplexComponent( (BaseAddon) this, 489, 7, 7, 0, 2264, -1, "", 1);// 280
			AddComplexComponent( (BaseAddon) this, 2171, 0, 7, 0, 1932, -1, "", 1);// 281
			AddComplexComponent( (BaseAddon) this, 2171, 2, 7, 0, 1932, -1, "", 1);// 282
			AddComplexComponent( (BaseAddon) this, 489, 6, 7, 0, 2264, -1, "", 1);// 283
			AddComplexComponent( (BaseAddon) this, 489, 5, 7, 0, 2264, -1, "", 1);// 286
			AddComplexComponent( (BaseAddon) this, 489, 4, 7, 0, 2264, -1, "", 1);// 287
			AddComplexComponent( (BaseAddon) this, 2171, 3, 7, 0, 1932, -1, "", 1);// 288
			AddComplexComponent( (BaseAddon) this, 2171, -1, 7, 0, 1932, -1, "", 1);// 289
			AddComplexComponent( (BaseAddon) this, 2284, 3, 7, 2, 2264, -1, "", 1);// 290
			AddComplexComponent( (BaseAddon) this, 489, 8, 7, 0, 2264, -1, "", 1);// 294
			AddComplexComponent( (BaseAddon) this, 489, 9, 7, 0, 2264, -1, "", 1);// 295
			AddComplexComponent( (BaseAddon) this, 489, 10, 7, 0, 2264, -1, "", 1);// 296
			AddComplexComponent( (BaseAddon) this, 489, 11, 7, 0, 2264, -1, "", 1);// 297
			AddComplexComponent( (BaseAddon) this, 489, 12, 7, 0, 2264, -1, "", 1);// 298
			AddComplexComponent( (BaseAddon) this, 489, 13, 7, 0, 2264, -1, "", 1);// 299
			AddComplexComponent( (BaseAddon) this, 489, 14, 7, 0, 2264, -1, "", 1);// 300
			AddComplexComponent( (BaseAddon) this, 1848, 0, 5, 0, 1932, -1, "", 1);// 301
			AddComplexComponent( (BaseAddon) this, 1848, 2, 6, 0, 1932, -1, "", 1);// 302
			AddComplexComponent( (BaseAddon) this, 1848, 0, 6, 0, 1932, -1, "", 1);// 303
			AddComplexComponent( (BaseAddon) this, 1848, 1, 5, 0, 1932, -1, "", 1);// 304
			AddComplexComponent( (BaseAddon) this, 2171, 1, 7, 0, 1932, -1, "", 1);// 305
			AddComplexComponent( (BaseAddon) this, 1848, 3, 6, 0, 1932, -1, "", 1);// 352
			AddComplexComponent( (BaseAddon) this, 1848, 3, 5, 0, 1932, -1, "", 1);// 353
			AddComplexComponent( (BaseAddon) this, 1848, 3, 4, 0, 1932, -1, "", 1);// 354
			AddComplexComponent( (BaseAddon) this, 1848, 1, 6, 0, 1932, -1, "", 1);// 355
			AddComplexComponent( (BaseAddon) this, 1848, 2, 5, 0, 1932, -1, "", 1);// 356
			AddComplexComponent( (BaseAddon) this, 1848, 0, 4, 0, 1932, -1, "", 1);// 357
			AddComplexComponent( (BaseAddon) this, 1848, 1, 4, 0, 1932, -1, "", 1);// 358
			AddComplexComponent( (BaseAddon) this, 1848, -1, 4, 0, 1932, -1, "", 1);// 359
			AddComplexComponent( (BaseAddon) this, 1848, -1, 6, 0, 1932, -1, "", 1);// 360
			AddComplexComponent( (BaseAddon) this, 1848, -1, 5, 0, 1932, -1, "", 1);// 361
			AddComplexComponent( (BaseAddon) this, 1848, 2, 4, 0, 1932, -1, "", 1);// 362
			AddComplexComponent( (BaseAddon) this, 2286, 3, 4, 5, 2264, -1, "", 1);// 363
			AddComplexComponent( (BaseAddon) this, 2286, 3, 5, 5, 2264, -1, "", 1);// 364
			AddComplexComponent( (BaseAddon) this, 2284, 3, 6, 5, 2264, -1, "", 1);// 365
			AddComplexComponent( (BaseAddon) this, 489, 16, -6, 0, 2264, -1, "", 1);// 371
			AddComplexComponent( (BaseAddon) this, 489, 17, -6, 0, 2264, -1, "", 1);// 372
			AddComplexComponent( (BaseAddon) this, 489, 18, -6, 0, 2264, -1, "", 1);// 373
			AddComplexComponent( (BaseAddon) this, 489, 19, -6, 0, 2264, -1, "", 1);// 374
			AddComplexComponent( (BaseAddon) this, 490, 19, -5, 0, 2264, -1, "", 1);// 375
			AddComplexComponent( (BaseAddon) this, 490, 19, -4, 0, 2264, -1, "", 1);// 376
			AddComplexComponent( (BaseAddon) this, 490, 19, -3, 0, 2264, -1, "", 1);// 377
			AddComplexComponent( (BaseAddon) this, 490, 19, -2, 0, 2264, -1, "", 1);// 378
			AddComplexComponent( (BaseAddon) this, 490, 19, -1, 0, 2264, -1, "", 1);// 379
			AddComplexComponent( (BaseAddon) this, 490, 19, 0, 0, 2264, -1, "", 1);// 380
			AddComplexComponent( (BaseAddon) this, 490, 19, 1, 0, 2264, -1, "", 1);// 381
			AddComplexComponent( (BaseAddon) this, 490, 19, 2, 0, 2264, -1, "", 1);// 382
			AddComplexComponent( (BaseAddon) this, 490, 19, 3, 0, 2264, -1, "", 1);// 383
			AddComplexComponent( (BaseAddon) this, 14101, 15, 1, 0, 0, 1, "", 1);// 424
			AddComplexComponent( (BaseAddon) this, 490, 19, 6, 0, 2264, -1, "", 1);// 425
			AddComplexComponent( (BaseAddon) this, 488, 19, 7, 0, 2264, -1, "", 1);// 426
			AddComplexComponent( (BaseAddon) this, 489, 15, 7, 0, 2264, -1, "", 1);// 427
			AddComplexComponent( (BaseAddon) this, 489, 16, 7, 0, 2264, -1, "", 1);// 428
			AddComplexComponent( (BaseAddon) this, 489, 17, 7, 0, 2264, -1, "", 1);// 429
			AddComplexComponent( (BaseAddon) this, 489, 18, 7, 0, 2264, -1, "", 1);// 430
			AddComplexComponent( (BaseAddon) this, 490, 19, 4, 0, 2264, -1, "", 1);// 431
			AddComplexComponent( (BaseAddon) this, 490, 19, 5, 0, 2264, -1, "", 1);// 432

		}

		public KOT_LavaMoteCastleAddon( Serial serial ) : base( serial )
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

	public class KOT_LavaMoteCastleAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new KOT_LavaMoteCastleAddon();
			}
		}

		[Constructable]
		public KOT_LavaMoteCastleAddonDeed()
		{
			Name = "KOT_LavaMoteCastle";
		}

		public KOT_LavaMoteCastleAddonDeed( Serial serial ) : base( serial )
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