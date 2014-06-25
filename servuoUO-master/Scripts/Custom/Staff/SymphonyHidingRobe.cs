using System; 
using Server; 
using Server.Misc;
using Server.Items; 
using Server.Targeting; 

namespace Server.Items 
{ 
   [FlipableAttribute( 0x7939, 0x7940 )] 
   public class SymphonysHidingRobe  : BaseOuterTorso  
   { 
      [Constructable] 
      public SymphonysHidingRobe() :  base( 0x204F ) 
      { 
         Weight = 1.0; 
         Hue = 2820; 
         Name = "Symphony's Hiding Robe"; 
         LootType = LootType.Blessed;
        
      

         
         
      } 

      public override bool OnEquip( Mobile from )
     {


     from.LightLevel = 25;
     return base.OnEquip( from );

      }
 


 
		

       

       
    public override void OnDoubleClick( Mobile from ) 
      { 
      
      if ( Parent != from ) 
      if (from.AccessLevel < AccessLevel.GameMaster)
          from.SendMessage( "When you touch, it vanishes without trace..." );
      if (from.AccessLevel < AccessLevel.GameMaster)
      	  this.Consume() ;
      if (from.AccessLevel < AccessLevel.GameMaster)
      	  return ;
      {
                   	 
      	 if ( !from.Hidden == true )
            { 
           from.Emote( from.Name + " appears in a *SPARKLE*" );
Effects.SendLocationEffect( new Point3D( from.X, from.Y, from.Z ), from.Map, 0x37C4, 40, 0, 1170, 0 ); 
Effects.SendLocationEffect( new Point3D( from.X, from.Y, from.Z ), from.Map, 0x376A, 40, 0, 2820, 0 ); 
//First row
Effects.SendLocationEffect( new Point3D( from.X + 1, from.Y , from.Z ), from.Map, 0x37C4, 38, 0, 1170, 0 );
Effects.SendLocationEffect( new Point3D( from.X - 1, from.Y , from.Z ), from.Map, 0x37C4, 38, 0, 1170, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y + 1, from.Z ), from.Map, 0x37C4, 38, 0, 1170, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y - 1, from.Z ), from.Map, 0x37C4, 38, 0, 1170, 0 );
Effects.SendLocationEffect( new Point3D( from.X -1, from.Y - 1, from.Z ), from.Map, 0x37C4, 38, 0, 1170, 0 );
Effects.SendLocationEffect( new Point3D( from.X +1, from.Y - 1, from.Z ), from.Map, 0x37C4, 38, 0, 1170, 0 );
Effects.SendLocationEffect( new Point3D( from.X -1, from.Y + 1, from.Z ), from.Map, 0x37C4, 38, 0, 1170, 0 );
Effects.SendLocationEffect( new Point3D( from.X +1, from.Y + 1, from.Z ), from.Map, 0x37C4, 38, 0, 1170, 0 );
Effects.SendLocationEffect( new Point3D( from.X + 1, from.Y , from.Z ), from.Map, 0x376A, 38, 0, 2820, 0 );
Effects.SendLocationEffect( new Point3D( from.X - 1, from.Y , from.Z ), from.Map, 0x376A, 38, 0, 2820, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y + 1, from.Z ), from.Map, 0x376A, 38, 0, 2820, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y - 1, from.Z ), from.Map, 0x376A, 38, 0, 2820, 0 );
Effects.SendLocationEffect( new Point3D( from.X -1, from.Y - 1, from.Z ), from.Map, 0x376A, 38, 0, 2820, 0 );
Effects.SendLocationEffect( new Point3D( from.X +1, from.Y - 1, from.Z ), from.Map, 0x376A, 38, 0, 2820, 0 );
Effects.SendLocationEffect( new Point3D( from.X -1, from.Y + 1, from.Z ), from.Map, 0x376A, 38, 0, 2820, 0 );
Effects.SendLocationEffect( new Point3D( from.X +1, from.Y + 1, from.Z ), from.Map, 0x376A, 38, 0, 2820, 0 );
//Second Row
Effects.SendLocationEffect( new Point3D( from.X + 2, from.Y , from.Z ), from.Map, 0x37C4, 36, 0, 1170, 0 );
Effects.SendLocationEffect( new Point3D( from.X - 2, from.Y , from.Z ), from.Map, 0x37C4, 36, 0, 1170, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y + 2, from.Z ), from.Map, 0x37C4, 36, 0, 1170, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y - 2, from.Z ), from.Map, 0x37C4, 36, 0, 1170, 0 );
Effects.SendLocationEffect( new Point3D( from.X -2, from.Y - 2, from.Z ), from.Map, 0x37C4, 36, 0, 1170, 0 );
Effects.SendLocationEffect( new Point3D( from.X +2, from.Y - 2, from.Z ), from.Map, 0x37C4, 36, 0, 1170, 0 );
Effects.SendLocationEffect( new Point3D( from.X -2, from.Y + 2, from.Z ), from.Map, 0x37C4, 36, 0, 1170, 0 );
Effects.SendLocationEffect( new Point3D( from.X +2, from.Y + 2, from.Z ), from.Map, 0x37C4, 36, 0, 1170, 0 );
Effects.SendLocationEffect( new Point3D( from.X + 2, from.Y +1, from.Z ), from.Map, 0x37C4, 36, 0, 1170, 0 );
Effects.SendLocationEffect( new Point3D( from.X - 2, from.Y -1, from.Z ), from.Map, 0x37C4, 36, 0, 1170, 0 );
Effects.SendLocationEffect( new Point3D( from.X +1, from.Y + 2, from.Z ), from.Map, 0x37C4, 36, 0, 1170, 0 );
Effects.SendLocationEffect( new Point3D( from.X -1, from.Y - 2, from.Z ), from.Map, 0x37C4, 36, 0, 1170, 0 );
Effects.SendLocationEffect( new Point3D( from.X + 2, from.Y -1, from.Z ), from.Map, 0x37C4, 36, 0, 1170, 0 );
Effects.SendLocationEffect( new Point3D( from.X - 2, from.Y +1, from.Z ), from.Map, 0x37C4, 36, 0, 1170, 0 );
Effects.SendLocationEffect( new Point3D( from.X +1, from.Y - 2, from.Z ), from.Map, 0x37C4, 36, 0, 1170, 0 );
Effects.SendLocationEffect( new Point3D( from.X -1, from.Y + 2, from.Z ), from.Map, 0x37C4, 36, 0, 1170, 0 );
Effects.SendLocationEffect( new Point3D( from.X + 2, from.Y , from.Z ), from.Map, 0x376A, 36, 0, 2820, 0 );
Effects.SendLocationEffect( new Point3D( from.X - 2, from.Y , from.Z ), from.Map, 0x376A, 36, 0, 2820, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y + 2, from.Z ), from.Map, 0x376A, 36, 0, 2820, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y - 2, from.Z ), from.Map, 0x376A, 36, 0, 2820, 0 );
Effects.SendLocationEffect( new Point3D( from.X -2, from.Y - 2, from.Z ), from.Map, 0x376A, 36, 0, 2820, 0 );
Effects.SendLocationEffect( new Point3D( from.X +2, from.Y - 2, from.Z ), from.Map, 0x376A, 36, 0, 2820, 0 );
Effects.SendLocationEffect( new Point3D( from.X -2, from.Y + 2, from.Z ), from.Map, 0x376A, 36, 0, 2820, 0 );
Effects.SendLocationEffect( new Point3D( from.X +2, from.Y + 2, from.Z ), from.Map, 0x376A, 36, 0, 2820, 0 );
Effects.SendLocationEffect( new Point3D( from.X + 2, from.Y +1, from.Z ), from.Map, 0x376A, 36, 0, 2820, 0 );
Effects.SendLocationEffect( new Point3D( from.X - 2, from.Y -1, from.Z ), from.Map, 0x376A, 36, 0, 2820, 0 );
Effects.SendLocationEffect( new Point3D( from.X +1, from.Y + 2, from.Z ), from.Map, 0x376A, 36, 0, 2820, 0 );
Effects.SendLocationEffect( new Point3D( from.X -1, from.Y - 2, from.Z ), from.Map, 0x376A, 36, 0, 2820, 0 );
Effects.SendLocationEffect( new Point3D( from.X + 2, from.Y -1, from.Z ), from.Map, 0x376A, 36, 0, 2820, 0 );
Effects.SendLocationEffect( new Point3D( from.X - 2, from.Y +1, from.Z ), from.Map, 0x376A, 36, 0, 2820, 0 );
Effects.SendLocationEffect( new Point3D( from.X +1, from.Y - 2, from.Z ), from.Map, 0x376A, 36, 0, 2820, 0 );
Effects.SendLocationEffect( new Point3D( from.X -1, from.Y + 2, from.Z ), from.Map, 0x376A, 36, 0, 2820, 0 );
//Third Row
Effects.SendLocationEffect( new Point3D( from.X + 3, from.Y , from.Z ), from.Map, 0x37C4, 34, 0, 1170, 0 );
Effects.SendLocationEffect( new Point3D( from.X +3, from.Y - 3, from.Z ), from.Map, 0x37C4, 34, 0, 1170, 0 );
Effects.SendLocationEffect( new Point3D( from.X +3, from.Y + 3, from.Z ), from.Map, 0x37C4, 34, 0, 1170, 0 );
Effects.SendLocationEffect( new Point3D( from.X - 3, from.Y , from.Z ), from.Map, 0x37C4, 34, 0, 1170, 0 );
Effects.SendLocationEffect( new Point3D( from.X -3, from.Y - 3, from.Z ), from.Map, 0x37C4, 34, 0, 1170, 0 );
Effects.SendLocationEffect( new Point3D( from.X -3, from.Y + 3, from.Z ), from.Map, 0x37C4, 34, 0, 1170, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y + 3, from.Z ), from.Map, 0x37C4, 34, 0, 1170, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y - 3, from.Z ), from.Map, 0x37C4, 34, 0, 1170, 0 );
Effects.SendLocationEffect( new Point3D( from.X + 3, from.Y -2, from.Z ), from.Map, 0x37C4, 34, 0, 1170, 0 );
Effects.SendLocationEffect( new Point3D( from.X +3, from.Y +2, from.Z ), from.Map, 0x37C4, 34, 0, 1170, 0 );
Effects.SendLocationEffect( new Point3D( from.X +2, from.Y + 3, from.Z ), from.Map, 0x37C4, 34, 0, 1170, 0 );
Effects.SendLocationEffect( new Point3D( from.X +2, from.Y -3, from.Z ), from.Map, 0x37C4, 34, 0, 1170, 0 );
Effects.SendLocationEffect( new Point3D( from.X -3, from.Y - 2, from.Z ), from.Map, 0x37C4, 34, 0, 1170, 0 );
Effects.SendLocationEffect( new Point3D( from.X -3, from.Y + 2, from.Z ), from.Map, 0x37C4, 34, 0, 1170, 0 );
Effects.SendLocationEffect( new Point3D( from.X -2, from.Y + 3, from.Z ), from.Map, 0x37C4, 34, 0, 1170, 0 );
Effects.SendLocationEffect( new Point3D( from.X -2, from.Y - 3, from.Z ), from.Map, 0x37C4, 34, 0, 1170, 0 );
Effects.SendLocationEffect( new Point3D( from.X + 3, from.Y -1, from.Z ), from.Map, 0x37C4, 34, 0, 1170, 0 );
Effects.SendLocationEffect( new Point3D( from.X +3, from.Y +1, from.Z ), from.Map, 0x37C4, 34, 0, 1170, 0 );
Effects.SendLocationEffect( new Point3D( from.X +1, from.Y + 3, from.Z ), from.Map, 0x37C4, 34, 0, 1170, 0 );
Effects.SendLocationEffect( new Point3D( from.X +1, from.Y -3, from.Z ), from.Map, 0x37C4, 34, 0, 1170, 0 );
Effects.SendLocationEffect( new Point3D( from.X -3, from.Y - 1, from.Z ), from.Map, 0x37C4, 34, 0, 1170, 0 );
Effects.SendLocationEffect( new Point3D( from.X -3, from.Y + 1, from.Z ), from.Map, 0x37C4, 34, 0, 1170, 0 );
Effects.SendLocationEffect( new Point3D( from.X -1, from.Y + 3, from.Z ), from.Map, 0x37C4, 34, 0, 1170, 0 );
Effects.SendLocationEffect( new Point3D( from.X -1, from.Y - 3, from.Z ), from.Map, 0x37C4, 34, 0, 1170, 0 );
Effects.SendLocationEffect( new Point3D( from.X + 3, from.Y , from.Z ), from.Map, 0x376A, 34, 0, 2820, 0 );
Effects.SendLocationEffect( new Point3D( from.X +3, from.Y - 3, from.Z ), from.Map, 0x376A, 34, 0, 2820, 0 );
Effects.SendLocationEffect( new Point3D( from.X +3, from.Y + 3, from.Z ), from.Map, 0x376A, 34, 0, 2820, 0 );
Effects.SendLocationEffect( new Point3D( from.X - 3, from.Y , from.Z ), from.Map, 0x376A, 34, 0, 2820, 0 );
Effects.SendLocationEffect( new Point3D( from.X -3, from.Y - 3, from.Z ), from.Map, 0x376A, 34, 0, 2820, 0 );
Effects.SendLocationEffect( new Point3D( from.X -3, from.Y + 3, from.Z ), from.Map, 0x376A, 34, 0, 2820, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y + 3, from.Z ), from.Map, 0x376A, 34, 0, 2820, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y - 3, from.Z ), from.Map, 0x376A, 34, 0, 2820, 0 );
Effects.SendLocationEffect( new Point3D( from.X + 3, from.Y -2, from.Z ), from.Map, 0x376A, 34, 0, 2820, 0 );
Effects.SendLocationEffect( new Point3D( from.X +3, from.Y +2, from.Z ), from.Map, 0x376A, 34, 0, 2820, 0 );
Effects.SendLocationEffect( new Point3D( from.X +2, from.Y + 3, from.Z ), from.Map, 0x376A, 34, 0, 2820, 0 );
Effects.SendLocationEffect( new Point3D( from.X +2, from.Y -3, from.Z ), from.Map, 0x376A, 34, 0, 2820, 0 );
Effects.SendLocationEffect( new Point3D( from.X -3, from.Y - 2, from.Z ), from.Map, 0x376A, 34, 0, 2820, 0 );
Effects.SendLocationEffect( new Point3D( from.X -3, from.Y + 2, from.Z ), from.Map, 0x376A, 34, 0, 2820, 0 );
Effects.SendLocationEffect( new Point3D( from.X -2, from.Y + 3, from.Z ), from.Map, 0x376A, 34, 0, 2820, 0 );
Effects.SendLocationEffect( new Point3D( from.X -2, from.Y - 3, from.Z ), from.Map, 0x376A, 34, 0, 2820, 0 );
Effects.SendLocationEffect( new Point3D( from.X + 3, from.Y -1, from.Z ), from.Map, 0x376A, 34, 0, 2820, 0 );
Effects.SendLocationEffect( new Point3D( from.X +3, from.Y +1, from.Z ), from.Map, 0x376A, 34, 0, 2820, 0 );
Effects.SendLocationEffect( new Point3D( from.X +1, from.Y + 3, from.Z ), from.Map, 0x376A, 34, 0, 2820, 0 );
Effects.SendLocationEffect( new Point3D( from.X +1, from.Y -3, from.Z ), from.Map, 0x376A, 34, 0, 2820, 0 );
Effects.SendLocationEffect( new Point3D( from.X -3, from.Y - 1, from.Z ), from.Map, 0x376A, 34, 0, 2820, 0 );
Effects.SendLocationEffect( new Point3D( from.X -3, from.Y + 1, from.Z ), from.Map, 0x376A, 34, 0, 2820, 0 );
Effects.SendLocationEffect( new Point3D( from.X -1, from.Y + 3, from.Z ), from.Map, 0x376A, 34, 0, 2820, 0 );
Effects.SendLocationEffect( new Point3D( from.X -1, from.Y - 3, from.Z ), from.Map, 0x376A, 34, 0, 2820, 0 );
//Forth Row
Effects.SendLocationEffect( new Point3D( from.X + 4, from.Y , from.Z ), from.Map, 0x37C4, 32, 0, 1170, 0 );
Effects.SendLocationEffect( new Point3D( from.X - 4, from.Y , from.Z ), from.Map, 0x37C4, 32, 0, 1170, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y + 4, from.Z ), from.Map, 0x37C4, 32, 0, 1170, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y - 4, from.Z ), from.Map, 0x37C4, 32, 0, 1170, 0 );
Effects.SendLocationEffect( new Point3D( from.X -4, from.Y - 4, from.Z ), from.Map, 0x37C4, 32, 0, 1170, 0 );
Effects.SendLocationEffect( new Point3D( from.X +4, from.Y - 4, from.Z ), from.Map, 0x37C4, 32, 0, 1170, 0 );
Effects.SendLocationEffect( new Point3D( from.X -4, from.Y + 4, from.Z ), from.Map, 0x37C4, 32, 0, 1170, 0 );
Effects.SendLocationEffect( new Point3D( from.X +4, from.Y + 4, from.Z ), from.Map, 0x37C4, 32, 0, 1170, 0 );

