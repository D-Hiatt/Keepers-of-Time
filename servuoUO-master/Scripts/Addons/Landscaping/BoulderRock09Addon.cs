
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
	public class BoulderRock09Addon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {4948, 0, 1, 0}, {4951, 0, 0, 0}, {4952, 1, 0, 0}// 1	2	3	
			, {4953, 1, -1, 0}, {4959, 0, 1, 0}, {4960, 1, 1, 0}// 4	5	6	
			, {4949, -1, 1, 0}, {4950, -1, 0, 0}// 7	8	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new BoulderRock09AddonDeed();
			}
		}

		[ Constructable ]
		public BoulderRock09Addon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


		}

		public BoulderRock09Addon( Serial serial ) : base( serial )
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

	public class BoulderRock09AddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new BoulderRock09Addon();
			}
		}

		[Constructable]
		public BoulderRock09AddonDeed()
		{
			Name = "BoulderRock09";
		}

		public BoulderRock09AddonDeed( Serial serial ) : base( serial )
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