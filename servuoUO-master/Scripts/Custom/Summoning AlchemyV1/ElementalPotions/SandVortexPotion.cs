using System;
using Server.Network;
using Server;
using Server.Targets;
using Server.Targeting;
using Server.Spells;
using Server.Mobiles;
//using Server.Engines.Plants;
namespace Server.Items
{
	public class SandVortexPotion : BasePotion
	{
		[Constructable]
		public SandVortexPotion() : base( 0xF0B, PotionEffect.EarthElemental )
		{
			Weight = 1.0;
			Movable = true;
			Hue = 143;
			Name = "A Sand Vortex Potion";
		}

		public SandVortexPotion( Serial serial ) : base( serial )
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
	  
	  	public override void Drink( Mobile m )
      	        {
                  if ( Core.AOS && (m.Paralyzed || m.Frozen || (m.Spell != null && m.Spell.IsCasting)) )
			{
				m.SendMessage( "You can't throw that while paralyzed!" );
				return;
			}
                  if ( m.InRange( this.GetWorldLocation(), 1 ) )
         	        {
			m.Target = new SThrowTarget();

			m.RevealingAction();

           		m.SendMessage( "Where do you want to throw this?!" );
                        this.Consume();
                        //this.Delete();
                        }
         	else
         	{
            	m.LocalOverheadMessage( MessageType.Regular, 906, 1019045 ); // I can't reach that.
         	}
		}
	}
                public class SThrowTarget : Target
		{
			public SThrowTarget() : base( 12, true, TargetFlags.None )
			{
			}

			protected override void OnTarget( Mobile from, object targeted )
			{
                                IPoint3D p = targeted as IPoint3D;
                                Map map = from.Map;
                                IEntity to;
                                if ( p is Mobile )
					to = (Mobile)p;
				else
					to = new Entity( Serial.Zero, new Point3D( p ), map );
                                Effects.SendMovingEffect( from, to, 0xF0B & 0x3FFF, 7, 0, false, false, 0x8F, 0 );
				if ( targeted is BaseCreature || targeted is PlayerMobile)
				{
                                from.SendMessage( "Nothing happens!" );
                                return;
                                }
                                TimeSpan duration = TimeSpan.FromMinutes( 10 );
                                if ( targeted is Sand )
				{
					Sand sand = (Sand)targeted;

					if ( sand.Amount < 20 )
					{
						from.SendMessage( "That probably wouldn't be enough sand!" );
					}
                                        else
                                        {
                                        SpellHelper.Summon( new SandVortex(), from, 0x217, duration, false, false );
                                        sand.Delete();
                                        return;
                                        }
                                        
				       // {
                                        //from.SendMessage( "Nothing happens!" );
                                        //return;
                                        //}
				}
                                /*if (targeted is StaticTarget)
                                {
                                StaticTarget obj = (StaticTarget)targeted;

                                        if ((obj.ItemID > 6025 && obj.ItemID < 6077) || (obj.ItemID > 13420 && obj.ItemID < 13529) || (obj.ItemID >= 0x5796 && obj.ItemID <= 0x57B2) )
                                        {
                                        SpellHelper.Summon( new SummonedWaterElemental(), from, 0x217, duration, false, false );
                                             return;
                                        }
				         else
                                        {
                                        //from.Target = new WThrowTarget();
                                        from.SendMessage( "Nothing happens!" );
                                        return;
                                        }
			         }*/

                                if (IsSand( targeted ))
                                {
                                        SpellHelper.Summon( new SandVortex(), from, 0x217, duration, false, false );
			         }
                                else
				{
                                        from.SendMessage( "Nothing happens!" );
                                        return;
				}
		       }
         public static bool IsSand( object obj )
		{
			int tileID;

			if ( obj is Static && !((Static)obj).Movable )
				tileID = (((Static)obj).ItemID & 0x3FFF) | 0x4000;
			else if ( obj is StaticTarget )
				tileID = (((StaticTarget)obj).ItemID & 0x3FFF) | 0x4000;
			else if ( obj is LandTarget )
				tileID = ((LandTarget)obj).TileID & 0x3FFF;
			else
				return false;

			bool contains = false;

			for ( int i = 0; !contains && i < m_SandTiles.Length; i += 2 )
				contains = ( tileID >= m_SandTiles[i] && tileID <= m_SandTiles[i + 1] );

			return contains;
		}

		private static int[] m_SandTiles = new int[]
			{
				0x0016, 0x0017,
				0x0018, 0x0019,
				0x001A, 0x001B,
				0X001C, 0X001D,
				0X001E, 0X001F,
				0x0020, 0x0021,
				0x0022, 0x0023,
				0x0024, 0x0025,
				0X0026, 0X0027,
				0X0028, 0X0029,
				0x002A, 0x002B,
				0x002C, 0x002D,
				0x002E, 0x002F,
				0X0030, 0X0031,
				0X0032, 0X0033,
				0x0034, 0x0035,
				0x0036, 0x0037,
				0x0038, 0x0039,
				0x003A, 0x003B,
				0x003C, 0x003D,
				0x003E, 0x0044,
				0x0045, 0x0046,
				0x0046, 0x0047,
				0x0048, 0x0049,
				0x004A, 0x004B,
				0x011E, 0x011F,
				0x0120, 0x0121,
				0x0122, 0x0123,
				0X0124, 0X0125,
				0X0126, 0X0127,
				0x0128, 0x0129,
				0x012A, 0x012B,
				0X012C, 0X012D,
				0X01A8, 0X01A9,
				0x01AA, 0x01AB,
				0x01B9, 0x01BA,
				0x01BB, 0x01BC,
				0X01BD, 0X01BE,
				0X01BF, 0X01C0,
				0x01C1, 0x01C2,
				0x01C3, 0x01C4,
				0x01C5, 0x01C6,
				0X01C7, 0X01C8,
				0X01C9, 0X01CA,
				0x01CB, 0x01CC,
				0x01CD, 0x01CE,
				0x01CF, 0x01D0,
				0X01D1, 0X0282,
				0X0283, 0X0284,
				0x0285, 0x028A,
				0x028B, 0x028C,
				0x028D, 0x028E,
				0X028F, 0X0290,
				0X0290, 0X0335,
				0x0336, 0x0337,
				0x0338, 0x0339,
				0x033A, 0x033B,
				0X033C, 0X0341,
				0X0342, 0X0343,
				0x0344, 0x034D,
				0x034E, 0x034F,
				0x0350, 0x0351,
				0x0352, 0x0353,
				0x0354, 0x0359,
				0X035A, 0X035B,
				0X035C, 0X03B7,
				0x03B8, 0x03B9,
				0x03BA, 0x03BB,
				0X03BC, 0X03BD,
				0X03BE, 0X03C7,
				0x03C8, 0x03C9,
				0x03CA, 0x05A7,
				0x05A8, 0x05A9,
				0X05AA, 0X05AB,
				0X05AC, 0X05AD,
				0x05AE, 0x05AF,
				0x05B0, 0x05B1,
				0x05B2, 0x064B,
				0X064C, 0X064D,
				0X064E, 0X064F,
				0x0650, 0x0651,
				0x0652, 0x0657,
				0x0658, 0x0659,
				0X065A, 0X0663,
				0X0664, 0X0665,
				0x0666, 0x0667,
				0x0668, 0x0669,
				0x066A, 0x066F,
				0X0670, 0X0671,
				0X0672,				
			};
}
}
