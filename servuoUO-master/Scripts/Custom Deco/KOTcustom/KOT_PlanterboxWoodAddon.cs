
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
	public class KOT_PlanterboxWoodAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {10385, 0, 1, 0}, {10382, -1, 1, 0}, {10385, 0, 0, 0}// 1	2	3	
			, {3231, 0, 1, 3}, {3204, 0, 1, 5}, {10376, 1, 1, 0}// 4	5	6	
			, {10385, 1, 0, 0}, {3231, 1, 1, 4}, {3204, 1, 1, 7}// 7	8	9	
					};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new KOT_PlanterboxWoodAddonDeed();
			}
		}

		[ Constructable ]
		public KOT_PlanterboxWoodAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


		}

		public KOT_PlanterboxWoodAddon( Serial serial ) : base( serial )
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

	public class KOT_PlanterboxWoodAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new KOT_PlanterboxWoodAddon();
			}
		}

		[Constructable]
		public KOT_PlanterboxWoodAddonDeed()
		{
			Name = "KOT_PlanterboxWood";
		}

		public KOT_PlanterboxWoodAddonDeed( Serial serial ) : base( serial )
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