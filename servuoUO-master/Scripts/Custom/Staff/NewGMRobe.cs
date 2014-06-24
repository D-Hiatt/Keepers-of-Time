
using System;
using Server;
using Server.Items;

namespace Server.Items
{
   [FlipableAttribute( 0x2683, 0x204F )]
   public class NewGMRobe : BaseOuterTorso
   {

    private string m_PlayerTitle;

       [Constructable]
       public NewGMRobe() : base( 0x1F03 )
       {
        Weight = 5.0;
		Hue = 2;
        Name = "A Gamemaster Robe";
        Layer = Layer.OuterTorso;
        LootType = LootType.Newbied;
       }

      public override void OnDoubleClick( Mobile m )
      {
         if( Parent != m )
         {
            m.SendMessage( "You must be wearing the robe to use it!" );
         }
         else
         {
            if ( ItemID == 0x204F || ItemID == 0x204F )
            {
               m.SendMessage( "You lower the hood." );
               m.PlaySound( 0x57 );
               ItemID = 0x1F03;
               m.NameMod = null;

        if ( m != null )
        {
            m.Title = m_PlayerTitle;
            m_PlayerTitle = "";
        }
            }
            else if ( ItemID == 0x1F03 || ItemID == 0x1F04 )
            {
               m.SendMessage( "You pull the hood over your head." );
               m.PlaySound( 0x57 );
               ItemID = 0x204F;
               m.NameMod = "A GameMaster";
               m.DisplayGuildTitle = false;

        if ( m != null )
        {
            m_PlayerTitle = m.Title;
            m.Title = null;
        }

            }
         }
      }

      public NewGMRobe( Serial serial ) : base( serial )
      {

      }

      public override void Serialize( GenericWriter writer )
      {
         base.Serialize( writer );
         writer.Write( (int) 0 ); // version

     writer.Write( m_PlayerTitle );
      }

      public override void Deserialize( GenericReader reader )
      {
         base.Deserialize( reader );
         int version = reader.ReadInt();

     switch ( version )
     {
        case 0:
        {
            m_PlayerTitle = reader.ReadString();

            break;
        }
     }
      }

   }
}
 