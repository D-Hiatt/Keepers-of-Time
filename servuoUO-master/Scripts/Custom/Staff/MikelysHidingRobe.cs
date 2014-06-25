using System; 
using Server; 
using Server.Misc;
using Server.Items; 
using Server.Targeting; 

namespace Server.Items 
{ 
   [FlipableAttribute( 0x7939, 0x7940 )] 
   public class MikelysHidingRobe  : BaseOuterTorso  
   { 
      [Constructable] 
      public MikelysHidingRobe() :  base( 0x204F ) 
      { 
         Weight = 1.0; 
         Hue = 1984; 
         Name = "Mikely's Hiding Robe"; 
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
           from.Emote( from.Name + " disappears into the ether!" );
Effects.SendLocationEffect( new Point3D( from.X, from.Y, from.Z ), from.Map, 0x3709, 40, 0, 1984, 0 ); 
Effects.SendLocationEffect( new Point3D( from.X, from.Y, from.Z ), from.Map, 0x376A, 40, 0, 1984, 0 ); 
//First row
Effects.SendLocationEffect( new Point3D( from.X + 1, from.Y , from.Z ), from.Map, 0x3709, 38, 0, 1984, 7 );
Effects.SendLocationEffect( new Point3D( from.X - 1, from.Y , from.Z ), from.Map, 0x3709, 38, 0, 1984, 7 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y + 1, from.Z ), from.Map, 0x3709, 38, 0, 1984, 7 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y - 1, from.Z ), from.Map, 0x3709, 38, 0, 1984, 7 );
Effects.SendLocationEffect( new Point3D( from.X -1, from.Y - 1, from.Z ), from.Map, 0x3709, 38, 0, 1984, 7 );
Effects.SendLocationEffect( new Point3D( from.X +1, from.Y - 1, from.Z ), from.Map, 0x3709, 38, 0, 1984, 7 );
Effects.SendLocationEffect( new Point3D( from.X -1, from.Y + 1, from.Z ), from.Map, 0x3709, 38, 0, 1984, 7 );
Effects.SendLocationEffect( new Point3D( from.X +1, from.Y + 1, from.Z ), from.Map, 0x3709, 38, 0, 1984, 7 );
Effects.SendLocationEffect( new Point3D( from.X + 1, from.Y , from.Z ), from.Map, 0x376A, 38, 0, 2, 0 );
Effects.SendLocationEffect( new Point3D( from.X - 1, from.Y , from.Z ), from.Map, 0x376A, 38, 0, 2, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y + 1, from.Z ), from.Map, 0x376A, 38, 0, 2, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y - 1, from.Z ), from.Map, 0x376A, 38, 0, 2, 0 );
Effects.SendLocationEffect( new Point3D( from.X -1, from.Y - 1, from.Z ), from.Map, 0x376A, 38, 0, 2, 0 );
Effects.SendLocationEffect( new Point3D( from.X +1, from.Y - 1, from.Z ), from.Map, 0x376A, 38, 0, 2, 0 );
Effects.SendLocationEffect( new Point3D( from.X -1, from.Y + 1, from.Z ), from.Map, 0x376A, 38, 0, 2, 0 );
Effects.SendLocationEffect( new Point3D( from.X +1, from.Y + 1, from.Z ), from.Map, 0x376A, 38, 0, 2, 0 );
//Second Row
Effects.SendLocationEffect( new Point3D( from.X + 2, from.Y , from.Z ), from.Map, 0x3709, 36, 0, 1984, 7 );
Effects.SendLocationEffect( new Point3D( from.X - 2, from.Y , from.Z ), from.Map, 0x3709, 36, 0, 1984, 7 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y + 2, from.Z ), from.Map, 0x3709, 36, 0, 1984, 7 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y - 2, from.Z ), from.Map, 0x3709, 36, 0, 1984, 7 );
Effects.SendLocationEffect( new Point3D( from.X -2, from.Y - 2, from.Z ), from.Map, 0x3709, 36, 0, 1984, 7 );
Effects.SendLocationEffect( new Point3D( from.X +2, from.Y - 2, from.Z ), from.Map, 0x3709, 36, 0, 1984, 7 );
Effects.SendLocationEffect( new Point3D( from.X -2, from.Y + 2, from.Z ), from.Map, 0x3709, 36, 0, 1984, 7 );
Effects.SendLocationEffect( new Point3D( from.X +2, from.Y + 2, from.Z ), from.Map, 0x3709, 36, 0, 1984, 7 );
Effects.SendLocationEffect( new Point3D( from.X + 2, from.Y +1, from.Z ), from.Map, 0x3709, 36, 0, 1984, 7 );
Effects.SendLocationEffect( new Point3D( from.X - 2, from.Y -1, from.Z ), from.Map, 0x3709, 36, 0, 1984, 7 );
Effects.SendLocationEffect( new Point3D( from.X +1, from.Y + 2, from.Z ), from.Map, 0x3709, 36, 0, 1984, 7 );
Effects.SendLocationEffect( new Point3D( from.X -1, from.Y - 2, from.Z ), from.Map, 0x3709, 36, 0, 1984, 7 );
Effects.SendLocationEffect( new Point3D( from.X + 2, from.Y -1, from.Z ), from.Map, 0x3709, 36, 0, 1984, 7 );
Effects.SendLocationEffect( new Point3D( from.X - 2, from.Y +1, from.Z ), from.Map, 0x3709, 36, 0, 1984, 7 );
Effects.SendLocationEffect( new Point3D( from.X +1, from.Y - 2, from.Z ), from.Map, 0x3709, 36, 0, 1984, 7 );
Effects.SendLocationEffect( new Point3D( from.X -1, from.Y + 2, from.Z ), from.Map, 0x3709, 36, 0, 1984, 7 );
Effects.SendLocationEffect( new Point3D( from.X + 2, from.Y , from.Z ), from.Map, 0x376A, 36, 0, 2, 0 );
Effects.SendLocationEffect( new Point3D( from.X - 2, from.Y , from.Z ), from.Map, 0x376A, 36, 0, 2, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y + 2, from.Z ), from.Map, 0x376A, 36, 0, 2, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y - 2, from.Z ), from.Map, 0x376A, 36, 0, 2, 0 );
Effects.SendLocationEffect( new Point3D( from.X -2, from.Y - 2, from.Z ), from.Map, 0x376A, 36, 0, 2, 0 );
Effects.SendLocationEffect( new Point3D( from.X +2, from.Y - 2, from.Z ), from.Map, 0x376A, 36, 0, 2, 0 );
Effects.SendLocationEffect( new Point3D( from.X -2, from.Y + 2, from.Z ), from.Map, 0x376A, 36, 0, 2, 0 );
Effects.SendLocationEffect( new Point3D( from.X +2, from.Y + 2, from.Z ), from.Map, 0x376A, 36, 0, 2, 0 );
Effects.SendLocationEffect( new Point3D( from.X + 2, from.Y +1, from.Z ), from.Map, 0x376A, 36, 0, 2, 0 );
Effects.SendLocationEffect( new Point3D( from.X - 2, from.Y -1, from.Z ), from.Map, 0x376A, 36, 0, 2, 0 );
Effects.SendLocationEffect( new Point3D( from.X +1, from.Y + 2, from.Z ), from.Map, 0x376A, 36, 0, 2, 0 );
Effects.SendLocationEffect( new Point3D( from.X -1, from.Y - 2, from.Z ), from.Map, 0x376A, 36, 0, 2, 0 );
Effects.SendLocationEffect( new Point3D( from.X + 2, from.Y -1, from.Z ), from.Map, 0x376A, 36, 0, 2, 0 );
Effects.SendLocationEffect( new Point3D( from.X - 2, from.Y +1, from.Z ), from.Map, 0x376A, 36, 0, 2, 0 );
Effects.SendLocationEffect( new Point3D( from.X +1, from.Y - 2, from.Z ), from.Map, 0x376A, 36, 0, 2, 0 );
Effects.SendLocationEffect( new Point3D( from.X -1, from.Y + 2, from.Z ), from.Map, 0x376A, 36, 0, 2, 0 );
//Third Row
Effects.SendLocationEffect( new Point3D( from.X + 3, from.Y , from.Z ), from.Map, 0x3709, 34, 0, 1984, 7 );
Effects.SendLocationEffect( new Point3D( from.X +3, from.Y - 3, from.Z ), from.Map, 0x3709, 34, 0, 1984, 7 );
Effects.SendLocationEffect( new Point3D( from.X +3, from.Y + 3, from.Z ), from.Map, 0x3709, 34, 0, 1984, 7 );
Effects.SendLocationEffect( new Point3D( from.X - 3, from.Y , from.Z ), from.Map, 0x3709, 34, 0, 1984, 7 );
Effects.SendLocationEffect( new Point3D( from.X -3, from.Y - 3, from.Z ), from.Map, 0x3709, 34, 0, 1984, 7 );
Effects.SendLocationEffect( new Point3D( from.X -3, from.Y + 3, from.Z ), from.Map, 0x3709, 34, 0, 1984, 7 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y + 3, from.Z ), from.Map, 0x3709, 34, 0, 1984, 7 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y - 3, from.Z ), from.Map, 0x3709, 34, 0, 1984, 7 );
Effects.SendLocationEffect( new Point3D( from.X + 3, from.Y -2, from.Z ), from.Map, 0x3709, 34, 0, 1984, 7 );
Effects.SendLocationEffect( new Point3D( from.X +3, from.Y +2, from.Z ), from.Map, 0x3709, 34, 0, 1984, 7 );
Effects.SendLocationEffect( new Point3D( from.X +2, from.Y + 3, from.Z ), from.Map, 0x3709, 34, 0, 1984, 7 );
Effects.SendLocationEffect( new Point3D( from.X +2, from.Y -3, from.Z ), from.Map, 0x3709, 34, 0, 1984, 7 );
Effects.SendLocationEffect( new Point3D( from.X -3, from.Y - 2, from.Z ), from.Map, 0x3709, 34, 0, 1984, 7 );
Effects.SendLocationEffect( new Point3D( from.X -3, from.Y + 2, from.Z ), from.Map, 0x3709, 34, 0, 1984, 7 );
Effects.SendLocationEffect( new Point3D( from.X -2, from.Y + 3, from.Z ), from.Map, 0x3709, 34, 0, 1984, 7 );
Effects.SendLocationEffect( new Point3D( from.X -2, from.Y - 3, from.Z ), from.Map, 0x3709, 34, 0, 1984, 7 );
Effects.SendLocationEffect( new Point3D( from.X + 3, from.Y -1, from.Z ), from.Map, 0x3709, 34, 0, 1984, 7 );
Effects.SendLocationEffect( new Point3D( from.X +3, from.Y +1, from.Z ), from.Map, 0x3709, 34, 0, 1984, 7 );
Effects.SendLocationEffect( new Point3D( from.X +1, from.Y + 3, from.Z ), from.Map, 0x3709, 34, 0, 1984, 7 );
Effects.SendLocationEffect( new Point3D( from.X +1, from.Y -3, from.Z ), from.Map, 0x3709, 34, 0, 1984, 7 );
Effects.SendLocationEffect( new Point3D( from.X -3, from.Y - 1, from.Z ), from.Map, 0x3709, 34, 0, 1984, 7 );
Effects.SendLocationEffect( new Point3D( from.X -3, from.Y + 1, from.Z ), from.Map, 0x3709, 34, 0, 1984, 7 );
Effects.SendLocationEffect( new Point3D( from.X -1, from.Y + 3, from.Z ), from.Map, 0x3709, 34, 0, 1984, 7 );
Effects.SendLocationEffect( new Point3D( from.X -1, from.Y - 3, from.Z ), from.Map, 0x3709, 34, 0, 1984, 7 );
Effects.SendLocationEffect( new Point3D( from.X + 3, from.Y , from.Z ), from.Map, 0x376A, 34, 0, 2, 0 );
Effects.SendLocationEffect( new Point3D( from.X +3, from.Y - 3, from.Z ), from.Map, 0x376A, 34, 0, 2, 0 );
Effects.SendLocationEffect( new Point3D( from.X +3, from.Y + 3, from.Z ), from.Map, 0x376A, 34, 0, 2, 0 );
Effects.SendLocationEffect( new Point3D( from.X - 3, from.Y , from.Z ), from.Map, 0x376A, 34, 0, 2, 0 );
Effects.SendLocationEffect( new Point3D( from.X -3, from.Y - 3, from.Z ), from.Map, 0x376A, 34, 0, 2, 0 );
Effects.SendLocationEffect( new Point3D( from.X -3, from.Y + 3, from.Z ), from.Map, 0x376A, 34, 0, 2, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y + 3, from.Z ), from.Map, 0x376A, 34, 0, 2, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y - 3, from.Z ), from.Map, 0x376A, 34, 0, 2, 0 );
Effects.SendLocationEffect( new Point3D( from.X + 3, from.Y -2, from.Z ), from.Map, 0x376A, 34, 0, 2, 0 );
Effects.SendLocationEffect( new Point3D( from.X +3, from.Y +2, from.Z ), from.Map, 0x376A, 34, 0, 2, 0 );
Effects.SendLocationEffect( new Point3D( from.X +2, from.Y + 3, from.Z ), from.Map, 0x376A, 34, 0, 2, 0 );
Effects.SendLocationEffect( new Point3D( from.X +2, from.Y -3, from.Z ), from.Map, 0x376A, 34, 0, 2, 0 );
Effects.SendLocationEffect( new Point3D( from.X -3, from.Y - 2, from.Z ), from.Map, 0x376A, 34, 0, 2, 0 );
Effects.SendLocationEffect( new Point3D( from.X -3, from.Y + 2, from.Z ), from.Map, 0x376A, 34, 0, 2, 0 );
Effects.SendLocationEffect( new Point3D( from.X -2, from.Y + 3, from.Z ), from.Map, 0x376A, 34, 0, 2, 0 );
Effects.SendLocationEffect( new Point3D( from.X -2, from.Y - 3, from.Z ), from.Map, 0x376A, 34, 0, 2, 0 );
Effects.SendLocationEffect( new Point3D( from.X + 3, from.Y -1, from.Z ), from.Map, 0x376A, 34, 0, 2, 0 );
Effects.SendLocationEffect( new Point3D( from.X +3, from.Y +1, from.Z ), from.Map, 0x376A, 34, 0, 2, 0 );
Effects.SendLocationEffect( new Point3D( from.X +1, from.Y + 3, from.Z ), from.Map, 0x376A, 34, 0, 2, 0 );
Effects.SendLocationEffect( new Point3D( from.X +1, from.Y -3, from.Z ), from.Map, 0x376A, 34, 0, 2, 0 );
Effects.SendLocationEffect( new Point3D( from.X -3, from.Y - 1, from.Z ), from.Map, 0x376A, 34, 0, 2, 0 );
Effects.SendLocationEffect( new Point3D( from.X -3, from.Y + 1, from.Z ), from.Map, 0x376A, 34, 0, 2, 0 );
Effects.SendLocationEffect( new Point3D( from.X -1, from.Y + 3, from.Z ), from.Map, 0x376A, 34, 0, 2, 0 );
Effects.SendLocationEffect( new Point3D( from.X -1, from.Y - 3, from.Z ), from.Map, 0x376A, 34, 0, 2, 0 );
//Forth Row
Effects.SendLocationEffect( new Point3D( from.X + 4, from.Y , from.Z ), from.Map, 0x3709, 32, 0, 1984, 7 );
Effects.SendLocationEffect( new Point3D( from.X - 4, from.Y , from.Z ), from.Map, 0x3709, 32, 0, 1984, 7 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y + 4, from.Z ), from.Map, 0x3709, 32, 0, 1984, 7 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y - 4, from.Z ), from.Map, 0x3709, 32, 0, 1984, 7 );
Effects.SendLocationEffect( new Point3D( from.X -4, from.Y - 4, from.Z ), from.Map, 0x3709, 32, 0, 1984, 7 );
Effects.SendLocationEffect( new Point3D( from.X +4, from.Y - 4, from.Z ), from.Map, 0x3709, 32, 0, 1984, 7 );
Effects.SendLocationEffect( new Point3D( from.X -4, from.Y + 4, from.Z ), from.Map, 0x3709, 32, 0, 1984, 7 );
Effects.SendLocationEffect( new Point3D( from.X +4, from.Y + 4, from.Z ), from.Map, 0x3709, 32, 0, 1984, 7 );

