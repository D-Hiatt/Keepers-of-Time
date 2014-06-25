using System;
using System.Collections;
using Server.Items;
using Server.ContextMenus;
using Server.Misc;
using Server.Network;

namespace Server.Mobiles
{
	public class Knight : BaseCreature
	{
		[Constructable]
		public Knight() : base( AIType.AI_Melee, FightMode.Closest, 10, 1, 0.2, 0.4 )
		{
			Hue = 846;
			Body = 0x190;

			SetStr( 186, 200 );
			SetDex( 181, 295 );
			SetInt( 161, 275 );

			SetDamage( 10, 33 );

			SetSkill( SkillName.Fencing, 66.0, 97.5 );
			SetSkill( SkillName.Macing, 65.0, 87.5 );
			SetSkill( SkillName.MagicResist, 25.0, 47.5 );
			SetSkill( SkillName.Swords, 65.0, 87.5 );
			SetSkill( SkillName.Tactics, 65.0, 87.5 );
			SetSkill( SkillName.Wrestling, 15.0, 37.5 );

			Fame = 1000;
			Karma = -1000;

			PlateHelm helm = new PlateHelm();
			helm.Hue = 846;
			helm.Movable = false;
			AddItem( helm );

			PlateGorget gorget = new PlateGorget();
			gorget.Hue = 846;
			gorget.Movable = false;
			AddItem( gorget );

			PlateChest chest = new PlateChest();
			chest.Hue = 846;
			chest.Movable = false;
			AddItem( chest );

			PlateLegs legs = new PlateLegs();
			legs.Hue = 846;
			legs.Movable = false;
			AddItem( legs );

			PlateArms arms = new PlateArms();
			arms.Hue = 846;
			arms.Movable = false;
			AddItem( arms );

			PlateGloves gloves = new PlateGloves();
			gloves.Hue = 846;
			gloves.Movable = false;
			AddItem( gloves );

			HeaterShield shield = new HeaterShield();
			shield.Hue = 846;
			shield.Movable = false;
			AddItem( shield );

			Longsword weapon = new Longsword();
			weapon.Hue = 846;
			weapon.Movable = false;
			AddItem( weapon );
		}

		public override void GenerateLoot()
		{
			AddLoot( LootPack.Average );
		}

		public Knight( Serial serial ) : base( serial )
		{
		}

		public override bool AlwaysMurderer{ get{ return true; } }

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