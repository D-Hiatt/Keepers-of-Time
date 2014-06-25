
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
	public class KOT_CarpShopAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {7800, 1, -3, 3}, {7797, 3, -3, 0}, {6650, -2, 0, 0}// 1	2	3	
			, {6649, -2, 1, 0}, {7790, 0, -2, 0}, {6647, -1, -3, 0}// 4	5	6	
			, {6646, 0, -3, 0}, {6645, 1, -3, 0}, {4152, -1, -1, 0}// 7	8	9	
			, {7802, -2, -2, 0}, {7803, -2, 2, 0}, {4152, 0, 1, 0}// 10	11	12	
			, {4152, 2, -1, 0}, {4152, 1, -1, 0}, {5353, 0, 3, 0}// 13	14	15	
			, {4142, 1, 2, 0}, {7132, 2, -2, 0}, {7800, -2, 3, 0}// 16	17	18	
					};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new KOT_CarpShopAddonDeed();
			}
		}

		[ Constructable ]
		public KOT_CarpShopAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


		}

		public KOT_CarpShopAddon( Serial serial ) : base( serial )
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

	public class KOT_CarpShopAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new KOT_CarpShopAddon();
			}
		}

		[Constructable]
		public KOT_CarpShopAddonDeed()
		{
			Name = "KOT_CarpShop";
		}

		public KOT_CarpShopAddonDeed( Serial serial ) : base( serial )
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