using System;
using System.Collections;
using System.Collections.Generic;
using Server.Items;
using Server.Targeting;
using Server.Engines.Quests;
using Server.Engines.Quests.Haven;
using Server.ContextMenus;

namespace Server.Mobiles
{
	[CorpseName( "a ghostly corpse" )]
	public class Poltergeist : BaseCreature
	{
		[Constructable]
		public Poltergeist() : base( AIType.AI_Mage, FightMode.Closest, 10, 1, 0.4, 0.1 )
		{
			Name = "a poltergeist";
			Body = 0x3CA;
			Hue = 1153;
			BaseSoundID = 0x482;

			SetStr( 171, 200 );
			SetDex( 126, 145 );
			SetInt( 276, 305 );

			SetHits( 103, 120 );

			SetDamage( 24, 26 );

			SetDamageType( ResistanceType.Physical, 10 );
			SetDamageType( ResistanceType.Cold, 40 );
			SetDamageType( ResistanceType.Energy, 50 );

			SetResistance( ResistanceType.Physical, 40, 60 );
			SetResistance( ResistanceType.Fire, 20, 30 );
			SetResistance( ResistanceType.Cold, 50, 60 );
			SetResistance( ResistanceType.Poison, 55, 65 );
			SetResistance( ResistanceType.Energy, 40, 50 );

			SetSkill( SkillName.EvalInt, 100.0 );
			SetSkill( SkillName.Necromancy, 70.1, 80.0 );
			SetSkill( SkillName.SpiritSpeak, 70.1, 80.0 );
			SetSkill( SkillName.Poisoning, 100.1, 101.0 );
			SetSkill( SkillName.Meditation, 85.1, 95.0 );
			SetSkill( SkillName.MagicResist, 80.1, 100.0 );
			SetSkill( SkillName.Tactics, 70.1, 90.0 );

			Fame = 8000;
			Karma = -8000;

			VirtualArmor = 6;
		}

		public override void GenerateLoot()
		{
			AddLoot( LootPack.Rich );
			AddLoot( LootPack.Average );
			//AddLoot( LootPack.MedScrolls, 2 );
		}

		public override bool AlwaysAttackable{ get{ return true; } }
		public override bool BleedImmune{ get{ return true; } }
		public override Poison PoisonImmune{ get{ return Poison.Lethal; } }
		public override bool BardImmune{ get{ return !Core.SE; } }
		public override bool Unprovokable{ get{ return Core.SE; } }
		public override bool Uncalmable{ get{ return Core.SE; } }

		public override void DisplayPaperdollTo(Mobile to)
		{
		}

		public override void GetContextMenuEntries( Mobile from, List<ContextMenuEntry> list )
		{
			base.GetContextMenuEntries( from, list );

			for ( int i = 0; i < list.Count; ++i )
			{
				if ( list[i] is ContextMenus.PaperdollEntry )
					list.RemoveAt( i-- );
			}
		}

		public Poltergeist( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( (int) 0 );
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}
}