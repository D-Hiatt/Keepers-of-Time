using System;
using Server;
using Server.Items;

namespace Server.Mobiles
{
	[CorpseName( "a scavenger corpse" )]
	public class CorpseScavenger : BaseCreature
	{
		[Constructable]
		public CorpseScavenger() : base( AIType.AI_Melee, FightMode.Aggressor, 10, 1, 0.2, 0.4 )
		{
			Name = "a corpse scavenger";
			Body = 302;
			BaseSoundID = 959;
			Hue = 850;

			SetStr( 41, 65 );
			SetDex( 91, 115 );
			SetInt( 26, 50 );

			SetHits( 31, 45 );

			SetDamage( 3, 5 );

			SetDamageType( ResistanceType.Physical, 100 );

			SetResistance( ResistanceType.Physical, 5, 10 );
			SetResistance( ResistanceType.Cold, 10, 20 );
			SetResistance( ResistanceType.Energy, 5, 10 );

			SetSkill( SkillName.MagicResist, 30.1, 45.0 );
			SetSkill( SkillName.Tactics, 45.1, 70.0 );
			SetSkill( SkillName.Wrestling, 40.1, 60.0 );

			Fame = 300;
			Karma = 0;

			Tamable = true;
			ControlSlots = 1;
			MinTameSkill = -12.9;

			VirtualArmor = 12;
		}

		public override void GenerateLoot()
		{
			AddLoot( LootPack.Meager );
		}

		public override int TreasureMapLevel{ get{ return 1; } }

		public CorpseScavenger( Serial serial ) : base( serial )
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