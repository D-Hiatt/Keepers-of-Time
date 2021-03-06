
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
	public class KOT_BlackWellAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {9359, 1, -1, 0}, {9358, 0, 0, 0}, {9364, 0, 0, 5}// 1	2	3	
			, {6008, 2, -1, 0}, {3244, 2, -1, 0}, {9364, 0, -1, 5}// 4	5	6	
			, {9357, 1, 0, 0}, {9364, 1, 0, 5}, {6039, 1, 0, 0}// 7	8	9	
			, {9158, 1, 0, 15}, {9156, 2, 0, 15}, {6007, 2, 0, 0}// 10	11	12	
			, {4090, 2, 0, 9}, {7840, 2, 0, 4}, {3244, 2, 0, 0}// 13	14	15	
			, {3347, 2, 0, 3}, {7070, -1, 0, 0}, {9364, 1, -1, 5}// 16	17	18	
			, {9156, 2, 1, 15}, {3348, 0, 1, 3}, {9158, 1, 1, 15}// 19	20	21	
			, {3248, 1, 1, 0}// 22	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new KOT_BlackWellAddonDeed();
			}
		}

		[ Constructable ]
		public KOT_BlackWellAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


		}

		public KOT_BlackWellAddon( Serial serial ) : base( serial )
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

	public class KOT_BlackWellAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new KOT_BlackWellAddon();
			}
		}

		[Constructable]
		public KOT_BlackWellAddonDeed()
		{
			Name = "KOT_BlackWell";
		}

		public KOT_BlackWellAddonDeed( Serial serial ) : base( serial )
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