Effects.SendLocationEffect( new Point3D( from.X + 4, from.Y , from.Z ), from.Map, 0x376A, 32, 0, 2820, 0 );
Effects.SendLocationEffect( new Point3D( from.X - 4, from.Y , from.Z ), from.Map, 0x376A, 32, 0, 2820, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y + 4, from.Z ), from.Map, 0x376A, 32, 0, 2820, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y - 4, from.Z ), from.Map, 0x376A, 32, 0, 2820, 0 );
Effects.SendLocationEffect( new Point3D( from.X -4, from.Y - 4, from.Z ), from.Map, 0x376A, 32, 0, 2820, 0 );
Effects.SendLocationEffect( new Point3D( from.X +4, from.Y - 4, from.Z ), from.Map, 0x376A, 32, 0, 2820, 0 );
Effects.SendLocationEffect( new Point3D( from.X -4, from.Y + 4, from.Z ), from.Map, 0x376A, 32, 0, 2820, 0 );
Effects.SendLocationEffect( new Point3D( from.X +4, from.Y + 4, from.Z ), from.Map, 0x376A, 32, 0, 2820, 0 );
//Fifth Row
Effects.SendLocationEffect( new Point3D( from.X + 5, from.Y , from.Z ), from.Map, 0x37C4, 30, 0, 1170, 0 );
Effects.SendLocationEffect( new Point3D( from.X - 5, from.Y , from.Z ), from.Map, 0x37C4, 30, 0, 1170, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y + 5, from.Z ), from.Map, 0x37C4, 30, 0, 1170, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y - 5, from.Z ), from.Map, 0x37C4, 30, 0, 1170, 0 );
Effects.SendLocationEffect( new Point3D( from.X -5, from.Y - 5, from.Z ), from.Map, 0x37C4, 30, 0, 1170, 0 );
Effects.SendLocationEffect( new Point3D( from.X +5, from.Y - 5, from.Z ), from.Map, 0x37C4, 30, 0, 1170, 0 );
Effects.SendLocationEffect( new Point3D( from.X -5, from.Y + 5, from.Z ), from.Map, 0x37C4, 30, 0, 1170, 0 );
Effects.SendLocationEffect( new Point3D( from.X +5, from.Y + 5, from.Z ), from.Map, 0x37C4, 30, 0, 1170, 0 );

