
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
	public class KOT_MarbleWellAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {10419, 1, 0, 16}, {3246, 1, 1, 1}, {6039, 0, 0, 1}// 1	2	3	
			, {4972, 1, 1, 1}, {10419, 1, 1, 16}, {3245, 0, 1, 1}// 4	5	6	
			, {271, 0, -1, 1}, {10420, 0, 1, 16}, {3241, 1, -1, 1}// 7	8	9	
			, {3250, 1, -1, 1}, {4090, 0, -1, 0}, {10420, 0, 0, 16}// 10	11	12	
			, {4963, 1, 0, 1}, {4090, 1, 0, 8}, {7840, 1, 0, 3}// 13	14	15	
			, {6814, 1, 0, 1}, {270, 0, 0, 1}, {269, 0, 0, 4}// 16	17	18	
			, {269, -1, -1, 4}, {3208, -1, 0, 1}, {269, -1, 0, 4}// 19	20	21	
			, {272, -1, 0, 1}, {3248, -1, 1, 1}, {6012, -1, 1, 1}// 22	23	24	
			, {269, 0, -1, 4}// 25	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new KOT_MarbleWellAddonDeed();
			}
		}

		[ Constructable ]
		public KOT_MarbleWellAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


		}

		public KOT_MarbleWellAddon( Serial serial ) : base( serial )
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

	public class KOT_MarbleWellAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new KOT_MarbleWellAddon();
			}
		}

		[Constructable]
		public KOT_MarbleWellAddonDeed()
		{
			Name = "KOT_MarbleWell";
		}

		public KOT_MarbleWellAddonDeed( Serial serial ) : base( serial )
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