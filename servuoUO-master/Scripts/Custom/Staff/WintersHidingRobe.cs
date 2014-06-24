using System; 
using Server; 
using Server.Misc;
using Server.Items; 
using Server.Targeting; 

namespace Server.Items 
{ 
   [FlipableAttribute( 0x7939, 0x7940 )] 
   public class WintersHidingRobe  : BaseOuterTorso  
   { 
      [Constructable] 
      public WintersHidingRobe() :  base( 0x204F ) 
      { 
         Weight = 1.0; 
         Hue = 2061; 
         Name = "Winter's Hiding Robe"; 
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
           from.Emote( "*" + from.Name + "* disappears in a storm! *" );
Effects.SendLocationEffect( new Point3D( from.X, from.Y, from.Z ), from.Map, 0x37CC, 40, 0, 2061, 0 ); 
Effects.SendLocationEffect( new Point3D( from.X, from.Y, from.Z ), from.Map, 0x374A, 40, 0, 2061, 0 ); 
from.BoltEffect(2061);
//First row
Effects.SendLocationEffect( new Point3D( from.X + 1, from.Y , from.Z ), from.Map, 0x37CC, 38, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X - 1, from.Y , from.Z ), from.Map, 0x37CC, 38, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y + 1, from.Z ), from.Map, 0x37CC, 38, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y - 1, from.Z ), from.Map, 0x37CC, 38, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X -1, from.Y - 1, from.Z ), from.Map, 0x37CC, 38, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X +1, from.Y - 1, from.Z ), from.Map, 0x37CC, 38, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X -1, from.Y + 1, from.Z ), from.Map, 0x37CC, 38, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X +1, from.Y + 1, from.Z ), from.Map, 0x37CC, 38, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X + 1, from.Y , from.Z ), from.Map, 0x374A, 38, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X - 1, from.Y , from.Z ), from.Map, 0x374A, 38, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y + 1, from.Z ), from.Map, 0x374A, 38, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y - 1, from.Z ), from.Map, 0x374A, 38, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X -1, from.Y - 1, from.Z ), from.Map, 0x374A, 38, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X +1, from.Y - 1, from.Z ), from.Map, 0x374A, 38, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X -1, from.Y + 1, from.Z ), from.Map, 0x374A, 38, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X +1, from.Y + 1, from.Z ), from.Map, 0x374A, 38, 0, 2061, 0 );
//Second Row
Effects.SendLocationEffect( new Point3D( from.X + 2, from.Y , from.Z ), from.Map, 0x37CC, 36, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X - 2, from.Y , from.Z ), from.Map, 0x37CC, 36, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y + 2, from.Z ), from.Map, 0x37CC, 36, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y - 2, from.Z ), from.Map, 0x37CC, 36, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X -2, from.Y - 2, from.Z ), from.Map, 0x37CC, 36, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X +2, from.Y - 2, from.Z ), from.Map, 0x37CC, 36, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X -2, from.Y + 2, from.Z ), from.Map, 0x37CC, 36, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X +2, from.Y + 2, from.Z ), from.Map, 0x37CC, 36, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X + 2, from.Y +1, from.Z ), from.Map, 0x37CC, 36, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X - 2, from.Y -1, from.Z ), from.Map, 0x37CC, 36, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X +1, from.Y + 2, from.Z ), from.Map, 0x37CC, 36, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X -1, from.Y - 2, from.Z ), from.Map, 0x37CC, 36, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X + 2, from.Y -1, from.Z ), from.Map, 0x37CC, 36, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X - 2, from.Y +1, from.Z ), from.Map, 0x37CC, 36, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X +1, from.Y - 2, from.Z ), from.Map, 0x37CC, 36, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X -1, from.Y + 2, from.Z ), from.Map, 0x37CC, 36, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X + 2, from.Y , from.Z ), from.Map, 0x374A, 36, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X - 2, from.Y , from.Z ), from.Map, 0x374A, 36, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y + 2, from.Z ), from.Map, 0x374A, 36, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y - 2, from.Z ), from.Map, 0x374A, 36, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X -2, from.Y - 2, from.Z ), from.Map, 0x374A, 36, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X +2, from.Y - 2, from.Z ), from.Map, 0x374A, 36, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X -2, from.Y + 2, from.Z ), from.Map, 0x374A, 36, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X +2, from.Y + 2, from.Z ), from.Map, 0x374A, 36, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X + 2, from.Y +1, from.Z ), from.Map, 0x374A, 36, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X - 2, from.Y -1, from.Z ), from.Map, 0x374A, 36, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X +1, from.Y + 2, from.Z ), from.Map, 0x374A, 36, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X -1, from.Y - 2, from.Z ), from.Map, 0x374A, 36, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X + 2, from.Y -1, from.Z ), from.Map, 0x374A, 36, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X - 2, from.Y +1, from.Z ), from.Map, 0x374A, 36, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X +1, from.Y - 2, from.Z ), from.Map, 0x374A, 36, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X -1, from.Y + 2, from.Z ), from.Map, 0x374A, 36, 0, 2061, 0 );
//Third Row
Effects.SendLocationEffect( new Point3D( from.X + 3, from.Y , from.Z ), from.Map, 0x37CC, 34, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X +3, from.Y - 3, from.Z ), from.Map, 0x37CC, 34, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X +3, from.Y + 3, from.Z ), from.Map, 0x37CC, 34, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X - 3, from.Y , from.Z ), from.Map, 0x37CC, 34, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X -3, from.Y - 3, from.Z ), from.Map, 0x37CC, 34, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X -3, from.Y + 3, from.Z ), from.Map, 0x37CC, 34, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y + 3, from.Z ), from.Map, 0x37CC, 34, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y - 3, from.Z ), from.Map, 0x37CC, 34, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X + 3, from.Y -2, from.Z ), from.Map, 0x37CC, 34, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X +3, from.Y +2, from.Z ), from.Map, 0x37CC, 34, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X +2, from.Y + 3, from.Z ), from.Map, 0x37CC, 34, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X +2, from.Y -3, from.Z ), from.Map, 0x37CC, 34, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X -3, from.Y - 2, from.Z ), from.Map, 0x37CC, 34, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X -3, from.Y + 2, from.Z ), from.Map, 0x37CC, 34, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X -2, from.Y + 3, from.Z ), from.Map, 0x37CC, 34, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X -2, from.Y - 3, from.Z ), from.Map, 0x37CC, 34, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X + 3, from.Y -1, from.Z ), from.Map, 0x37CC, 34, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X +3, from.Y +1, from.Z ), from.Map, 0x37CC, 34, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X +1, from.Y + 3, from.Z ), from.Map, 0x37CC, 34, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X +1, from.Y -3, from.Z ), from.Map, 0x37CC, 34, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X -3, from.Y - 1, from.Z ), from.Map, 0x37CC, 34, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X -3, from.Y + 1, from.Z ), from.Map, 0x37CC, 34, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X -1, from.Y + 3, from.Z ), from.Map, 0x37CC, 34, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X -1, from.Y - 3, from.Z ), from.Map, 0x37CC, 34, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X + 3, from.Y , from.Z ), from.Map, 0x374A, 34, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X +3, from.Y - 3, from.Z ), from.Map, 0x374A, 34, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X +3, from.Y + 3, from.Z ), from.Map, 0x374A, 34, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X - 3, from.Y , from.Z ), from.Map, 0x374A, 34, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X -3, from.Y - 3, from.Z ), from.Map, 0x374A, 34, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X -3, from.Y + 3, from.Z ), from.Map, 0x374A, 34, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y + 3, from.Z ), from.Map, 0x374A, 34, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y - 3, from.Z ), from.Map, 0x374A, 34, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X + 3, from.Y -2, from.Z ), from.Map, 0x374A, 34, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X +3, from.Y +2, from.Z ), from.Map, 0x374A, 34, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X +2, from.Y + 3, from.Z ), from.Map, 0x374A, 34, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X +2, from.Y -3, from.Z ), from.Map, 0x374A, 34, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X -3, from.Y - 2, from.Z ), from.Map, 0x374A, 34, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X -3, from.Y + 2, from.Z ), from.Map, 0x374A, 34, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X -2, from.Y + 3, from.Z ), from.Map, 0x374A, 34, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X -2, from.Y - 3, from.Z ), from.Map, 0x374A, 34, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X + 3, from.Y -1, from.Z ), from.Map, 0x374A, 34, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X +3, from.Y +1, from.Z ), from.Map, 0x374A, 34, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X +1, from.Y + 3, from.Z ), from.Map, 0x374A, 34, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X +1, from.Y -3, from.Z ), from.Map, 0x374A, 34, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X -3, from.Y - 1, from.Z ), from.Map, 0x374A, 34, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X -3, from.Y + 1, from.Z ), from.Map, 0x374A, 34, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X -1, from.Y + 3, from.Z ), from.Map, 0x374A, 34, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X -1, from.Y - 3, from.Z ), from.Map, 0x374A, 34, 0, 2061, 0 );
//Forth Row
Effects.SendLocationEffect( new Point3D( from.X + 4, from.Y , from.Z ), from.Map, 0x37CC, 32, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X - 4, from.Y , from.Z ), from.Map, 0x37CC, 32, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y + 4, from.Z ), from.Map, 0x37CC, 32, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y - 4, from.Z ), from.Map, 0x37CC, 32, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X -4, from.Y - 4, from.Z ), from.Map, 0x37CC, 32, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X +4, from.Y - 4, from.Z ), from.Map, 0x37CC, 32, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X -4, from.Y + 4, from.Z ), from.Map, 0x37CC, 32, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X +4, from.Y + 4, from.Z ), from.Map, 0x37CC, 32, 0, 2061, 0 );