Effects.SendLocationEffect( new Point3D( from.X + 5, from.Y , from.Z ), from.Map, 0x376A, 30, 0, 2820, 0 );
Effects.SendLocationEffect( new Point3D( from.X - 5, from.Y , from.Z ), from.Map, 0x376A, 30, 0, 2820, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y + 5, from.Z ), from.Map, 0x376A, 30, 0, 2820, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y - 5, from.Z ), from.Map, 0x376A, 30, 0, 2820, 0 );
Effects.SendLocationEffect( new Point3D( from.X -5, from.Y - 5, from.Z ), from.Map, 0x376A, 30, 0, 2820, 0 );
Effects.SendLocationEffect( new Point3D( from.X +5, from.Y - 5, from.Z ), from.Map, 0x376A, 30, 0, 2820, 0 );
Effects.SendLocationEffect( new Point3D( from.X -5, from.Y + 5, from.Z ), from.Map, 0x376A, 30, 0, 2820, 0 );
Effects.SendLocationEffect( new Point3D( from.X +5, from.Y + 5, from.Z ), from.Map, 0x376A, 30, 0, 2820, 0 );
           from.PlaySound( 0x244 );
	       from.Hidden = true;
           
            } 
            else 
            { 
           from.Hidden=false;
           from.Emote( from.Name + " appears in a *SPARKLE*");
Effects.SendLocationEffect( new Point3D( from.X, from.Y, from.Z ), from.Map, 0x37C4, 20, 0, 1170, 0 ); 
Effects.SendLocationEffect( new Point3D( from.X, from.Y, from.Z ), from.Map, 0x376A, 20, 0, 2820, 0 ); 
//First row
Effects.SendLocationEffect( new Point3D( from.X + 1, from.Y , from.Z ), from.Map, 0x37C4, 22, 0, 1170, 0 );
Effects.SendLocationEffect( new Point3D( from.X - 1, from.Y , from.Z ), from.Map, 0x37C4, 22, 0, 1170, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y + 1, from.Z ), from.Map, 0x37C4, 22, 0, 1170, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y - 1, from.Z ), from.Map, 0x37C4, 22, 0, 1170, 0 );
Effects.SendLocationEffect( new Point3D( from.X -1, from.Y - 1, from.Z ), from.Map, 0x37C4, 22, 0, 1170, 0 );
Effects.SendLocationEffect( new Point3D( from.X +1, from.Y - 1, from.Z ), from.Map, 0x37C4, 22, 0, 1170, 0 );
Effects.SendLocationEffect( new Point3D( from.X -1, from.Y + 1, from.Z ), from.Map, 0x37C4, 22, 0, 1170, 0 );
Effects.SendLocationEffect( new Point3D( from.X +1, from.Y + 1, from.Z ), from.Map, 0x37C4, 22, 0, 1170, 0 );
Effects.SendLocationEffect( new Point3D( from.X + 1, from.Y , from.Z ), from.Map, 0x376A, 22, 0, 2820, 0 );
Effects.SendLocationEffect( new Point3D( from.X - 1, from.Y , from.Z ), from.Map, 0x376A, 22, 0, 2820, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y + 1, from.Z ), from.Map, 0x376A, 22, 0, 2820, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y - 1, from.Z ), from.Map, 0x376A, 22, 0, 2820, 0 );
Effects.SendLocationEffect( new Point3D( from.X -1, from.Y - 1, from.Z ), from.Map, 0x376A, 22, 0, 2820, 0 );
Effects.SendLocationEffect( new Point3D( from.X +1, from.Y - 1, from.Z ), from.Map, 0x376A, 22, 0, 2820, 0 );
Effects.SendLocationEffect( new Point3D( from.X -1, from.Y + 1, from.Z ), from.Map, 0x376A, 22, 0, 2820, 0 );
Effects.SendLocationEffect( new Point3D( from.X +1, from.Y + 1, from.Z ), from.Map, 0x376A, 22, 0, 2820, 0 );
//Second Row
Effects.SendLocationEffect( new Point3D( from.X + 2, from.Y , from.Z ), from.Map, 0x37C4, 24, 0, 1170, 0 );
Effects.SendLocationEffect( new Point3D( from.X - 2, from.Y , from.Z ), from.Map, 0x37C4, 24, 0, 1170, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y + 2, from.Z ), from.Map, 0x37C4, 24, 0, 1170, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y - 2, from.Z ), from.Map, 0x37C4, 24, 0, 1170, 0 );
Effects.SendLocationEffect( new Point3D( from.X -2, from.Y - 2, from.Z ), from.Map, 0x37C4, 24, 0, 1170, 0 );
Effects.SendLocationEffect( new Point3D( from.X +2, from.Y - 2, from.Z ), from.Map, 0x37C4, 24, 0, 1170, 0 );
Effects.SendLocationEffect( new Point3D( from.X -2, from.Y + 2, from.Z ), from.Map, 0x37C4, 24, 0, 1170, 0 );
Effects.SendLocationEffect( new Point3D( from.X +2, from.Y + 2, from.Z ), from.Map, 0x37C4, 24, 0, 1170, 0 );
Effects.SendLocationEffect( new Point3D( from.X + 2, from.Y +1, from.Z ), from.Map, 0x37C4, 24, 0, 1170, 0 );
Effects.SendLocationEffect( new Point3D( from.X - 2, from.Y -1, from.Z ), from.Map, 0x37C4, 24, 0, 1170, 0 );
Effects.SendLocationEffect( new Point3D( from.X +1, from.Y + 2, from.Z ), from.Map, 0x37C4, 24, 0, 1170, 0 );
Effects.SendLocationEffect( new Point3D( from.X -1, from.Y - 2, from.Z ), from.Map, 0x37C4, 24, 0, 1170, 0 );
Effects.SendLocationEffect( new Point3D( from.X + 2, from.Y -1, from.Z ), from.Map, 0x37C4, 24, 0, 1170, 0 );
Effects.SendLocationEffect( new Point3D( from.X - 2, from.Y +1, from.Z ), from.Map, 0x37C4, 24, 0, 1170, 0 );
Effects.SendLocationEffect( new Point3D( from.X +1, from.Y - 2, from.Z ), from.Map, 0x37C4, 24, 0, 1170, 0 );
Effects.SendLocationEffect( new Point3D( from.X -1, from.Y + 2, from.Z ), from.Map, 0x37C4, 24, 0, 1170, 0 );
Effects.SendLocationEffect( new Point3D( from.X + 2, from.Y , from.Z ), from.Map, 0x376A, 24, 0, 2820, 0 );
Effects.SendLocationEffect( new Point3D( from.X - 2, from.Y , from.Z ), from.Map, 0x376A, 24, 0, 2820, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y + 2, from.Z ), from.Map, 0x376A, 24, 0, 2820, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y - 2, from.Z ), from.Map, 0x376A, 24, 0, 2820, 0 );
Effects.SendLocationEffect( new Point3D( from.X -2, from.Y - 2, from.Z ), from.Map, 0x376A, 24, 0, 2820, 0 );
Effects.SendLocationEffect( new Point3D( from.X +2, from.Y - 2, from.Z ), from.Map, 0x376A, 24, 0, 2820, 0 );
Effects.SendLocationEffect( new Point3D( from.X -2, from.Y + 2, from.Z ), from.Map, 0x376A, 24, 0, 2820, 0 );
Effects.SendLocationEffect( new Point3D( from.X +2, from.Y + 2, from.Z ), from.Map, 0x376A, 24, 0, 2820, 0 );
Effects.SendLocationEffect( new Point3D( from.X + 2, from.Y +1, from.Z ), from.Map, 0x376A, 24, 0, 2820, 0 );
Effects.SendLocationEffect( new Point3D( from.X - 2, from.Y -1, from.Z ), from.Map, 0x376A, 24, 0, 2820, 0 );
Effects.SendLocationEffect( new Point3D( from.X +1, from.Y + 2, from.Z ), from.Map, 0x376A, 24, 0, 2820, 0 );
Effects.SendLocationEffect( new Point3D( from.X -1, from.Y - 2, from.Z ), from.Map, 0x376A, 24, 0, 2820, 0 );
Effects.SendLocationEffect( new Point3D( from.X + 2, from.Y -1, from.Z ), from.Map, 0x376A, 24, 0, 2820, 0 );
Effects.SendLocationEffect( new Point3D( from.X - 2, from.Y +1, from.Z ), from.Map, 0x376A, 24, 0, 2820, 0 );
Effects.SendLocationEffect( new Point3D( from.X +1, from.Y - 2, from.Z ), from.Map, 0x376A, 24, 0, 2820, 0 );
Effects.SendLocationEffect( new Point3D( from.X -1, from.Y + 2, from.Z ), from.Map, 0x376A, 24, 0, 2820, 0 );
//Third Row
Effects.SendLocationEffect( new Point3D( from.X + 3, from.Y , from.Z ), from.Map, 0x37C4, 26, 0, 1170, 0 );
Effects.SendLocationEffect( new Point3D( from.X +3, from.Y + 3, from.Z ), from.Map, 0x37C4, 26, 0, 1170, 0 );
Effects.SendLocationEffect( new Point3D( from.X +3, from.Y - 3, from.Z ), from.Map, 0x37C4, 26, 0, 1170, 0 );
Effects.SendLocationEffect( new Point3D( from.X - 3, from.Y , from.Z ), from.Map, 0x37C4, 26, 0, 1170, 0 );
Effects.SendLocationEffect( new Point3D( from.X -3, from.Y - 3, from.Z ), from.Map, 0x37C4, 26, 0, 1170, 0 );
Effects.SendLocationEffect( new Point3D( from.X -3, from.Y + 3, from.Z ), from.Map, 0x37C4, 26, 0, 1170, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y + 3, from.Z ), from.Map, 0x37C4, 26, 0, 1170, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y - 3, from.Z ), from.Map, 0x37C4, 26, 0, 1170, 0 );
Effects.SendLocationEffect( new Point3D( from.X + 3, from.Y +2, from.Z ), from.Map, 0x37C4, 26, 0, 1170, 0 );
Effects.SendLocationEffect( new Point3D( from.X -3, from.Y - 2, from.Z ), from.Map, 0x37C4, 26, 0, 1170, 0 );
Effects.SendLocationEffect( new Point3D( from.X +2, from.Y + 3, from.Z ), from.Map, 0x37C4, 26, 0, 1170, 0 );
Effects.SendLocationEffect( new Point3D( from.X - 2, from.Y -3, from.Z ), from.Map, 0x37C4, 26, 0, 1170, 0 );
Effects.SendLocationEffect( new Point3D( from.X +3, from.Y - 2, from.Z ), from.Map, 0x37C4, 26, 0, 1170, 0 );
Effects.SendLocationEffect( new Point3D( from.X -3, from.Y + 2, from.Z ), from.Map, 0x37C4, 26, 0, 1170, 0 );
Effects.SendLocationEffect( new Point3D( from.X +2, from.Y - 3, from.Z ), from.Map, 0x37C4, 26, 0, 1170, 0 );
Effects.SendLocationEffect( new Point3D( from.X -2, from.Y + 3, from.Z ), from.Map, 0x37C4, 26, 0, 1170, 0 );
Effects.SendLocationEffect( new Point3D( from.X + 3, from.Y +1, from.Z ), from.Map, 0x37C4, 26, 0, 1170, 0 );
Effects.SendLocationEffect( new Point3D( from.X -3, from.Y - 1, from.Z ), from.Map, 0x37C4, 26, 0, 1170, 0 );
Effects.SendLocationEffect( new Point3D( from.X +1, from.Y + 3, from.Z ), from.Map, 0x37C4, 26, 0, 1170, 0 );
Effects.SendLocationEffect( new Point3D( from.X - 1, from.Y -3, from.Z ), from.Map, 0x37C4, 26, 0, 1170, 0 );
Effects.SendLocationEffect( new Point3D( from.X +3, from.Y - 1, from.Z ), from.Map, 0x37C4, 26, 0, 1170, 0 );
Effects.SendLocationEffect( new Point3D( from.X -3, from.Y + 1, from.Z ), from.Map, 0x37C4, 26, 0, 1170, 0 );
Effects.SendLocationEffect( new Point3D( from.X +1, from.Y - 3, from.Z ), from.Map, 0x37C4, 26, 0, 1170, 0 );
Effects.SendLocationEffect( new Point3D( from.X -1, from.Y + 3, from.Z ), from.Map, 0x37C4, 26, 0, 1170, 0 );
Effects.SendLocationEffect( new Point3D( from.X + 3, from.Y , from.Z ), from.Map, 0x376A, 26, 0, 2820, 0 );
Effects.SendLocationEffect( new Point3D( from.X +3, from.Y + 3, from.Z ), from.Map, 0x376A, 26, 0, 2820, 0 );
Effects.SendLocationEffect( new Point3D( from.X +3, from.Y - 3, from.Z ), from.Map, 0x376A, 26, 0, 2820, 0 );
Effects.SendLocationEffect( new Point3D( from.X - 3, from.Y , from.Z ), from.Map, 0x376A, 26, 0, 2820, 0 );
Effects.SendLocationEffect( new Point3D( from.X -3, from.Y - 3, from.Z ), from.Map, 0x376A, 26, 0, 2820, 0 );
Effects.SendLocationEffect( new Point3D( from.X -3, from.Y + 3, from.Z ), from.Map, 0x376A, 26, 0, 2820, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y + 3, from.Z ), from.Map, 0x376A, 26, 0, 2820, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y - 3, from.Z ), from.Map, 0x376A, 26, 0, 2820, 0 );
Effects.SendLocationEffect( new Point3D( from.X + 3, from.Y +2, from.Z ), from.Map, 0x376A, 26, 0, 2820, 0 );
Effects.SendLocationEffect( new Point3D( from.X -3, from.Y - 2, from.Z ), from.Map, 0x376A, 26, 0, 2820, 0 );
Effects.SendLocationEffect( new Point3D( from.X +2, from.Y + 3, from.Z ), from.Map, 0x376A, 26, 0, 2820, 0 );
Effects.SendLocationEffect( new Point3D( from.X - 2, from.Y -3, from.Z ), from.Map, 0x376A, 26, 0, 2820, 0 );
Effects.SendLocationEffect( new Point3D( from.X +3, from.Y - 2, from.Z ), from.Map, 0x376A, 26, 0, 2820, 0 );
Effects.SendLocationEffect( new Point3D( from.X -3, from.Y + 2, from.Z ), from.Map, 0x376A, 26, 0, 2820, 0 );
Effects.SendLocationEffect( new Point3D( from.X +2, from.Y - 3, from.Z ), from.Map, 0x376A, 26, 0, 2820, 0 );
Effects.SendLocationEffect( new Point3D( from.X -2, from.Y + 3, from.Z ), from.Map, 0x376A, 26, 0, 2820, 0 );
Effects.SendLocationEffect( new Point3D( from.X + 3, from.Y +1, from.Z ), from.Map, 0x376A, 26, 0, 2820, 0 );
Effects.SendLocationEffect( new Point3D( from.X -3, from.Y - 1, from.Z ), from.Map, 0x376A, 26, 0, 2820, 0 );
Effects.SendLocationEffect( new Point3D( from.X +1, from.Y + 3, from.Z ), from.Map, 0x376A, 26, 0, 2820, 0 );
Effects.SendLocationEffect( new Point3D( from.X - 1, from.Y -3, from.Z ), from.Map, 0x376A, 26, 0, 2820, 0 );
Effects.SendLocationEffect( new Point3D( from.X +3, from.Y - 1, from.Z ), from.Map, 0x376A, 26, 0, 2820, 0 );
Effects.SendLocationEffect( new Point3D( from.X -3, from.Y + 1, from.Z ), from.Map, 0x376A, 26, 0, 2820, 0 );
Effects.SendLocationEffect( new Point3D( from.X +1, from.Y - 3, from.Z ), from.Map, 0x376A, 26, 0, 2820, 0 );
Effects.SendLocationEffect( new Point3D( from.X -1, from.Y + 3, from.Z ), from.Map, 0x376A, 26, 0, 2820, 0 );
//Forth Row
Effects.SendLocationEffect( new Point3D( from.X + 4, from.Y , from.Z ), from.Map, 0x37C4, 28, 0, 1170, 0 );
Effects.SendLocationEffect( new Point3D( from.X - 4, from.Y , from.Z ), from.Map, 0x37C4, 28, 0, 1170, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y + 4, from.Z ), from.Map, 0x37C4, 28, 0, 1170, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y - 4, from.Z ), from.Map, 0x37C4, 28, 0, 1170, 0 );
Effects.SendLocationEffect( new Point3D( from.X -4, from.Y - 4, from.Z ), from.Map, 0x37C4, 28, 0, 1170, 0 );
Effects.SendLocationEffect( new Point3D( from.X +4, from.Y - 4, from.Z ), from.Map, 0x37C4, 28, 0, 1170, 0 );
Effects.SendLocationEffect( new Point3D( from.X -4, from.Y + 4, from.Z ), from.Map, 0x37C4, 28, 0, 1170, 0 );
Effects.SendLocationEffect( new Point3D( from.X +4, from.Y + 4, from.Z ), from.Map, 0x37C4, 28, 0, 1170, 0 );

