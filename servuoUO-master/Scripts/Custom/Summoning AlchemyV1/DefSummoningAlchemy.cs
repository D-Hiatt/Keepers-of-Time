using System;
using Server.Items;

namespace Server.Engines.Craft
{
	public class DefSummoningAlchemy : CraftSystem
	{
		public override SkillName MainSkill
		{
			get	{ return SkillName.Alchemy;	}
		}

		public override int GumpTitleNumber
		{
			get { return 0; } // <CENTER>ALCHEMY MENU</CENTER>
		}
  
                public override string GumpTitleString
		{
			get { return "<basefont color=#FFFFFF><CENTER>Summoning Alchemy Menu</CENTER></basefont>"; }
		}

		private static CraftSystem m_CraftSystem;

		public static CraftSystem CraftSystem
		{
			get
			{
				if ( m_CraftSystem == null )
					m_CraftSystem = new DefSummoningAlchemy();

				return m_CraftSystem;
			}
		}

		public override double GetChanceAtMin( CraftItem item )
		{
			return 0.0; // 0%
		}

		private DefSummoningAlchemy() : base( 1, 1, 1.25 )// base( 1, 1, 3.1 )
		{
		}

		public static void CheckStump( Mobile from, int range, out bool stump )
		{
			stump = false;

			Map map = from.Map;

			if ( map == null )
				return;

			IPooledEnumerable eable = map.GetItemsInRange( from.Location, range );

			foreach ( Item item in eable )
			{
				Type type = item.GetType();

				if ( item.ItemID == 6245 || item.ItemID == 6246 )
					stump = true;

				if ( stump )
					break;
			}

			eable.Free();

			for ( int x = -range; (!stump) && x <= range; ++x )
			{
				for ( int y = -range; (!stump) && y <= range; ++y )
				{
					StaticTile[] tiles = map.Tiles.GetStaticTiles( from.X+x, from.Y+y, true );

					for ( int i = 0; (!stump) && i < tiles.Length; ++i )
					{
						int id = tiles[i].ID & 0x3FFF;

						if ( id == 6245 || id == 6246 )
							stump = true;
					}
				}
			}
		}

		public override int CanCraft( Mobile from, BaseTool tool, Type itemType )
		{
			//if ( tool.Deleted || tool.UsesRemaining < 0 )
				//return 1044038; // You have worn out your tool!
			/*else*/ if ( !BaseTool.CheckAccessible( tool, from ) )
				return 1044263; // The tool must be on your person to use.
                         return 0;
                           /*bool stump;

			  CheckStump( from, 2, out stump );

                        if ( stump )
			return 0;

                        //from.SendMessage( "You must be near a dishing stump to make these potions!" );
                        //return 600000; // You must be near an anvil and a forge to smith items.

                        //from.SendMessage( "You must be near a dishing stump to make these potions!" );*/
		}

		public override void PlayCraftEffect( Mobile from )
		{
			from.PlaySound( 0x242 );
		}

		public override int PlayEndingEffect( Mobile from, bool failed, bool lostMaterial, bool toolBroken, int quality, bool makersMark, CraftItem item )
		{
			//if ( toolBroken )
				//from.SendLocalizedMessage( 1044038 ); // You have worn out your tool

			if ( failed )
			{
				from.AddToBackpack( new Bottle() );

				return 500287; // You fail to create a useful potion.
			}
			else
			{
				from.PlaySound( 0x240 ); // Sound of a filling bottle

				if ( quality == -1 )
					return 1048136; // You create the potion and pour it into a keg.
				else
					return 500279; // You pour the potion into a bottle...
			}
		}