Effects.SendLocationEffect( new Point3D( from.X + 4, from.Y , from.Z ), from.Map, 0x374A, 32, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X - 4, from.Y , from.Z ), from.Map, 0x374A, 32, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y + 4, from.Z ), from.Map, 0x374A, 32, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y - 4, from.Z ), from.Map, 0x374A, 32, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X -4, from.Y - 4, from.Z ), from.Map, 0x374A, 32, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X +4, from.Y - 4, from.Z ), from.Map, 0x374A, 32, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X -4, from.Y + 4, from.Z ), from.Map, 0x374A, 32, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X +4, from.Y + 4, from.Z ), from.Map, 0x374A, 32, 0, 2061, 0 );
//Fifth Row
Effects.SendLocationEffect( new Point3D( from.X + 5, from.Y , from.Z ), from.Map, 0x37CC, 30, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X - 5, from.Y , from.Z ), from.Map, 0x37CC, 30, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y + 5, from.Z ), from.Map, 0x37CC, 30, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y - 5, from.Z ), from.Map, 0x37CC, 30, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X -5, from.Y - 5, from.Z ), from.Map, 0x37CC, 30, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X +5, from.Y - 5, from.Z ), from.Map, 0x37CC, 30, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X -5, from.Y + 5, from.Z ), from.Map, 0x37CC, 30, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X +5, from.Y + 5, from.Z ), from.Map, 0x37CC, 30, 0, 2061, 0 );

