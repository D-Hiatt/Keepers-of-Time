using System;
using Server;
using Server.Misc;
using Server.Items;

namespace Server.Mobiles
{
	[CorpseName( "a shadowy corpse" )]
	public class MidnightWraith : BaseCreature
	{
		[Constructable]
		public MidnightWraith() : base( AIType.AI_Melee, FightMode.Closest, 10, 1, 0.2, 0.1 )
		{
			Hue = 1;
			Body = 0x190;

			SetStr( 126, 150 );
			SetDex( 61, 85 );
			SetInt( 81, 95 );
			Name = "a midnight wraith";

			SetStr( 756, 780 );
			SetDex( 226, 245 );
			SetInt( 26, 40 );

			SetHits( 454, 468 );
			SetMana( 0 );

			SetDamage( 20, 33 );

			SetDamageType( ResistanceType.Physical, 70 );
			SetDamageType( ResistanceType.Cold, 30 );

			SetResistance( ResistanceType.Physical, 45, 55 );
			SetResistance( ResistanceType.Fire, 30, 40 );
			SetResistance( ResistanceType.Cold, 30, 40 );
			SetResistance( ResistanceType.Poison, 20, 30 );
			SetResistance( ResistanceType.Energy, 10, 20 );

			SetSkill( SkillName.MagicResist, 15.1, 20.0 );
			SetSkill( SkillName.Tactics, 45.1, 60.0 );
			SetSkill( SkillName.Wrestling, 45.1, 60.0 );
			SetSkill( SkillName.Fencing, 70.2, 80.1 );

			Item shroud = new Item( 0x204E );
			shroud.Layer = Layer.OuterTorso;

			AddItem( new HoodedShroudOfShadows( ) );

			AddItem( new DarkSource( ) );
			AddItem( new WraithBlade( ) );

			new Nightmare().Rider = this;
		}

		public override void GenerateLoot()
		{
			AddLoot( LootPack.Rich );
		}

		public override bool AlwaysMurderer{ get{ return true; } }
		public override bool BleedImmune{ get{ return true; } }
		public override Poison PoisonImmune{ get{ return Poison.Lethal; } }
		public override Poison HitPoison{ get{ return Poison.Greater; } }
		public override int TreasureMapLevel{ get{ return 5; } }

		public override bool OnBeforeDeath()
		{
			IMount mount = this.Mount;

			if ( mount != null )
				mount.Rider = null;

			return base.OnBeforeDeath();
		}

		public override bool IsEnemy( Mobile m )
		{
			if ( m.BodyMod == 183 || m.BodyMod == 184 )
				return false;

			return base.IsEnemy( m );
		}

		public override void AlterMeleeDamageTo( Mobile to, ref int damage )
		{
		}

		public MidnightWraith( Serial serial ) : base( serial )
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