Effects.SendLocationEffect( new Point3D( from.X + 4, from.Y , from.Z ), from.Map, 0x376A, 28, 0, 2820, 0 );
Effects.SendLocationEffect( new Point3D( from.X - 4, from.Y , from.Z ), from.Map, 0x376A, 28, 0, 2820, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y + 4, from.Z ), from.Map, 0x376A, 28, 0, 2820, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y - 4, from.Z ), from.Map, 0x376A, 28, 0, 2820, 0 );
Effects.SendLocationEffect( new Point3D( from.X -4, from.Y - 4, from.Z ), from.Map, 0x376A, 28, 0, 2820, 0 );
Effects.SendLocationEffect( new Point3D( from.X +4, from.Y - 4, from.Z ), from.Map, 0x376A, 28, 0, 2820, 0 );
Effects.SendLocationEffect( new Point3D( from.X -4, from.Y + 4, from.Z ), from.Map, 0x376A, 28, 0, 2820, 0 );
Effects.SendLocationEffect( new Point3D( from.X +4, from.Y + 4, from.Z ), from.Map, 0x376A, 28, 0, 2820, 0 );
//Fifth Row
Effects.SendLocationEffect( new Point3D( from.X + 5, from.Y , from.Z ), from.Map, 0x37C4, 30, 0, 1170, 0 );
Effects.SendLocationEffect( new Point3D( from.X - 5, from.Y , from.Z ), from.Map, 0x37C4, 30, 0, 1170, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y + 5, from.Z ), from.Map, 0x37C4, 30, 0, 1170, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y - 5, from.Z ), from.Map, 0x37C4, 30, 0, 1170, 0 );
Effects.SendLocationEffect( new Point3D( from.X -5, from.Y - 5, from.Z ), from.Map, 0x37C4, 30, 0, 1170, 0 );
Effects.SendLocationEffect( new Point3D( from.X +5, from.Y - 5, from.Z ), from.Map, 0x37C4, 30, 0, 1170, 0 );
Effects.SendLocationEffect( new Point3D( from.X -5, from.Y + 5, from.Z ), from.Map, 0x37C4, 30, 0, 1170, 0 );
Effects.SendLocationEffect( new Point3D( from.X +5, from.Y + 5, from.Z ), from.Map, 0x37C4, 30, 0, 1170, 0 );

