
////////////////////////////////////////
//                                    //
//      Generated by CEO's YAAAG      //
// (Yet Another Arya Addon Generator) //
//                                    //
////////////////////////////////////////
using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class MaabusCoffinSouthAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {7226, 0, 1, 0}, {7224, 0, -1, 0}, {7535, 0, 0, 0}// 1	2	3	
			, {7537, 0, 2, 0}, {7532, 1, 2, 0}, {7533, 1, 1, 0}// 4	5	6	
			, {7534, 1, 0, 0}// 7	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new MaabusCoffinSouthAddonDeed();
			}
		}

		[ Constructable ]
		public MaabusCoffinSouthAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


		}

		public MaabusCoffinSouthAddon( Serial serial ) : base( serial )
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

	public class MaabusCoffinSouthAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new MaabusCoffinSouthAddon();
			}
		}

		[Constructable]
		public MaabusCoffinSouthAddonDeed()
		{
			Name = "MaabusCoffinSouth";
		}

		public MaabusCoffinSouthAddonDeed( Serial serial ) : base( serial )
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