		public override void InitCraftList()
		{
			int index = -1;
			// Summoning Potions
			index = AddCraft( typeof( WaterElementalPotion ), "Summoning Potions", "A Water Elemental Potion", 99.0, 100.0, typeof( WaterElixir ), "Elixir of Water", 5 );
			AddRes( index, typeof ( Bottle ), 1044529, 1, 500315 );
			AddRes( index, typeof( BlackPearl ), 1044353, 5, 1044361 );
			index = AddCraft( typeof( FireElementalPotion ), "Summoning Potions", "A Fire Elemental Potion", 99.0, 100.0, typeof( FireElixir ), "Elixir of Fire", 5 );
			AddRes( index, typeof ( Bottle ), 1044529, 1, 500315 );
			AddRes( index, typeof( SulfurousAsh ), 1044359, 5, 1044367 );
            index = AddCraft( typeof( EarthElementalPotion ), "Summoning Potions", "An Earth Elemental Potion", 99.0, 100.0, typeof( EarthElixir ), "Elixir of Earth", 5 );
			AddRes( index, typeof ( Bottle ), 1044529, 1, 500315 );
			AddRes( index, typeof( MandrakeRoot ), 1044357, 5, 1044365 );
			index = AddCraft( typeof( SandVortexPotion ), "Summoning Potions", "A Sand Vortex Potion", 105.0, 115.0, typeof( SandElixir ), "Elixir of Sand", 5 );
			AddRes( index, typeof ( Bottle ), 1044529, 1, 500315 );
			AddRes( index, typeof(GraveDust), 1023983, 5, 1044253 );
			index = AddCraft( typeof( PoisonElementalPotion ), "Summoning Potions", "A Poison Elemental Potion", 100.0, 110.0, typeof( PoisonElixir ), "Elixir of Poison", 5 );
			AddRes( index, typeof ( Bottle ), 1044529, 1, 500315 );
			AddRes( index, typeof( Nightshade ), 1044358, 5, 1044366 );
			index = AddCraft( typeof( GreaterPoisonElementalPotion ), "Summoning Potions", "A Greater Poison Elemental Potion", 110.0, 120.0, typeof( PoisonElixir ), "Elixir of Poison", 15 );
			AddRes( index, typeof ( Bottle ), 1044529, 1, 500315 );
			AddRes( index, typeof( Nightshade ), 1044358, 10, 1044366 );
            index = AddCraft( typeof( BloodElementalPotion ), "Summoning Potions", "A Blood Elemental Potion", 100.0, 105.0, typeof( BloodElixir ), "Elixir of Blood", 5 );
			AddRes( index, typeof ( Bottle ), 1044529, 1, 500315 );
			AddRes( index, typeof( Bloodmoss ), 1044354, 5, 1044362 );
			// Elixirs
			index = AddCraft( typeof( WaterElixir ), "Elixirs", "Elixir of Water", 99.0, 100.0, typeof( MysticWater ), "Vial of Mystic Water", 1 );
			AddRes( index, typeof ( Bottle ), 1044529, 1, 500315 );
			AddRes( index, typeof( BlackPearl ), 1044353, 5, 1044361 );
			index = AddCraft( typeof( FireElixir ), "Elixirs", "Elixir of Fire", 99.0, 100.0, typeof( MysticAsh ), "Vial of Mystic Ash", 1 );
			AddRes( index, typeof ( Bottle ), 1044529, 1, 500315 );
			AddRes( index, typeof( SulfurousAsh ), 1044359, 5, 1044367 );
            index = AddCraft( typeof( EarthElixir ), "Elixirs", "Elixir of Earth", 99.0, 100.0, typeof( MysticDirt ), "Vial of Mystic Earth", 1 );
			AddRes( index, typeof ( Bottle ), 1044529, 1, 500315 );
			AddRes( index, typeof( MandrakeRoot ), 1044357, 5, 1044365 );
			index = AddCraft( typeof( SandElixir ), "Elixirs", "Elixir of Sand", 105.0, 115.0, typeof( MysticSand ), "Vial of Mystic Sand", 1 );
			AddRes( index, typeof ( Bottle ), 1044529, 1, 500315 );
			AddRes( index, typeof(GraveDust), 1023983, 5, 1044253 );
			index = AddCraft( typeof( PoisonElixir ), "Elixirs", "Elixir of Poison", 100.0, 110.0, typeof( MysticPoison ), "Vial of Mystic Poison", 1 );
			AddRes( index, typeof ( Bottle ), 1044529, 1, 500315 );
			AddRes( index, typeof( Nightshade ), 1044358, 5, 1044366 );
            index = AddCraft( typeof( BloodElixir ), "Elixirs", "Elixir of Blood", 100.0, 105.0, typeof( MysticBlood ), "Vial of Mystic Blood", 1 );
			AddRes( index, typeof ( Bottle ), 1044529, 1, 500315 );
			AddRes( index, typeof( Bloodmoss ), 1044354, 5, 1044362 );
		}
	}
}