Effects.SendLocationEffect( new Point3D( from.X + 5, from.Y , from.Z ), from.Map, 0x374A, 30, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X - 5, from.Y , from.Z ), from.Map, 0x374A, 30, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y + 5, from.Z ), from.Map, 0x374A, 30, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y - 5, from.Z ), from.Map, 0x374A, 30, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X -5, from.Y - 5, from.Z ), from.Map, 0x374A, 30, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X +5, from.Y - 5, from.Z ), from.Map, 0x374A, 30, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X -5, from.Y + 5, from.Z ), from.Map, 0x374A, 30, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X +5, from.Y + 5, from.Z ), from.Map, 0x374A, 30, 0, 2061, 0 );
           from.PlaySound( 0x244 );
	       from.Hidden = true;
           
            } 
            else 
            { 
           from.Hidden=false;
           from.Emote( "*" + from.Name + "* appears in the eye of a storm!  *");
Effects.SendLocationEffect( new Point3D( from.X, from.Y, from.Z ), from.Map, 0x37CC, 20, 0, 2061, 0 ); 
Effects.SendLocationEffect( new Point3D( from.X, from.Y, from.Z ), from.Map, 0x374A, 20, 0, 2061, 0 ); 
from.BoltEffect(2061);
//First row
Effects.SendLocationEffect( new Point3D( from.X + 1, from.Y , from.Z ), from.Map, 0x37CC, 22, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X - 1, from.Y , from.Z ), from.Map, 0x37CC, 22, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y + 1, from.Z ), from.Map, 0x37CC, 22, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y - 1, from.Z ), from.Map, 0x37CC, 22, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X -1, from.Y - 1, from.Z ), from.Map, 0x37CC, 22, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X +1, from.Y - 1, from.Z ), from.Map, 0x37CC, 22, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X -1, from.Y + 1, from.Z ), from.Map, 0x37CC, 22, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X +1, from.Y + 1, from.Z ), from.Map, 0x37CC, 22, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X + 1, from.Y , from.Z ), from.Map, 0x374A, 22, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X - 1, from.Y , from.Z ), from.Map, 0x374A, 22, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y + 1, from.Z ), from.Map, 0x374A, 22, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y - 1, from.Z ), from.Map, 0x374A, 22, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X -1, from.Y - 1, from.Z ), from.Map, 0x374A, 22, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X +1, from.Y - 1, from.Z ), from.Map, 0x374A, 22, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X -1, from.Y + 1, from.Z ), from.Map, 0x374A, 22, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X +1, from.Y + 1, from.Z ), from.Map, 0x374A, 22, 0, 2061, 0 );
//Second Row
Effects.SendLocationEffect( new Point3D( from.X + 2, from.Y , from.Z ), from.Map, 0x37CC, 24, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X - 2, from.Y , from.Z ), from.Map, 0x37CC, 24, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y + 2, from.Z ), from.Map, 0x37CC, 24, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y - 2, from.Z ), from.Map, 0x37CC, 24, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X -2, from.Y - 2, from.Z ), from.Map, 0x37CC, 24, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X +2, from.Y - 2, from.Z ), from.Map, 0x37CC, 24, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X -2, from.Y + 2, from.Z ), from.Map, 0x37CC, 24, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X +2, from.Y + 2, from.Z ), from.Map, 0x37CC, 24, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X + 2, from.Y +1, from.Z ), from.Map, 0x37CC, 24, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X - 2, from.Y -1, from.Z ), from.Map, 0x37CC, 24, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X +1, from.Y + 2, from.Z ), from.Map, 0x37CC, 24, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X -1, from.Y - 2, from.Z ), from.Map, 0x37CC, 24, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X + 2, from.Y -1, from.Z ), from.Map, 0x37CC, 24, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X - 2, from.Y +1, from.Z ), from.Map, 0x37CC, 24, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X +1, from.Y - 2, from.Z ), from.Map, 0x37CC, 24, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X -1, from.Y + 2, from.Z ), from.Map, 0x37CC, 24, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X + 2, from.Y , from.Z ), from.Map, 0x374A, 24, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X - 2, from.Y , from.Z ), from.Map, 0x374A, 24, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y + 2, from.Z ), from.Map, 0x374A, 24, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y - 2, from.Z ), from.Map, 0x374A, 24, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X -2, from.Y - 2, from.Z ), from.Map, 0x374A, 24, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X +2, from.Y - 2, from.Z ), from.Map, 0x374A, 24, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X -2, from.Y + 2, from.Z ), from.Map, 0x374A, 24, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X +2, from.Y + 2, from.Z ), from.Map, 0x374A, 24, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X + 2, from.Y +1, from.Z ), from.Map, 0x374A, 24, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X - 2, from.Y -1, from.Z ), from.Map, 0x374A, 24, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X +1, from.Y + 2, from.Z ), from.Map, 0x374A, 24, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X -1, from.Y - 2, from.Z ), from.Map, 0x374A, 24, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X + 2, from.Y -1, from.Z ), from.Map, 0x374A, 24, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X - 2, from.Y +1, from.Z ), from.Map, 0x374A, 24, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X +1, from.Y - 2, from.Z ), from.Map, 0x374A, 24, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X -1, from.Y + 2, from.Z ), from.Map, 0x374A, 24, 0, 2061, 0 );
//Third Row
Effects.SendLocationEffect( new Point3D( from.X + 3, from.Y , from.Z ), from.Map, 0x37CC, 26, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X +3, from.Y + 3, from.Z ), from.Map, 0x37CC, 26, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X +3, from.Y - 3, from.Z ), from.Map, 0x37CC, 26, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X - 3, from.Y , from.Z ), from.Map, 0x37CC, 26, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X -3, from.Y - 3, from.Z ), from.Map, 0x37CC, 26, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X -3, from.Y + 3, from.Z ), from.Map, 0x37CC, 26, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y + 3, from.Z ), from.Map, 0x37CC, 26, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y - 3, from.Z ), from.Map, 0x37CC, 26, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X + 3, from.Y +2, from.Z ), from.Map, 0x37CC, 26, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X -3, from.Y - 2, from.Z ), from.Map, 0x37CC, 26, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X +2, from.Y + 3, from.Z ), from.Map, 0x37CC, 26, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X - 2, from.Y -3, from.Z ), from.Map, 0x37CC, 26, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X +3, from.Y - 2, from.Z ), from.Map, 0x37CC, 26, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X -3, from.Y + 2, from.Z ), from.Map, 0x37CC, 26, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X +2, from.Y - 3, from.Z ), from.Map, 0x37CC, 26, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X -2, from.Y + 3, from.Z ), from.Map, 0x37CC, 26, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X + 3, from.Y +1, from.Z ), from.Map, 0x37CC, 26, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X -3, from.Y - 1, from.Z ), from.Map, 0x37CC, 26, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X +1, from.Y + 3, from.Z ), from.Map, 0x37CC, 26, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X - 1, from.Y -3, from.Z ), from.Map, 0x37CC, 26, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X +3, from.Y - 1, from.Z ), from.Map, 0x37CC, 26, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X -3, from.Y + 1, from.Z ), from.Map, 0x37CC, 26, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X +1, from.Y - 3, from.Z ), from.Map, 0x37CC, 26, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X -1, from.Y + 3, from.Z ), from.Map, 0x37CC, 26, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X + 3, from.Y , from.Z ), from.Map, 0x374A, 26, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X +3, from.Y + 3, from.Z ), from.Map, 0x374A, 26, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X +3, from.Y - 3, from.Z ), from.Map, 0x374A, 26, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X - 3, from.Y , from.Z ), from.Map, 0x374A, 26, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X -3, from.Y - 3, from.Z ), from.Map, 0x374A, 26, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X -3, from.Y + 3, from.Z ), from.Map, 0x374A, 26, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y + 3, from.Z ), from.Map, 0x374A, 26, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y - 3, from.Z ), from.Map, 0x374A, 26, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X + 3, from.Y +2, from.Z ), from.Map, 0x374A, 26, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X -3, from.Y - 2, from.Z ), from.Map, 0x374A, 26, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X +2, from.Y + 3, from.Z ), from.Map, 0x374A, 26, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X - 2, from.Y -3, from.Z ), from.Map, 0x374A, 26, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X +3, from.Y - 2, from.Z ), from.Map, 0x374A, 26, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X -3, from.Y + 2, from.Z ), from.Map, 0x374A, 26, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X +2, from.Y - 3, from.Z ), from.Map, 0x374A, 26, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X -2, from.Y + 3, from.Z ), from.Map, 0x374A, 26, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X + 3, from.Y +1, from.Z ), from.Map, 0x374A, 26, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X -3, from.Y - 1, from.Z ), from.Map, 0x374A, 26, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X +1, from.Y + 3, from.Z ), from.Map, 0x374A, 26, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X - 1, from.Y -3, from.Z ), from.Map, 0x374A, 26, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X +3, from.Y - 1, from.Z ), from.Map, 0x374A, 26, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X -3, from.Y + 1, from.Z ), from.Map, 0x374A, 26, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X +1, from.Y - 3, from.Z ), from.Map, 0x374A, 26, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X -1, from.Y + 3, from.Z ), from.Map, 0x374A, 26, 0, 2061, 0 );
//Forth Row
Effects.SendLocationEffect( new Point3D( from.X + 4, from.Y , from.Z ), from.Map, 0x37CC, 28, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X - 4, from.Y , from.Z ), from.Map, 0x37CC, 28, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y + 4, from.Z ), from.Map, 0x37CC, 28, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y - 4, from.Z ), from.Map, 0x37CC, 28, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X -4, from.Y - 4, from.Z ), from.Map, 0x37CC, 28, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X +4, from.Y - 4, from.Z ), from.Map, 0x37CC, 28, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X -4, from.Y + 4, from.Z ), from.Map, 0x37CC, 28, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X +4, from.Y + 4, from.Z ), from.Map, 0x37CC, 28, 0, 2061, 0 );

