using System;
using Server;
using System.Collections;
using Server.Targeting;
using Server.Misc;
using Server.Network;
using Server.Items;

namespace Server.Mobiles
{
	public class HumanStatueE : Mobile
	{
		[Constructable]
		public HumanStatueE()
		{
			Body = 0x190;
			Name = "Stone Knight Statue";
			Hue = 846;
			Direction = Direction.East;
			CantWalk = true;

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

		public HumanStatueE( Serial serial ) : base( serial )
		{
		}

		public override void OnMovement( Mobile m, Point3D oldLocation ) 
		{  
			PlayerMobile m_from = m as PlayerMobile;

			if ( Multis.DesignContext.Check( m ) )

			if ( m_from == null )
				return;

			if ( m_from.InRange( this, 2 ) ) 
			{
				this.BoltEffect( 0 );
				m_from.SendMessage("Thy have disturbed my slumber, thy shall pay with thy life!");
				m_from.PlaySound( 41 );
				this.Delete();
				SpawnHuman( m_from );
			}
		}

		public void SpawnHuman( Mobile target )
		{
			Map map = target.Map;

			if ( map == null )
				return;

			BaseCreature knight = new Knight();

			knight.Name = "Stone Knight";
			knight.Hue = 846;
			knight.Direction = Direction.East;

			Point3D loc = this.Location;
			bool validLocation = false;

			for ( int j = 0; !validLocation && j < 10; ++j )
			{
				int x = this.X;
				int y = this.Y;
				int z = map.GetAverageZ( x, y );

				if ( validLocation = map.CanFit( x, y, this.Z, 16, false, false ) )
					loc = new Point3D( x, y, Z );
				else if ( validLocation = map.CanFit( x, y, z, 16, false, false ) )
					loc = new Point3D( x, y, z );
			}

			knight.MoveToWorld( loc, map );

			knight.Combatant = target;
		}

		public override bool CanBeDamaged()
		{
			return false;
		}

		public override bool CanBeBeneficial(Mobile target)
		{
			return false;
		}

		public override bool CanBeHarmful(Mobile target)
		{
			return false;
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 1 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();
		}
	}
}