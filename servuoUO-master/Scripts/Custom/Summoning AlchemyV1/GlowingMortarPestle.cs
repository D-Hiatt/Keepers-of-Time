using System;
using Server;
using Server.Engines.Craft;

namespace Server.Items
{
	public class GlowingMortarPestle : BaseTool//, IRare
	{
		public override CraftSystem CraftSystem{ get{ return DefSummoningAlchemy.CraftSystem; } }

		[Constructable]
		public GlowingMortarPestle() : base( 0xE9B )
		{
			Weight = 1.0;
                        //Movable = false;
                        Hue = 2160;
		}

		[Constructable]
		public GlowingMortarPestle( int uses ) : base( uses, 0xE9B )
		{
			Weight = 10.0;
		}

		public GlowingMortarPestle( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 0 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();
		}
	}
}