Effects.SendLocationEffect( new Point3D( from.X + 4, from.Y , from.Z ), from.Map, 0x374A, 28, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X - 4, from.Y , from.Z ), from.Map, 0x374A, 28, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y + 4, from.Z ), from.Map, 0x374A, 28, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y - 4, from.Z ), from.Map, 0x374A, 28, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X -4, from.Y - 4, from.Z ), from.Map, 0x374A, 28, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X +4, from.Y - 4, from.Z ), from.Map, 0x374A, 28, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X -4, from.Y + 4, from.Z ), from.Map, 0x374A, 28, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X +4, from.Y + 4, from.Z ), from.Map, 0x374A, 28, 0, 2061, 0 );
//Fifth Row
Effects.SendLocationEffect( new Point3D( from.X + 5, from.Y , from.Z ), from.Map, 0x37CC, 30, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X - 5, from.Y , from.Z ), from.Map, 0x37CC, 30, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y + 5, from.Z ), from.Map, 0x37CC, 30, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y - 5, from.Z ), from.Map, 0x37CC, 30, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X -5, from.Y - 5, from.Z ), from.Map, 0x37CC, 30, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X +5, from.Y - 5, from.Z ), from.Map, 0x37CC, 30, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X -5, from.Y + 5, from.Z ), from.Map, 0x37CC, 30, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X +5, from.Y + 5, from.Z ), from.Map, 0x37CC, 30, 0, 2061, 0 );

Effects.SendLocationEffect( new Point3D( from.X + 5, from.Y , from.Z ), from.Map, 0x374A, 30, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X - 5, from.Y , from.Z ), from.Map, 0x374A, 30, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y + 5, from.Z ), from.Map, 0x374A, 30, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y - 5, from.Z ), from.Map, 0x374A, 30, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X -5, from.Y - 5, from.Z ), from.Map, 0x374A, 30, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X +5, from.Y - 5, from.Z ), from.Map, 0x374A, 30, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X -5, from.Y + 5, from.Z ), from.Map, 0x374A, 30, 0, 2061, 0 );
Effects.SendLocationEffect( new Point3D( from.X +5, from.Y + 5, from.Z ), from.Map, 0x374A, 30, 0, 2061, 0 );
           from.PlaySound( 0x244 );
                      
            } 
      } 
}


       
      public WintersHidingRobe( Serial serial ) : base( serial ) 
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