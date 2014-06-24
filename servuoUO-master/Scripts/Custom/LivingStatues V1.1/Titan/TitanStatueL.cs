using System;
using Server;
using System.Collections;
using Server.Targeting;
using Server.Misc;
using Server.Network;

namespace Server.Mobiles
{
	public class TitanStatueL : Mobile
	{
		[Constructable]
		public TitanStatueL()
		{
			Body = 76;
			Name = "Stone Titan Statue";
			Hue = 846;
			Direction = Direction.Left;
			CantWalk = true;
		}

		public TitanStatueL( Serial serial ) : base( serial )
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
				SpawnTitan( m_from );
			}
		}

		public void SpawnTitan( Mobile target )
		{
			Map map = target.Map;

			if ( map == null )
				return;

			BaseCreature titan = new Titan();

			titan.Name = "Stone Titan";
			titan.Hue = 846;
			titan.Direction = Direction.Left;

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

			titan.MoveToWorld( loc, map );

			titan.Combatant = target;
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