Effects.SendLocationEffect( new Point3D( from.X + 5, from.Y , from.Z ), from.Map, 0x376A, 30, 0, 2820, 0 );
Effects.SendLocationEffect( new Point3D( from.X - 5, from.Y , from.Z ), from.Map, 0x376A, 30, 0, 2820, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y + 5, from.Z ), from.Map, 0x376A, 30, 0, 2820, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y - 5, from.Z ), from.Map, 0x376A, 30, 0, 2820, 0 );
Effects.SendLocationEffect( new Point3D( from.X -5, from.Y - 5, from.Z ), from.Map, 0x376A, 30, 0, 2820, 0 );
Effects.SendLocationEffect( new Point3D( from.X +5, from.Y - 5, from.Z ), from.Map, 0x376A, 30, 0, 2820, 0 );
Effects.SendLocationEffect( new Point3D( from.X -5, from.Y + 5, from.Z ), from.Map, 0x376A, 30, 0, 2820, 0 );
Effects.SendLocationEffect( new Point3D( from.X +5, from.Y + 5, from.Z ), from.Map, 0x376A, 30, 0, 2820, 0 );
           from.PlaySound( 0x244 );
                      
            } 
      } 
	}


       
      public SymphonysHidingRobe( Serial serial ) : base( serial ) 
      { 
          
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