Effects.SendLocationEffect( new Point3D( from.X + 4, from.Y , from.Z ), from.Map, 0x376A, 32, 0, 2, 0 );
Effects.SendLocationEffect( new Point3D( from.X - 4, from.Y , from.Z ), from.Map, 0x376A, 32, 0, 2, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y + 4, from.Z ), from.Map, 0x376A, 32, 0, 2, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y - 4, from.Z ), from.Map, 0x376A, 32, 0, 2, 0 );
Effects.SendLocationEffect( new Point3D( from.X -4, from.Y - 4, from.Z ), from.Map, 0x376A, 32, 0, 2, 0 );
Effects.SendLocationEffect( new Point3D( from.X +4, from.Y - 4, from.Z ), from.Map, 0x376A, 32, 0, 2, 0 );
Effects.SendLocationEffect( new Point3D( from.X -4, from.Y + 4, from.Z ), from.Map, 0x376A, 32, 0, 2, 0 );
Effects.SendLocationEffect( new Point3D( from.X +4, from.Y + 4, from.Z ), from.Map, 0x376A, 32, 0, 2, 0 );
//Fifth Row
Effects.SendLocationEffect( new Point3D( from.X + 5, from.Y , from.Z ), from.Map, 0x3709, 30, 0, 1984, 7 );
Effects.SendLocationEffect( new Point3D( from.X - 5, from.Y , from.Z ), from.Map, 0x3709, 30, 0, 1984, 7 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y + 5, from.Z ), from.Map, 0x3709, 30, 0, 1984, 7 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y - 5, from.Z ), from.Map, 0x3709, 30, 0, 1984, 7 );
Effects.SendLocationEffect( new Point3D( from.X -5, from.Y - 5, from.Z ), from.Map, 0x3709, 30, 0, 1984, 7 );
Effects.SendLocationEffect( new Point3D( from.X +5, from.Y - 5, from.Z ), from.Map, 0x3709, 30, 0, 1984, 7 );
Effects.SendLocationEffect( new Point3D( from.X -5, from.Y + 5, from.Z ), from.Map, 0x3709, 30, 0, 1984, 7 );
Effects.SendLocationEffect( new Point3D( from.X +5, from.Y + 5, from.Z ), from.Map, 0x3709, 30, 0, 1984, 7 );

