using System;
using Server.Network;
using Server.Prompts;
using Server.Items;
using Server.Guilds;
using Server.Gumps;
using Server.Mobiles; 
using Server.Targeting;

namespace Server.Items
{
	public class StPatricksDayGiftDeed2007 : Item 
	{
		[Constructable]
		public StPatricksDayGiftDeed2007() : base( 0x14F0 )
		{
			Weight = 0.1;
			Name = "St. Patrick's Day Gift Deed 2007";
			LootType = LootType.Blessed;
			Hue = 1369;
		}
		
		public StPatricksDayGiftDeed2007( Serial serial ) : base( serial )
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

		public override void OnDoubleClick( Mobile from ) // Override double click of the deed to call our target
		{
			if ( !IsChildOf( from.Backpack ) ) // Make sure its in their pack
			{
				 from.SendLocalizedMessage( 1042001 ); // That must be in your pack for you to use it.
			}
			else
			{
		 		this.Delete(); 
				from.SendMessage( "A St. Patrick's Day Gift has been placed in your backpack." );
				switch ( Utility.Random( 9 ) ) //Random choice of gift item 
                { 
			        case 0: from.AddToBackpack( new BowlOfPotatoes2007() ); break;
			        case 1: from.AddToBackpack( new CloverPatch2007() ); break;
			        case 2: from.AddToBackpack( new FineIrishAle2007() ); break;
			        case 3: from.AddToBackpack( new IrishDrinkingMug2007() ); break;
			        case 4: from.AddToBackpack( new LuckyCharmsCereal2007() ); break;
			        case 5: from.AddToBackpack( new PotOfGold2007() ); break;
					case 6: from.AddToBackpack( new Rainbow2007() ); break;
					case 7: from.AddToBackpack( new BowlOfIrishStew2007() ); break;
					case 8: from.AddToBackpack( new BlarneyStone2007() ); break;
                } 
			}
		}	
	}
}