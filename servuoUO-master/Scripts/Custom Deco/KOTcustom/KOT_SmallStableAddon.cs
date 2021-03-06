
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
	public class KOT_SmallStableAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {12791, -2, 4, 5}, {12791, -1, 4, 5}, {12791, -2, 3, 5}// 1	2	3	
			, {12791, -1, 3, 5}, {12791, -2, 2, 5}, {12791, -1, 2, 5}// 4	5	6	
			, {12791, -2, 1, 5}, {12791, -1, 1, 5}, {12791, 0, 1, 5}// 7	8	9	
			, {12791, 0, 2, 5}, {12791, 0, 3, 5}, {12791, 0, 4, 5}// 10	11	12	
			, {12791, 1, 4, 5}, {12791, 1, 3, 5}, {12791, 1, 2, 5}// 13	14	15	
			, {12791, 1, 1, 5}, {12791, 1, -1, 5}, {12791, 1, 0, 5}// 16	17	18	
			, {12791, 0, 0, 5}, {12791, 0, -1, 5}, {12791, -1, -1, 5}// 19	20	21	
			, {12791, -1, 0, 5}, {12791, -2, 0, 5}, {12791, -2, -1, 5}// 22	23	24	
			, {12791, 1, -2, 5}, {12791, 0, -2, 5}, {12791, -1, -2, 5}// 25	26	27	
			, {12791, -2, -2, 5}, {2141, 1, -3, 5}, {2141, 0, -3, 5}// 28	29	30	
			, {2141, -1, -3, 0}, {2141, -2, -3, 5}, {2143, -3, -3, 5}// 31	32	33	
			, {2142, -3, -2, 5}, {2142, -3, -1, 5}, {2142, -3, 1, 5}// 34	35	36	
			, {2142, -3, 0, 5}, {2142, -3, 2, 5}, {2142, -3, 3, 5}// 37	38	39	
			, {2142, -3, 4, 5}, {2141, -2, 4, 5}, {2141, -1, 4, 5}// 40	41	42	
			, {2143, 1, 4, 5}, {4151, -1, 3, 5}, {3893, 1, -1, 5}// 43	44	45	
			, {4150, 1, 2, 5}, {4150, 1, 0, 5}, {2883, -2, -2, 5}// 46	47	48	
			, {2141, -1, -3, 5}, {2884, -1, -2, 5}, {4150, -1, 2, 5}// 49	50	51	
			, {4150, -1, 0, 5}, {6802, 0, -2, 5}, {6802, -2, 3, 5}// 52	53	54	
			, {4980, 0, 4, 5}, {3900, 0, 2, 5}, {2879, -2, 1, 5}// 55	56	57	
			, {4980, -2, 1, 11}, {12791, 2, 1, 5}, {12791, 2, 2, 5}// 58	59	60	
			, {12791, 2, 3, 5}, {12791, 2, 4, 5}, {12791, 2, 0, 5}// 61	62	63	
			, {12791, 2, -1, 5}, {12791, 3, 4, 5}, {12791, 3, 3, 5}// 64	65	66	
			, {12791, 3, 2, 5}, {12791, 3, 1, 5}, {12791, 3, 0, 5}// 67	68	69	
			, {12791, 3, -1, 5}, {12791, 3, -2, 5}, {12791, 2, -2, 5}// 70	71	72	
			, {2140, 3, 4, 5}, {2141, 3, -3, 5}, {2141, 2, -3, 5}// 73	74	75	
			, {2142, 3, -2, 5}, {2142, 3, -1, 5}, {2142, 3, 1, 5}// 76	77	78	
			, {2142, 3, 0, 5}, {2142, 3, 2, 5}, {2142, 3, 3, 5}// 79	80	81	
			, {2141, 2, 4, 5}, {3895, 2, -2, 5}, {3899, 2, 0, 5}// 82	83	84	
			, {5351, 2, 3, 5}// 85	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new KOT_SmallStableAddonDeed();
			}
		}

		[ Constructable ]
		public KOT_SmallStableAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


		}

		public KOT_SmallStableAddon( Serial serial ) : base( serial )
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

	public class KOT_SmallStableAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new KOT_SmallStableAddon();
			}
		}

		[Constructable]
		public KOT_SmallStableAddonDeed()
		{
			Name = "KOT_SmallStable";
		}

		public KOT_SmallStableAddonDeed( Serial serial ) : base( serial )
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