Effects.SendLocationEffect( new Point3D( from.X + 5, from.Y , from.Z ), from.Map, 0x376A, 30, 0, 2, 0 );
Effects.SendLocationEffect( new Point3D( from.X - 5, from.Y , from.Z ), from.Map, 0x376A, 30, 0, 2, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y + 5, from.Z ), from.Map, 0x376A, 30, 0, 2, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y - 5, from.Z ), from.Map, 0x376A, 30, 0, 2, 0 );
Effects.SendLocationEffect( new Point3D( from.X -5, from.Y - 5, from.Z ), from.Map, 0x376A, 30, 0, 2, 0 );
Effects.SendLocationEffect( new Point3D( from.X +5, from.Y - 5, from.Z ), from.Map, 0x376A, 30, 0, 2, 0 );
Effects.SendLocationEffect( new Point3D( from.X -5, from.Y + 5, from.Z ), from.Map, 0x376A, 30, 0, 2, 0 );
Effects.SendLocationEffect( new Point3D( from.X +5, from.Y + 5, from.Z ), from.Map, 0x376A, 30, 0, 2, 0 );
           from.PlaySound( 0x16A );
	       from.Hidden = true;
           
            } 
            else 
            { 
           from.Hidden=false;
           from.Emote( from.Name + " steps out of the ether!");
Effects.SendLocationEffect( new Point3D( from.X, from.Y, from.Z ), from.Map, 0x3709, 20, 0, 1984, 0 ); 
Effects.SendLocationEffect( new Point3D( from.X, from.Y, from.Z ), from.Map, 0x376A, 20, 0, 1984, 0 ); 
//First row
Effects.SendLocationEffect( new Point3D( from.X + 1, from.Y , from.Z ), from.Map, 0x3709, 22, 0, 1984, 7 );
Effects.SendLocationEffect( new Point3D( from.X - 1, from.Y , from.Z ), from.Map, 0x3709, 22, 0, 1984, 7 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y + 1, from.Z ), from.Map, 0x3709, 22, 0, 1984, 7 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y - 1, from.Z ), from.Map, 0x3709, 22, 0, 1984, 7 );
Effects.SendLocationEffect( new Point3D( from.X -1, from.Y - 1, from.Z ), from.Map, 0x3709, 22, 0, 1984, 7 );
Effects.SendLocationEffect( new Point3D( from.X +1, from.Y - 1, from.Z ), from.Map, 0x3709, 22, 0, 1984, 7 );
Effects.SendLocationEffect( new Point3D( from.X -1, from.Y + 1, from.Z ), from.Map, 0x3709, 22, 0, 1984, 7 );
Effects.SendLocationEffect( new Point3D( from.X +1, from.Y + 1, from.Z ), from.Map, 0x3709, 22, 0, 1984, 7 );
Effects.SendLocationEffect( new Point3D( from.X + 1, from.Y , from.Z ), from.Map, 0x376A, 22, 0, 2, 0 );
Effects.SendLocationEffect( new Point3D( from.X - 1, from.Y , from.Z ), from.Map, 0x376A, 22, 0, 2, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y + 1, from.Z ), from.Map, 0x376A, 22, 0, 2, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y - 1, from.Z ), from.Map, 0x376A, 22, 0, 2, 0 );
Effects.SendLocationEffect( new Point3D( from.X -1, from.Y - 1, from.Z ), from.Map, 0x376A, 22, 0, 2, 0 );
Effects.SendLocationEffect( new Point3D( from.X +1, from.Y - 1, from.Z ), from.Map, 0x376A, 22, 0, 2, 0 );
Effects.SendLocationEffect( new Point3D( from.X -1, from.Y + 1, from.Z ), from.Map, 0x376A, 22, 0, 2, 0 );
Effects.SendLocationEffect( new Point3D( from.X +1, from.Y + 1, from.Z ), from.Map, 0x376A, 22, 0, 2, 0 );
//Second Row
Effects.SendLocationEffect( new Point3D( from.X + 2, from.Y , from.Z ), from.Map, 0x3709, 24, 0, 1984, 7 );
Effects.SendLocationEffect( new Point3D( from.X - 2, from.Y , from.Z ), from.Map, 0x3709, 24, 0, 1984, 7 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y + 2, from.Z ), from.Map, 0x3709, 24, 0, 1984, 7 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y - 2, from.Z ), from.Map, 0x3709, 24, 0, 1984, 7 );
Effects.SendLocationEffect( new Point3D( from.X -2, from.Y - 2, from.Z ), from.Map, 0x3709, 24, 0, 1984, 7 );
Effects.SendLocationEffect( new Point3D( from.X +2, from.Y - 2, from.Z ), from.Map, 0x3709, 24, 0, 1984, 7 );
Effects.SendLocationEffect( new Point3D( from.X -2, from.Y + 2, from.Z ), from.Map, 0x3709, 24, 0, 1984, 7 );
Effects.SendLocationEffect( new Point3D( from.X +2, from.Y + 2, from.Z ), from.Map, 0x3709, 24, 0, 1984, 7 );
Effects.SendLocationEffect( new Point3D( from.X + 2, from.Y +1, from.Z ), from.Map, 0x3709, 24, 0, 1984, 7 );
Effects.SendLocationEffect( new Point3D( from.X - 2, from.Y -1, from.Z ), from.Map, 0x3709, 24, 0, 1984, 7 );
Effects.SendLocationEffect( new Point3D( from.X +1, from.Y + 2, from.Z ), from.Map, 0x3709, 24, 0, 1984, 7 );
Effects.SendLocationEffect( new Point3D( from.X -1, from.Y - 2, from.Z ), from.Map, 0x3709, 24, 0, 1984, 7 );
Effects.SendLocationEffect( new Point3D( from.X + 2, from.Y -1, from.Z ), from.Map, 0x3709, 24, 0, 1984, 7 );
Effects.SendLocationEffect( new Point3D( from.X - 2, from.Y +1, from.Z ), from.Map, 0x3709, 24, 0, 1984, 7 );
Effects.SendLocationEffect( new Point3D( from.X +1, from.Y - 2, from.Z ), from.Map, 0x3709, 24, 0, 1984, 7 );
Effects.SendLocationEffect( new Point3D( from.X -1, from.Y + 2, from.Z ), from.Map, 0x3709, 24, 0, 1984, 7 );
Effects.SendLocationEffect( new Point3D( from.X + 2, from.Y , from.Z ), from.Map, 0x376A, 24, 0, 2, 0 );
Effects.SendLocationEffect( new Point3D( from.X - 2, from.Y , from.Z ), from.Map, 0x376A, 24, 0, 2, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y + 2, from.Z ), from.Map, 0x376A, 24, 0, 2, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y - 2, from.Z ), from.Map, 0x376A, 24, 0, 2, 0 );
Effects.SendLocationEffect( new Point3D( from.X -2, from.Y - 2, from.Z ), from.Map, 0x376A, 24, 0, 2, 0 );
Effects.SendLocationEffect( new Point3D( from.X +2, from.Y - 2, from.Z ), from.Map, 0x376A, 24, 0, 2, 0 );
Effects.SendLocationEffect( new Point3D( from.X -2, from.Y + 2, from.Z ), from.Map, 0x376A, 24, 0, 2, 0 );
Effects.SendLocationEffect( new Point3D( from.X +2, from.Y + 2, from.Z ), from.Map, 0x376A, 24, 0, 2, 0 );
Effects.SendLocationEffect( new Point3D( from.X + 2, from.Y +1, from.Z ), from.Map, 0x376A, 24, 0, 2, 0 );
Effects.SendLocationEffect( new Point3D( from.X - 2, from.Y -1, from.Z ), from.Map, 0x376A, 24, 0, 2, 0 );
Effects.SendLocationEffect( new Point3D( from.X +1, from.Y + 2, from.Z ), from.Map, 0x376A, 24, 0, 2, 0 );
Effects.SendLocationEffect( new Point3D( from.X -1, from.Y - 2, from.Z ), from.Map, 0x376A, 24, 0, 2, 0 );
Effects.SendLocationEffect( new Point3D( from.X + 2, from.Y -1, from.Z ), from.Map, 0x376A, 24, 0, 2, 0 );
Effects.SendLocationEffect( new Point3D( from.X - 2, from.Y +1, from.Z ), from.Map, 0x376A, 24, 0, 2, 0 );
Effects.SendLocationEffect( new Point3D( from.X +1, from.Y - 2, from.Z ), from.Map, 0x376A, 24, 0, 2, 0 );
Effects.SendLocationEffect( new Point3D( from.X -1, from.Y + 2, from.Z ), from.Map, 0x376A, 24, 0, 2, 0 );
//Third Row
Effects.SendLocationEffect( new Point3D( from.X + 3, from.Y , from.Z ), from.Map, 0x3709, 26, 0, 1984, 7 );
Effects.SendLocationEffect( new Point3D( from.X +3, from.Y + 3, from.Z ), from.Map, 0x3709, 26, 0, 1984, 7 );
Effects.SendLocationEffect( new Point3D( from.X +3, from.Y - 3, from.Z ), from.Map, 0x3709, 26, 0, 1984, 7 );
Effects.SendLocationEffect( new Point3D( from.X - 3, from.Y , from.Z ), from.Map, 0x3709, 26, 0, 1984, 7 );
Effects.SendLocationEffect( new Point3D( from.X -3, from.Y - 3, from.Z ), from.Map, 0x3709, 26, 0, 1984, 7 );
Effects.SendLocationEffect( new Point3D( from.X -3, from.Y + 3, from.Z ), from.Map, 0x3709, 26, 0, 1984, 7 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y + 3, from.Z ), from.Map, 0x3709, 26, 0, 1984, 7 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y - 3, from.Z ), from.Map, 0x3709, 26, 0, 1984, 7 );
Effects.SendLocationEffect( new Point3D( from.X + 3, from.Y +2, from.Z ), from.Map, 0x3709, 26, 0, 1984, 7 );
Effects.SendLocationEffect( new Point3D( from.X -3, from.Y - 2, from.Z ), from.Map, 0x3709, 26, 0, 1984, 7 );
Effects.SendLocationEffect( new Point3D( from.X +2, from.Y + 3, from.Z ), from.Map, 0x3709, 26, 0, 1984, 7 );
Effects.SendLocationEffect( new Point3D( from.X - 2, from.Y -3, from.Z ), from.Map, 0x3709, 26, 0, 1984, 7 );
Effects.SendLocationEffect( new Point3D( from.X +3, from.Y - 2, from.Z ), from.Map, 0x3709, 26, 0, 1984, 7 );
Effects.SendLocationEffect( new Point3D( from.X -3, from.Y + 2, from.Z ), from.Map, 0x3709, 26, 0, 1984, 7 );
Effects.SendLocationEffect( new Point3D( from.X +2, from.Y - 3, from.Z ), from.Map, 0x3709, 26, 0, 1984, 7 );
Effects.SendLocationEffect( new Point3D( from.X -2, from.Y + 3, from.Z ), from.Map, 0x3709, 26, 0, 1984, 7 );
Effects.SendLocationEffect( new Point3D( from.X + 3, from.Y +1, from.Z ), from.Map, 0x3709, 26, 0, 1984, 7 );
Effects.SendLocationEffect( new Point3D( from.X -3, from.Y - 1, from.Z ), from.Map, 0x3709, 26, 0, 1984, 7 );
Effects.SendLocationEffect( new Point3D( from.X +1, from.Y + 3, from.Z ), from.Map, 0x3709, 26, 0, 1984, 7 );
Effects.SendLocationEffect( new Point3D( from.X - 1, from.Y -3, from.Z ), from.Map, 0x3709, 26, 0, 1984, 7 );
Effects.SendLocationEffect( new Point3D( from.X +3, from.Y - 1, from.Z ), from.Map, 0x3709, 26, 0, 1984, 7 );
Effects.SendLocationEffect( new Point3D( from.X -3, from.Y + 1, from.Z ), from.Map, 0x3709, 26, 0, 1984, 7 );
Effects.SendLocationEffect( new Point3D( from.X +1, from.Y - 3, from.Z ), from.Map, 0x3709, 26, 0, 1984, 7 );
Effects.SendLocationEffect( new Point3D( from.X -1, from.Y + 3, from.Z ), from.Map, 0x3709, 26, 0, 1984, 7 );
Effects.SendLocationEffect( new Point3D( from.X + 3, from.Y , from.Z ), from.Map, 0x376A, 26, 0, 2, 0 );
Effects.SendLocationEffect( new Point3D( from.X +3, from.Y + 3, from.Z ), from.Map, 0x376A, 26, 0, 2, 0 );
Effects.SendLocationEffect( new Point3D( from.X +3, from.Y - 3, from.Z ), from.Map, 0x376A, 26, 0, 2, 0 );
Effects.SendLocationEffect( new Point3D( from.X - 3, from.Y , from.Z ), from.Map, 0x376A, 26, 0, 2, 0 );
Effects.SendLocationEffect( new Point3D( from.X -3, from.Y - 3, from.Z ), from.Map, 0x376A, 26, 0, 2, 0 );
Effects.SendLocationEffect( new Point3D( from.X -3, from.Y + 3, from.Z ), from.Map, 0x376A, 26, 0, 2, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y + 3, from.Z ), from.Map, 0x376A, 26, 0, 2, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y - 3, from.Z ), from.Map, 0x376A, 26, 0, 2, 0 );
Effects.SendLocationEffect( new Point3D( from.X + 3, from.Y +2, from.Z ), from.Map, 0x376A, 26, 0, 2, 0 );
Effects.SendLocationEffect( new Point3D( from.X -3, from.Y - 2, from.Z ), from.Map, 0x376A, 26, 0, 2, 0 );
Effects.SendLocationEffect( new Point3D( from.X +2, from.Y + 3, from.Z ), from.Map, 0x376A, 26, 0, 2, 0 );
Effects.SendLocationEffect( new Point3D( from.X - 2, from.Y -3, from.Z ), from.Map, 0x376A, 26, 0, 2, 0 );
Effects.SendLocationEffect( new Point3D( from.X +3, from.Y - 2, from.Z ), from.Map, 0x376A, 26, 0, 2, 0 );
Effects.SendLocationEffect( new Point3D( from.X -3, from.Y + 2, from.Z ), from.Map, 0x376A, 26, 0, 2, 0 );
Effects.SendLocationEffect( new Point3D( from.X +2, from.Y - 3, from.Z ), from.Map, 0x376A, 26, 0, 2, 0 );
Effects.SendLocationEffect( new Point3D( from.X -2, from.Y + 3, from.Z ), from.Map, 0x376A, 26, 0, 2, 0 );
Effects.SendLocationEffect( new Point3D( from.X + 3, from.Y +1, from.Z ), from.Map, 0x376A, 26, 0, 2, 0 );
Effects.SendLocationEffect( new Point3D( from.X -3, from.Y - 1, from.Z ), from.Map, 0x376A, 26, 0, 2, 0 );
Effects.SendLocationEffect( new Point3D( from.X +1, from.Y + 3, from.Z ), from.Map, 0x376A, 26, 0, 2, 0 );
Effects.SendLocationEffect( new Point3D( from.X - 1, from.Y -3, from.Z ), from.Map, 0x376A, 26, 0, 2, 0 );
Effects.SendLocationEffect( new Point3D( from.X +3, from.Y - 1, from.Z ), from.Map, 0x376A, 26, 0, 2, 0 );
Effects.SendLocationEffect( new Point3D( from.X -3, from.Y + 1, from.Z ), from.Map, 0x376A, 26, 0, 2, 0 );
Effects.SendLocationEffect( new Point3D( from.X +1, from.Y - 3, from.Z ), from.Map, 0x376A, 26, 0, 2, 0 );
Effects.SendLocationEffect( new Point3D( from.X -1, from.Y + 3, from.Z ), from.Map, 0x376A, 26, 0, 2, 0 );
//Forth Row
Effects.SendLocationEffect( new Point3D( from.X + 4, from.Y , from.Z ), from.Map, 0x3709, 28, 0, 1984, 7 );
Effects.SendLocationEffect( new Point3D( from.X - 4, from.Y , from.Z ), from.Map, 0x3709, 28, 0, 1984, 7 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y + 4, from.Z ), from.Map, 0x3709, 28, 0, 1984, 7 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y - 4, from.Z ), from.Map, 0x3709, 28, 0, 1984, 7 );
Effects.SendLocationEffect( new Point3D( from.X -4, from.Y - 4, from.Z ), from.Map, 0x3709, 28, 0, 1984, 7 );
Effects.SendLocationEffect( new Point3D( from.X +4, from.Y - 4, from.Z ), from.Map, 0x3709, 28, 0, 1984, 7 );
Effects.SendLocationEffect( new Point3D( from.X -4, from.Y + 4, from.Z ), from.Map, 0x3709, 28, 0, 1984, 7 );
Effects.SendLocationEffect( new Point3D( from.X +4, from.Y + 4, from.Z ), from.Map, 0x3709, 28, 0, 1984, 7 );

