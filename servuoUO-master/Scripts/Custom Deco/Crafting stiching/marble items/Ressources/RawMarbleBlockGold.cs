/////////////////////////////////////////////////
//                                             //
// Created by Manu for                         //
// Splitterwelt.com                            //
// german roleplay freeshard                   //
//                                             //
// may be used and modified as you like, as    //
// long as this header is kept                 //
/////////////////////////////////////////////////
using System;
using Server.Items;

namespace Server.Items
{
	public class RawMarbleBlockGold : Item
	{

		[Constructable]
		public RawMarbleBlockGold() : base( 0x00DF )
		{
			Movable = true;
			Weight = 10.0;
			Hue = 0x8A5;
			Name = "Raw Marble Block (Golden)";
		}

		public RawMarbleBlockGold( Serial serial ) : base( serial )
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