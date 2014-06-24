
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
	public class CarpenterBazaarAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {17621, 1, -1, 0}, {7802, -1, 1, 0}, {1189, 0, -1, 0}// 1	2	3	
			, {1189, 2, 1, 0}, {1189, 2, 2, 0}, {1189, 1, 0, 0}// 4	5	6	
			, {1189, 1, 1, 0}, {1189, 1, 2, 0}, {6652, 0, -1, 0}// 7	8	9	
			, {7792, -1, 0, 0}, {4139, 0, 1, 0}, {4152, 0, 0, 0}// 10	11	12	
			, {7791, 2, -1, 0}, {4142, -1, 2, 0}, {1189, 2, -1, 0}// 13	14	15	
			, {1189, 2, 0, 0}, {6651, -1, -1, 0}, {1189, 1, -1, 0}// 16	17	18	
			, {1189, 0, 2, 0}, {1189, 0, 1, 0}, {1189, 0, 0, 0}// 19	20	21	
			, {1189, -1, 0, 0}, {1189, -1, -1, 0}, {1189, -1, 1, 0}// 22	23	24	
			, {1189, -1, 2, 0}// 25	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new CarpenterBazaarAddonDeed();
			}
		}

		[ Constructable ]
		public CarpenterBazaarAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


		}

		public CarpenterBazaarAddon( Serial serial ) : base( serial )
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

	public class CarpenterBazaarAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new CarpenterBazaarAddon();
			}
		}

		[Constructable]
		public CarpenterBazaarAddonDeed()
		{
			Name = "CarpenterBazaar";
		}

		public CarpenterBazaarAddonDeed( Serial serial ) : base( serial )
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