Effects.SendLocationEffect( new Point3D( from.X + 4, from.Y , from.Z ), from.Map, 0x376A, 28, 0, 2, 0 );
Effects.SendLocationEffect( new Point3D( from.X - 4, from.Y , from.Z ), from.Map, 0x376A, 28, 0, 2, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y + 4, from.Z ), from.Map, 0x376A, 28, 0, 2, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y - 4, from.Z ), from.Map, 0x376A, 28, 0, 2, 0 );
Effects.SendLocationEffect( new Point3D( from.X -4, from.Y - 4, from.Z ), from.Map, 0x376A, 28, 0, 2, 0 );
Effects.SendLocationEffect( new Point3D( from.X +4, from.Y - 4, from.Z ), from.Map, 0x376A, 28, 0, 2, 0 );
Effects.SendLocationEffect( new Point3D( from.X -4, from.Y + 4, from.Z ), from.Map, 0x376A, 28, 0, 2, 0 );
Effects.SendLocationEffect( new Point3D( from.X +4, from.Y + 4, from.Z ), from.Map, 0x376A, 28, 0, 2, 0 );
//Fifth Row
Effects.SendLocationEffect( new Point3D( from.X + 5, from.Y , from.Z ), from.Map, 0x3709, 30, 0, 1984, 7 );
Effects.SendLocationEffect( new Point3D( from.X - 5, from.Y , from.Z ), from.Map, 0x3709, 30, 0, 1984, 7 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y + 5, from.Z ), from.Map, 0x3709, 30, 0, 1984, 7 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y - 5, from.Z ), from.Map, 0x3709, 30, 0, 1984, 7 );
Effects.SendLocationEffect( new Point3D( from.X -5, from.Y - 5, from.Z ), from.Map, 0x3709, 30, 0, 1984, 7 );
Effects.SendLocationEffect( new Point3D( from.X +5, from.Y - 5, from.Z ), from.Map, 0x3709, 30, 0, 1984, 7 );
Effects.SendLocationEffect( new Point3D( from.X -5, from.Y + 5, from.Z ), from.Map, 0x3709, 30, 0, 1984, 7 );
Effects.SendLocationEffect( new Point3D( from.X +5, from.Y + 5, from.Z ), from.Map, 0x3709, 30, 0, 1984, 7 );

Effects.SendLocationEffect( new Point3D( from.X + 5, from.Y , from.Z ), from.Map, 0x376A, 30, 0, 2, 0 );
Effects.SendLocationEffect( new Point3D( from.X - 5, from.Y , from.Z ), from.Map, 0x376A, 30, 0, 2, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y + 5, from.Z ), from.Map, 0x376A, 30, 0, 2, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y - 5, from.Z ), from.Map, 0x376A, 30, 0, 2, 0 );
Effects.SendLocationEffect( new Point3D( from.X -5, from.Y - 5, from.Z ), from.Map, 0x376A, 30, 0, 2, 0 );
Effects.SendLocationEffect( new Point3D( from.X +5, from.Y - 5, from.Z ), from.Map, 0x376A, 30, 0, 2, 0 );
Effects.SendLocationEffect( new Point3D( from.X -5, from.Y + 5, from.Z ), from.Map, 0x376A, 30, 0, 2, 0 );
Effects.SendLocationEffect( new Point3D( from.X +5, from.Y + 5, from.Z ), from.Map, 0x376A, 30, 0, 2, 0 );
           from.PlaySound( 0x16A );
                 }     
            } 
		}


       
      public MikelysHidingRobe( Serial serial ) : base( serial ) 
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