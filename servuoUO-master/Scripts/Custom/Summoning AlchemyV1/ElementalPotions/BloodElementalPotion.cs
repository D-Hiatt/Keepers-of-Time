using System;
using Server.Network;
using Server;
using Server.Targets;
using Server.Targeting;
using Server.Spells;
using Server.Mobiles;
using Server.Items;

namespace Server.Items
{
	public class BloodElementalPotion : BasePotion
	{
		[Constructable]
		public BloodElementalPotion() : base( 0xF0B, PotionEffect.BloodElemental)
		{
			Weight = 1.0;
			Movable = true;
			Hue = 38;
			Name = "A Blood Elemental Potion";
		}

		public BloodElementalPotion( Serial serial ) : base( serial )
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
				m.Target = new BThrowTarget();

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
    public class BThrowTarget : Target
	{
		public BThrowTarget() : base( 12, true, TargetFlags.None )
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
                                
								if ( targeted is DaemonBlood )
				{
					DaemonBlood blood = (DaemonBlood)targeted;

					 if ( blood.Amount < 20 )
					{
						from.SendMessage( "That probably wouldn't be enough blood!" );
					}
                                        else
                                        {
                                        SpellHelper.Summon( new BloodElemental(), from, 0x217, duration, false, false );
                                        blood.Delete();
                                        return;
                                        }
				}
                                if (targeted is Item)
                    {
                                Item item = (Item)targeted;

                                        if ( item is Corpse )
                                        {
                                        SpellHelper.Summon( new BloodElemental(), from, 0x217, duration, false, false );
                                             return;
                                        }
				         else
                                        {
                                        from.SendMessage( "Nothing happens!" );
                                        return;
                                        }
			        }    
		    }
	}
}