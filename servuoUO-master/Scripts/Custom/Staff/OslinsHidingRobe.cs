using System; 
using Server; 
using Server.Misc;
using Server.Items; 
using Server.Targeting; 

namespace Server.Items 
{ 
   [FlipableAttribute( 0x7939, 0x7940 )] 
   public class OslinsHidingRobe  : BaseOuterTorso  
   { 
      [Constructable] 
      public OslinsHidingRobe() :  base( 0x204F ) 
      { 
         Weight = 1.0; 
         Hue = 1666; 
         Name = "Oslin's Hiding Robe"; 
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
           from.Emote( from.Name + " Steps Through The Gate" );
  
Effects.SendLocationEffect( new Point3D( from.X, from.Y, from.Z ), from.Map, 0x3709, 40, 0, 63, 0 ); 

//First row
Effects.SendLocationEffect( new Point3D( from.X + 1, from.Y , from.Z ), from.Map, 0x3709, 38, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X - 1, from.Y , from.Z ), from.Map, 0x3709, 38, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y + 1, from.Z ), from.Map, 0x3709, 38, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y - 1, from.Z ), from.Map, 0x3709, 38, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X -1, from.Y - 1, from.Z ), from.Map, 0x3709, 38, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X +1, from.Y - 1, from.Z ), from.Map, 0x3709, 38, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X -1, from.Y + 1, from.Z ), from.Map, 0x3709, 38, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X +1, from.Y + 1, from.Z ), from.Map, 0x3709, 38, 0, 63, 0 );
//Second Row
Effects.SendLocationEffect( new Point3D( from.X + 2, from.Y , from.Z ), from.Map, 0x3709, 36, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X - 2, from.Y , from.Z ), from.Map, 0x3709, 36, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y + 2, from.Z ), from.Map, 0x3709, 36, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y - 2, from.Z ), from.Map, 0x3709, 36, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X -2, from.Y - 2, from.Z ), from.Map, 0x3709, 36, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X +2, from.Y - 2, from.Z ), from.Map, 0x3709, 36, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X -2, from.Y + 2, from.Z ), from.Map, 0x3709, 36, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X +2, from.Y + 2, from.Z ), from.Map, 0x3709, 36, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X + 2, from.Y +1, from.Z ), from.Map, 0x3709, 36, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X - 2, from.Y -1, from.Z ), from.Map, 0x3709, 36, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X +1, from.Y + 2, from.Z ), from.Map, 0x3709, 36, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X -1, from.Y - 2, from.Z ), from.Map, 0x3709, 36, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X + 2, from.Y -1, from.Z ), from.Map, 0x3709, 36, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X - 2, from.Y +1, from.Z ), from.Map, 0x3709, 36, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X +1, from.Y - 2, from.Z ), from.Map, 0x3709, 36, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X -1, from.Y + 2, from.Z ), from.Map, 0x3709, 36, 0, 63, 0 );
//Third Row
Effects.SendLocationEffect( new Point3D( from.X + 3, from.Y , from.Z ), from.Map, 0x3709, 34, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X +3, from.Y - 3, from.Z ), from.Map, 0x3709, 34, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X +3, from.Y + 3, from.Z ), from.Map, 0x3709, 34, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X - 3, from.Y , from.Z ), from.Map, 0x3709, 34, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X -3, from.Y - 3, from.Z ), from.Map, 0x3709, 34, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X -3, from.Y + 3, from.Z ), from.Map, 0x3709, 34, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y + 3, from.Z ), from.Map, 0x3709, 34, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y - 3, from.Z ), from.Map, 0x3709, 34, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X + 3, from.Y -2, from.Z ), from.Map, 0x3709, 34, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X +3, from.Y +2, from.Z ), from.Map, 0x3709, 34, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X +2, from.Y + 3, from.Z ), from.Map, 0x3709, 34, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X +2, from.Y -3, from.Z ), from.Map, 0x3709, 34, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X -3, from.Y - 2, from.Z ), from.Map, 0x3709, 34, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X -3, from.Y + 2, from.Z ), from.Map, 0x3709, 34, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X -2, from.Y + 3, from.Z ), from.Map, 0x3709, 34, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X -2, from.Y - 3, from.Z ), from.Map, 0x3709, 34, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X + 3, from.Y -1, from.Z ), from.Map, 0x3709, 34, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X +3, from.Y +1, from.Z ), from.Map, 0x3709, 34, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X +1, from.Y + 3, from.Z ), from.Map, 0x3709, 34, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X +1, from.Y -3, from.Z ), from.Map, 0x3709, 34, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X -3, from.Y - 1, from.Z ), from.Map, 0x3709, 34, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X -3, from.Y + 1, from.Z ), from.Map, 0x3709, 34, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X -1, from.Y + 3, from.Z ), from.Map, 0x3709, 34, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X -1, from.Y - 3, from.Z ), from.Map, 0x3709, 34, 0, 63, 0 );
//Forth Row
Effects.SendLocationEffect( new Point3D( from.X + 4, from.Y , from.Z ), from.Map, 0x3709, 32, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X - 4, from.Y , from.Z ), from.Map, 0x3709, 32, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y + 4, from.Z ), from.Map, 0x3709, 32, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y - 4, from.Z ), from.Map, 0x3709, 32, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X -4, from.Y - 4, from.Z ), from.Map, 0x3709, 32, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X +4, from.Y - 4, from.Z ), from.Map, 0x3709, 32, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X -4, from.Y + 4, from.Z ), from.Map, 0x3709, 32, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X +4, from.Y + 4, from.Z ), from.Map, 0x3709, 32, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X +4, from.Y -3, from.Z ), from.Map, 0x3709, 32, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X +4, from.Y +3, from.Z ), from.Map, 0x3709, 32, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X +3, from.Y -4, from.Z ), from.Map, 0x3709, 32, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X +3, from.Y +4, from.Z ), from.Map, 0x3709, 32, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X -4, from.Y -3, from.Z ), from.Map, 0x3709, 32, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X -4, from.Y +3, from.Z ), from.Map, 0x3709, 32, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X -3, from.Y -4, from.Z ), from.Map, 0x3709, 32, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X -3, from.Y +4, from.Z ), from.Map, 0x3709, 32, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X +4, from.Y -2, from.Z ), from.Map, 0x3709, 32, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X +4, from.Y +2, from.Z ), from.Map, 0x3709, 32, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X +2, from.Y -4, from.Z ), from.Map, 0x3709, 32, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X +2, from.Y +4, from.Z ), from.Map, 0x3709, 32, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X -4, from.Y -2, from.Z ), from.Map, 0x3709, 32, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X -4, from.Y +2, from.Z ), from.Map, 0x3709, 32, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X -2, from.Y -4, from.Z ), from.Map, 0x3709, 32, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X -2, from.Y +4, from.Z ), from.Map, 0x3709, 32, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X +4, from.Y -1, from.Z ), from.Map, 0x3709, 32, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X +4, from.Y +1, from.Z ), from.Map, 0x3709, 32, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X +1, from.Y -4, from.Z ), from.Map, 0x3709, 32, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X +1, from.Y +4, from.Z ), from.Map, 0x3709, 32, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X -4, from.Y -1, from.Z ), from.Map, 0x3709, 32, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X -4, from.Y +1, from.Z ), from.Map, 0x3709, 32, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X -1, from.Y -4, from.Z ), from.Map, 0x3709, 32, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X -1, from.Y +4, from.Z ), from.Map, 0x3709, 32, 0, 63, 0 );
//Fifth Row
Effects.SendLocationEffect( new Point3D( from.X + 5, from.Y , from.Z ), from.Map, 0x3709, 30, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X - 5, from.Y , from.Z ), from.Map, 0x3709, 30, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y + 5, from.Z ), from.Map, 0x3709, 30, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y - 5, from.Z ), from.Map, 0x3709, 30, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X -5, from.Y - 5, from.Z ), from.Map, 0x3709, 30, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X +5, from.Y - 5, from.Z ), from.Map, 0x3709, 30, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X -5, from.Y + 5, from.Z ), from.Map, 0x3709, 30, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X +5, from.Y + 5, from.Z ), from.Map, 0x3709, 30, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X +5, from.Y -4, from.Z ), from.Map, 0x3709, 30, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X +5, from.Y +4, from.Z ), from.Map, 0x3709, 30, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X +4, from.Y -5, from.Z ), from.Map, 0x3709, 30, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X +4, from.Y +5, from.Z ), from.Map, 0x3709, 30, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X -5, from.Y -4, from.Z ), from.Map, 0x3709, 30, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X -5, from.Y +4, from.Z ), from.Map, 0x3709, 30, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X -4, from.Y -5, from.Z ), from.Map, 0x3709, 30, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X -4, from.Y +5, from.Z ), from.Map, 0x3709, 30, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X +5, from.Y -3, from.Z ), from.Map, 0x3709, 30, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X +5, from.Y +3, from.Z ), from.Map, 0x3709, 30, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X +3, from.Y -5, from.Z ), from.Map, 0x3709, 30, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X +3, from.Y +5, from.Z ), from.Map, 0x3709, 30, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X -5, from.Y -3, from.Z ), from.Map, 0x3709, 30, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X -5, from.Y +3, from.Z ), from.Map, 0x3709, 30, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X -3, from.Y -5, from.Z ), from.Map, 0x3709, 30, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X -3, from.Y +5, from.Z ), from.Map, 0x3709, 30, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X +5, from.Y -2, from.Z ), from.Map, 0x3709, 30, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X +5, from.Y +2, from.Z ), from.Map, 0x3709, 30, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X +2, from.Y -5, from.Z ), from.Map, 0x3709, 30, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X +2, from.Y +5, from.Z ), from.Map, 0x3709, 30, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X -5, from.Y -2, from.Z ), from.Map, 0x3709, 30, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X -5, from.Y +2, from.Z ), from.Map, 0x3709, 30, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X -2, from.Y -5, from.Z ), from.Map, 0x3709, 30, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X -2, from.Y +5, from.Z ), from.Map, 0x3709, 30, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X +5, from.Y -1, from.Z ), from.Map, 0x3709, 30, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X +5, from.Y +1, from.Z ), from.Map, 0x3709, 30, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X +1, from.Y -5, from.Z ), from.Map, 0x3709, 30, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X +1, from.Y +5, from.Z ), from.Map, 0x3709, 30, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X -5, from.Y -1, from.Z ), from.Map, 0x3709, 30, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X -5, from.Y +1, from.Z ), from.Map, 0x3709, 30, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X -1, from.Y -5, from.Z ), from.Map, 0x3709, 30, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X -1, from.Y +5, from.Z ), from.Map, 0x3709, 30, 0, 63, 0 );
//Sixth
Effects.SendLocationEffect( new Point3D( from.X + 5, from.Y , from.Z ), from.Map, 0x3709, 28, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X - 5, from.Y , from.Z ), from.Map, 0x3709, 28, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y + 5, from.Z ), from.Map, 0x3709, 28, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y - 5, from.Z ), from.Map, 0x3709, 28, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X -5, from.Y - 5, from.Z ), from.Map, 0x3709, 28, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X +5, from.Y - 5, from.Z ), from.Map, 0x3709, 28, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X -5, from.Y + 5, from.Z ), from.Map, 0x3709, 28, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X +5, from.Y + 5, from.Z ), from.Map, 0x3709, 28, 0, 63, 0 );
//Seventh
Effects.SendLocationEffect( new Point3D( from.X + 6, from.Y , from.Z ), from.Map, 0x3709, 26, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X - 6, from.Y , from.Z ), from.Map, 0x3709, 26, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y + 6, from.Z ), from.Map, 0x3709, 26, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y - 6, from.Z ), from.Map, 0x3709, 26, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X -6, from.Y - 6, from.Z ), from.Map, 0x3709, 26, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X +6, from.Y - 6, from.Z ), from.Map, 0x3709, 26, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X -6, from.Y + 6, from.Z ), from.Map, 0x3709, 26, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X +6, from.Y + 6, from.Z ), from.Map, 0x3709, 26, 0, 63, 0 );
//Eighth
Effects.SendLocationEffect( new Point3D( from.X + 7, from.Y , from.Z ), from.Map, 0x3709, 24, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X - 7, from.Y , from.Z ), from.Map, 0x3709, 24, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y + 7, from.Z ), from.Map, 0x3709, 24, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y - 7, from.Z ), from.Map, 0x3709, 24, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X -7, from.Y - 7, from.Z ), from.Map, 0x3709, 24, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X +7, from.Y - 7, from.Z ), from.Map, 0x3709, 24, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X -7, from.Y + 7, from.Z ), from.Map, 0x3709, 24, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X +7, from.Y + 7, from.Z ), from.Map, 0x3709, 24, 0, 63, 0 );
//ninth
Effects.SendLocationEffect( new Point3D( from.X + 8, from.Y , from.Z ), from.Map, 0x3709, 22, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X - 8, from.Y , from.Z ), from.Map, 0x3709, 22, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y + 8, from.Z ), from.Map, 0x3709, 22, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y - 8, from.Z ), from.Map, 0x3709, 22, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X -8, from.Y - 8, from.Z ), from.Map, 0x3709, 22, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X +8, from.Y - 8, from.Z ), from.Map, 0x3709, 22, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X -8, from.Y + 8, from.Z ), from.Map, 0x3709, 22, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X +8, from.Y + 8, from.Z ), from.Map, 0x3709, 22, 0, 63, 0 );

// Second Effect

//First row
Effects.SendLocationEffect( new Point3D( from.X + 1, from.Y , from.Z ), from.Map, 0x36BD, 38, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X - 1, from.Y , from.Z ), from.Map, 0x36BD, 38, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y + 1, from.Z ), from.Map, 0x36BD, 38, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y - 1, from.Z ), from.Map, 0x36BD, 38, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X -1, from.Y - 1, from.Z ), from.Map, 0x36BD, 38, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X +1, from.Y - 1, from.Z ), from.Map, 0x36BD, 38, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X -1, from.Y + 1, from.Z ), from.Map, 0x36BD, 38, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X +1, from.Y + 1, from.Z ), from.Map, 0x36BD, 38, 0, 1666, 0 );
//Second Row
Effects.SendLocationEffect( new Point3D( from.X + 2, from.Y , from.Z ), from.Map, 0x36BD, 34, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X - 2, from.Y , from.Z ), from.Map, 0x36BD, 34, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y + 2, from.Z ), from.Map, 0x36BD, 34, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y - 2, from.Z ), from.Map, 0x36BD, 34, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X -2, from.Y - 2, from.Z ), from.Map, 0x36BD, 34, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X +2, from.Y - 2, from.Z ), from.Map, 0x36BD, 34, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X -2, from.Y + 2, from.Z ), from.Map, 0x36BD, 34, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X +2, from.Y + 2, from.Z ), from.Map, 0x36BD, 34, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X + 2, from.Y +1, from.Z ), from.Map, 0x36BD, 34, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X - 2, from.Y -1, from.Z ), from.Map, 0x36BD, 34, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X +1, from.Y + 2, from.Z ), from.Map, 0x36BD, 34, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X -1, from.Y - 2, from.Z ), from.Map, 0x36BD, 34, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X + 2, from.Y -1, from.Z ), from.Map, 0x36BD, 34, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X - 2, from.Y +1, from.Z ), from.Map, 0x36BD, 34, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X +1, from.Y - 2, from.Z ), from.Map, 0x36BD, 34, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X -1, from.Y + 2, from.Z ), from.Map, 0x36BD, 34, 0, 1666, 0 );
//Third Row
Effects.SendLocationEffect( new Point3D( from.X + 3, from.Y , from.Z ), from.Map, 0x36BD, 34, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X +3, from.Y - 3, from.Z ), from.Map, 0x36BD, 34, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X +3, from.Y + 3, from.Z ), from.Map, 0x36BD, 34, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X - 3, from.Y , from.Z ), from.Map, 0x36BD, 34, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X -3, from.Y - 3, from.Z ), from.Map, 0x36BD, 34, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X -3, from.Y + 3, from.Z ), from.Map, 0x36BD, 34, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y + 3, from.Z ), from.Map, 0x36BD, 34, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y - 3, from.Z ), from.Map, 0x36BD, 34, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X + 3, from.Y -2, from.Z ), from.Map, 0x36BD, 34, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X +3, from.Y +2, from.Z ), from.Map, 0x36BD, 34, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X +2, from.Y + 3, from.Z ), from.Map, 0x36BD, 34, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X +2, from.Y -3, from.Z ), from.Map, 0x36BD, 34, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X -3, from.Y - 2, from.Z ), from.Map, 0x36BD, 34, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X -3, from.Y + 2, from.Z ), from.Map, 0x36BD, 34, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X -2, from.Y + 3, from.Z ), from.Map, 0x36BD, 34, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X -2, from.Y - 3, from.Z ), from.Map, 0x36BD, 34, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X + 3, from.Y -1, from.Z ), from.Map, 0x36BD, 34, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X +3, from.Y +1, from.Z ), from.Map, 0x36BD, 34, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X +1, from.Y + 3, from.Z ), from.Map, 0x36BD, 34, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X +1, from.Y -3, from.Z ), from.Map, 0x36BD, 34, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X -3, from.Y - 1, from.Z ), from.Map, 0x36BD, 34, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X -3, from.Y + 1, from.Z ), from.Map, 0x36BD, 34, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X -1, from.Y + 3, from.Z ), from.Map, 0x36BD, 34, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X -1, from.Y - 3, from.Z ), from.Map, 0x36BD, 34, 0, 1666, 0 );
//Forth Row
Effects.SendLocationEffect( new Point3D( from.X + 4, from.Y , from.Z ), from.Map, 0x36BD, 32, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X - 4, from.Y , from.Z ), from.Map, 0x36BD, 32, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y + 4, from.Z ), from.Map, 0x36BD, 32, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y - 4, from.Z ), from.Map, 0x36BD, 32, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X -4, from.Y - 4, from.Z ), from.Map, 0x36BD, 32, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X +4, from.Y - 4, from.Z ), from.Map, 0x36BD, 32, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X -4, from.Y + 4, from.Z ), from.Map, 0x36BD, 32, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X +4, from.Y + 4, from.Z ), from.Map, 0x36BD, 32, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X +4, from.Y -3, from.Z ), from.Map, 0x36BD, 32, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X +4, from.Y +3, from.Z ), from.Map, 0x36BD, 32, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X +3, from.Y -4, from.Z ), from.Map, 0x36BD, 32, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X +3, from.Y +4, from.Z ), from.Map, 0x36BD, 32, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X -4, from.Y -3, from.Z ), from.Map, 0x36BD, 32, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X -4, from.Y +3, from.Z ), from.Map, 0x36BD, 32, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X -3, from.Y -4, from.Z ), from.Map, 0x36BD, 32, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X -3, from.Y +4, from.Z ), from.Map, 0x36BD, 32, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X +4, from.Y -2, from.Z ), from.Map, 0x36BD, 32, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X +4, from.Y +2, from.Z ), from.Map, 0x36BD, 32, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X +2, from.Y -4, from.Z ), from.Map, 0x36BD, 32, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X +2, from.Y +4, from.Z ), from.Map, 0x36BD, 32, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X -4, from.Y -2, from.Z ), from.Map, 0x36BD, 32, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X -4, from.Y +2, from.Z ), from.Map, 0x36BD, 32, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X -2, from.Y -4, from.Z ), from.Map, 0x36BD, 32, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X -2, from.Y +4, from.Z ), from.Map, 0x36BD, 32, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X +4, from.Y -1, from.Z ), from.Map, 0x36BD, 32, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X +4, from.Y +1, from.Z ), from.Map, 0x36BD, 32, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X +1, from.Y -4, from.Z ), from.Map, 0x36BD, 32, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X +1, from.Y +4, from.Z ), from.Map, 0x36BD, 32, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X -4, from.Y -1, from.Z ), from.Map, 0x36BD, 32, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X -4, from.Y +1, from.Z ), from.Map, 0x36BD, 32, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X -1, from.Y -4, from.Z ), from.Map, 0x36BD, 32, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X -1, from.Y +4, from.Z ), from.Map, 0x36BD, 32, 0, 1666, 0 );
//Fifth Row
Effects.SendLocationEffect( new Point3D( from.X + 5, from.Y , from.Z ), from.Map, 0x36BD, 30, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X - 5, from.Y , from.Z ), from.Map, 0x36BD, 30, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y + 5, from.Z ), from.Map, 0x36BD, 30, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y - 5, from.Z ), from.Map, 0x36BD, 30, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X -5, from.Y - 5, from.Z ), from.Map, 0x36BD, 30, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X +5, from.Y - 5, from.Z ), from.Map, 0x36BD, 30, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X -5, from.Y + 5, from.Z ), from.Map, 0x36BD, 30, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X +5, from.Y + 5, from.Z ), from.Map, 0x36BD, 30, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X +5, from.Y -4, from.Z ), from.Map, 0x36BD, 30, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X +5, from.Y +4, from.Z ), from.Map, 0x36BD, 30, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X +4, from.Y -5, from.Z ), from.Map, 0x36BD, 30, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X +4, from.Y +5, from.Z ), from.Map, 0x36BD, 30, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X -5, from.Y -4, from.Z ), from.Map, 0x36BD, 30, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X -5, from.Y +4, from.Z ), from.Map, 0x36BD, 30, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X -4, from.Y -5, from.Z ), from.Map, 0x36BD, 30, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X -4, from.Y +5, from.Z ), from.Map, 0x36BD, 30, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X +5, from.Y -3, from.Z ), from.Map, 0x36BD, 30, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X +5, from.Y +3, from.Z ), from.Map, 0x36BD, 30, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X +3, from.Y -5, from.Z ), from.Map, 0x36BD, 30, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X +3, from.Y +5, from.Z ), from.Map, 0x36BD, 30, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X -5, from.Y -3, from.Z ), from.Map, 0x36BD, 30, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X -5, from.Y +3, from.Z ), from.Map, 0x36BD, 30, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X -3, from.Y -5, from.Z ), from.Map, 0x36BD, 30, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X -3, from.Y +5, from.Z ), from.Map, 0x36BD, 30, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X +5, from.Y -2, from.Z ), from.Map, 0x36BD, 30, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X +5, from.Y +2, from.Z ), from.Map, 0x36BD, 30, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X +2, from.Y -5, from.Z ), from.Map, 0x36BD, 30, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X +2, from.Y +5, from.Z ), from.Map, 0x36BD, 30, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X -5, from.Y -2, from.Z ), from.Map, 0x36BD, 30, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X -5, from.Y +2, from.Z ), from.Map, 0x36BD, 30, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X -2, from.Y -5, from.Z ), from.Map, 0x36BD, 30, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X -2, from.Y +5, from.Z ), from.Map, 0x36BD, 30, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X +5, from.Y -1, from.Z ), from.Map, 0x36BD, 30, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X +5, from.Y +1, from.Z ), from.Map, 0x36BD, 30, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X +1, from.Y -5, from.Z ), from.Map, 0x36BD, 30, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X +1, from.Y +5, from.Z ), from.Map, 0x36BD, 30, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X -5, from.Y -1, from.Z ), from.Map, 0x36BD, 30, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X -5, from.Y +1, from.Z ), from.Map, 0x36BD, 30, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X -1, from.Y -5, from.Z ), from.Map, 0x36BD, 30, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X -1, from.Y +5, from.Z ), from.Map, 0x36BD, 30, 0, 1666, 0 );
//Sixth
Effects.SendLocationEffect( new Point3D( from.X + 5, from.Y , from.Z ), from.Map, 0x36BD, 28, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X - 5, from.Y , from.Z ), from.Map, 0x36BD, 28, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y + 5, from.Z ), from.Map, 0x36BD, 28, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y - 5, from.Z ), from.Map, 0x36BD, 28, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X -5, from.Y - 5, from.Z ), from.Map, 0x36BD, 28, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X +5, from.Y - 5, from.Z ), from.Map, 0x36BD, 28, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X -5, from.Y + 5, from.Z ), from.Map, 0x36BD, 28, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X +5, from.Y + 5, from.Z ), from.Map, 0x36BD, 28, 0, 1666, 0 );
//Seventh
Effects.SendLocationEffect( new Point3D( from.X + 6, from.Y , from.Z ), from.Map, 0x36BD, 26, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X - 6, from.Y , from.Z ), from.Map, 0x36BD, 26, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y + 6, from.Z ), from.Map, 0x36BD, 26, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y - 6, from.Z ), from.Map, 0x36BD, 26, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X -6, from.Y - 6, from.Z ), from.Map, 0x36BD, 26, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X +6, from.Y - 6, from.Z ), from.Map, 0x36BD, 26, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X -6, from.Y + 6, from.Z ), from.Map, 0x36BD, 26, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X +6, from.Y + 6, from.Z ), from.Map, 0x36BD, 26, 0, 1666, 0 );
//Eighth
Effects.SendLocationEffect( new Point3D( from.X + 7, from.Y , from.Z ), from.Map, 0x36BD, 24, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X - 7, from.Y , from.Z ), from.Map, 0x36BD, 24, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y + 7, from.Z ), from.Map, 0x36BD, 24, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y - 7, from.Z ), from.Map, 0x36BD, 24, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X -7, from.Y - 7, from.Z ), from.Map, 0x36BD, 24, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X +7, from.Y - 7, from.Z ), from.Map, 0x36BD, 24, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X -7, from.Y + 7, from.Z ), from.Map, 0x36BD, 24, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X +7, from.Y + 7, from.Z ), from.Map, 0x36BD, 24, 0, 1666, 0 );
//ninth
Effects.SendLocationEffect( new Point3D( from.X + 8, from.Y , from.Z ), from.Map, 0x36BD, 22, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X - 8, from.Y , from.Z ), from.Map, 0x36BD, 22, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y + 8, from.Z ), from.Map, 0x36BD, 22, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y - 8, from.Z ), from.Map, 0x36BD, 22, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X -8, from.Y - 8, from.Z ), from.Map, 0x36BD, 22, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X +8, from.Y - 8, from.Z ), from.Map, 0x36BD, 22, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X -8, from.Y + 8, from.Z ), from.Map, 0x36BD, 22, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X +8, from.Y + 8, from.Z ), from.Map, 0x36BD, 22, 0, 1666, 0 );

		   from.PlaySound( 0x225 );
	       from.Hidden = true;
           
            } 
            else 
            { 
           from.Hidden=false;
           from.Emote( from.Name + " Showed Up Among Fumes");
  
Effects.SendLocationEffect( new Point3D( from.X, from.Y, from.Z ), from.Map, 0x3709, 12, 0, 63, 0 ); 

//First row
Effects.SendLocationEffect( new Point3D( from.X + 1, from.Y , from.Z ), from.Map, 0x3709, 14, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X - 1, from.Y , from.Z ), from.Map, 0x3709, 14, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y + 1, from.Z ), from.Map, 0x3709, 14, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y - 1, from.Z ), from.Map, 0x3709, 14, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X -1, from.Y - 1, from.Z ), from.Map, 0x3709, 14, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X +1, from.Y - 1, from.Z ), from.Map, 0x3709, 14, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X -1, from.Y + 1, from.Z ), from.Map, 0x3709, 14, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X +1, from.Y + 1, from.Z ), from.Map, 0x3709, 14, 0, 63, 0 );
//Second Row
Effects.SendLocationEffect( new Point3D( from.X + 2, from.Y , from.Z ), from.Map, 0x3709, 16, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X - 2, from.Y , from.Z ), from.Map, 0x3709, 16, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y + 2, from.Z ), from.Map, 0x3709, 16, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y - 2, from.Z ), from.Map, 0x3709, 16, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X -2, from.Y - 2, from.Z ), from.Map, 0x3709, 16, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X +2, from.Y - 2, from.Z ), from.Map, 0x3709, 16, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X -2, from.Y + 2, from.Z ), from.Map, 0x3709, 16, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X +2, from.Y + 2, from.Z ), from.Map, 0x3709, 16, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X + 2, from.Y +1, from.Z ), from.Map, 0x3709, 16, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X - 2, from.Y -1, from.Z ), from.Map, 0x3709, 16, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X +1, from.Y + 2, from.Z ), from.Map, 0x3709, 16, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X -1, from.Y - 2, from.Z ), from.Map, 0x3709, 16, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X + 2, from.Y -1, from.Z ), from.Map, 0x3709, 16, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X - 2, from.Y +1, from.Z ), from.Map, 0x3709, 16, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X +1, from.Y - 2, from.Z ), from.Map, 0x3709, 16, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X -1, from.Y + 2, from.Z ), from.Map, 0x3709, 16, 0, 63, 0 );
//Third Row
Effects.SendLocationEffect( new Point3D( from.X + 3, from.Y , from.Z ), from.Map, 0x3709, 18, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X +3, from.Y + 3, from.Z ), from.Map, 0x3709, 18, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X +3, from.Y - 3, from.Z ), from.Map, 0x3709, 18, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X - 3, from.Y , from.Z ), from.Map, 0x3709, 18, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X -3, from.Y - 3, from.Z ), from.Map, 0x3709, 18, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X -3, from.Y + 3, from.Z ), from.Map, 0x3709, 18, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y + 3, from.Z ), from.Map, 0x3709, 18, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y - 3, from.Z ), from.Map, 0x3709, 18, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X + 3, from.Y +2, from.Z ), from.Map, 0x3709, 18, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X -3, from.Y - 2, from.Z ), from.Map, 0x3709, 18, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X +2, from.Y + 3, from.Z ), from.Map, 0x3709, 18, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X - 2, from.Y -3, from.Z ), from.Map, 0x3709, 18, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X +3, from.Y - 2, from.Z ), from.Map, 0x3709, 18, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X -3, from.Y + 2, from.Z ), from.Map, 0x3709, 18, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X +2, from.Y - 3, from.Z ), from.Map, 0x3709, 18, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X -2, from.Y + 3, from.Z ), from.Map, 0x3709, 18, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X + 3, from.Y +1, from.Z ), from.Map, 0x3709, 18, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X -3, from.Y - 1, from.Z ), from.Map, 0x3709, 18, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X +1, from.Y + 3, from.Z ), from.Map, 0x3709, 18, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X - 1, from.Y -3, from.Z ), from.Map, 0x3709, 18, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X +3, from.Y - 1, from.Z ), from.Map, 0x3709, 18, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X -3, from.Y + 1, from.Z ), from.Map, 0x3709, 18, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X +1, from.Y - 3, from.Z ), from.Map, 0x3709, 18, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X -1, from.Y + 3, from.Z ), from.Map, 0x3709, 18, 0, 63, 0 );
//Forth Row
Effects.SendLocationEffect( new Point3D( from.X + 4, from.Y , from.Z ), from.Map, 0x3709, 20, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X - 4, from.Y , from.Z ), from.Map, 0x3709, 20, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y + 4, from.Z ), from.Map, 0x3709, 20, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y - 4, from.Z ), from.Map, 0x3709, 20, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X -4, from.Y - 4, from.Z ), from.Map, 0x3709, 20, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X +4, from.Y - 4, from.Z ), from.Map, 0x3709, 20, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X -4, from.Y + 4, from.Z ), from.Map, 0x3709, 20, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X +4, from.Y + 4, from.Z ), from.Map, 0x3709, 20, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X +4, from.Y -3, from.Z ), from.Map, 0x3709, 20, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X +4, from.Y +3, from.Z ), from.Map, 0x3709, 20, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X +3, from.Y -4, from.Z ), from.Map, 0x3709, 20, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X +3, from.Y +4, from.Z ), from.Map, 0x3709, 20, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X -4, from.Y -3, from.Z ), from.Map, 0x3709, 20, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X -4, from.Y +3, from.Z ), from.Map, 0x3709, 20, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X -3, from.Y -4, from.Z ), from.Map, 0x3709, 20, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X -3, from.Y +4, from.Z ), from.Map, 0x3709, 20, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X +4, from.Y -2, from.Z ), from.Map, 0x3709, 20, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X +4, from.Y +2, from.Z ), from.Map, 0x3709, 20, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X +2, from.Y -4, from.Z ), from.Map, 0x3709, 20, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X +2, from.Y +4, from.Z ), from.Map, 0x3709, 20, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X -4, from.Y -2, from.Z ), from.Map, 0x3709, 20, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X -4, from.Y +2, from.Z ), from.Map, 0x3709, 20, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X -2, from.Y -4, from.Z ), from.Map, 0x3709, 20, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X -2, from.Y +4, from.Z ), from.Map, 0x3709, 20, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X +4, from.Y -1, from.Z ), from.Map, 0x3709, 20, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X +4, from.Y +1, from.Z ), from.Map, 0x3709, 20, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X +1, from.Y -4, from.Z ), from.Map, 0x3709, 20, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X +1, from.Y +4, from.Z ), from.Map, 0x3709, 20, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X -4, from.Y -1, from.Z ), from.Map, 0x3709, 20, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X -4, from.Y +1, from.Z ), from.Map, 0x3709, 20, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X -1, from.Y -4, from.Z ), from.Map, 0x3709, 20, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X -1, from.Y +4, from.Z ), from.Map, 0x3709, 20, 0, 63, 0 );
//Fifth Row
Effects.SendLocationEffect( new Point3D( from.X + 5, from.Y , from.Z ), from.Map, 0x3709, 22, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X - 5, from.Y , from.Z ), from.Map, 0x3709, 22, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y + 5, from.Z ), from.Map, 0x3709, 22, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y - 5, from.Z ), from.Map, 0x3709, 22, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X -5, from.Y - 5, from.Z ), from.Map, 0x3709, 22, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X +5, from.Y - 5, from.Z ), from.Map, 0x3709, 22, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X -5, from.Y + 5, from.Z ), from.Map, 0x3709, 22, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X +5, from.Y + 5, from.Z ), from.Map, 0x3709, 22, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X + 5, from.Y , from.Z ), from.Map, 0x3709, 22, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X - 5, from.Y , from.Z ), from.Map, 0x3709, 22, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y + 5, from.Z ), from.Map, 0x3709, 22, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y - 5, from.Z ), from.Map, 0x3709, 22, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X -5, from.Y - 5, from.Z ), from.Map, 0x3709, 22, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X +5, from.Y - 5, from.Z ), from.Map, 0x3709, 22, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X -5, from.Y + 5, from.Z ), from.Map, 0x3709, 22, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X +5, from.Y + 5, from.Z ), from.Map, 0x3709, 22, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X +5, from.Y -4, from.Z ), from.Map, 0x3709, 22, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X +5, from.Y +4, from.Z ), from.Map, 0x3709, 22, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X +4, from.Y -5, from.Z ), from.Map, 0x3709, 22, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X +4, from.Y +5, from.Z ), from.Map, 0x3709, 22, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X -5, from.Y -4, from.Z ), from.Map, 0x3709, 22, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X -5, from.Y +4, from.Z ), from.Map, 0x3709, 22, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X -4, from.Y -5, from.Z ), from.Map, 0x3709, 22, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X -4, from.Y +5, from.Z ), from.Map, 0x3709, 22, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X +5, from.Y -3, from.Z ), from.Map, 0x3709, 22, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X +5, from.Y +3, from.Z ), from.Map, 0x3709, 22, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X +3, from.Y -5, from.Z ), from.Map, 0x3709, 22, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X +3, from.Y +5, from.Z ), from.Map, 0x3709, 22, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X -5, from.Y -3, from.Z ), from.Map, 0x3709, 22, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X -5, from.Y +3, from.Z ), from.Map, 0x3709, 22, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X -3, from.Y -5, from.Z ), from.Map, 0x3709, 22, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X -3, from.Y +5, from.Z ), from.Map, 0x3709, 22, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X +5, from.Y -2, from.Z ), from.Map, 0x3709, 22, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X +5, from.Y +2, from.Z ), from.Map, 0x3709, 22, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X +2, from.Y -5, from.Z ), from.Map, 0x3709, 22, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X +2, from.Y +5, from.Z ), from.Map, 0x3709, 22, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X -5, from.Y -2, from.Z ), from.Map, 0x3709, 22, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X -5, from.Y +2, from.Z ), from.Map, 0x3709, 22, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X -2, from.Y -5, from.Z ), from.Map, 0x3709, 22, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X -2, from.Y +5, from.Z ), from.Map, 0x3709, 22, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X +5, from.Y -1, from.Z ), from.Map, 0x3709, 22, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X +5, from.Y +1, from.Z ), from.Map, 0x3709, 22, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X +1, from.Y -5, from.Z ), from.Map, 0x3709, 22, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X +1, from.Y +5, from.Z ), from.Map, 0x3709, 22, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X -5, from.Y -1, from.Z ), from.Map, 0x3709, 22, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X -5, from.Y +1, from.Z ), from.Map, 0x3709, 22, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X -1, from.Y -5, from.Z ), from.Map, 0x3709, 22, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X -1, from.Y +5, from.Z ), from.Map, 0x3709, 22, 0, 63, 0 );
//Sixth
Effects.SendLocationEffect( new Point3D( from.X + 5, from.Y , from.Z ), from.Map, 0x3709, 24, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X - 5, from.Y , from.Z ), from.Map, 0x3709, 24, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y + 5, from.Z ), from.Map, 0x3709, 24, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y - 5, from.Z ), from.Map, 0x3709, 24, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X -5, from.Y - 5, from.Z ), from.Map, 0x3709, 24, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X +5, from.Y - 5, from.Z ), from.Map, 0x3709, 24, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X -5, from.Y + 5, from.Z ), from.Map, 0x3709, 24, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X +5, from.Y + 5, from.Z ), from.Map, 0x3709, 24, 0, 63, 0 );
//Seventh
Effects.SendLocationEffect( new Point3D( from.X + 6, from.Y , from.Z ), from.Map, 0x3709, 26, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X - 6, from.Y , from.Z ), from.Map, 0x3709, 26, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y + 6, from.Z ), from.Map, 0x3709, 26, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y - 6, from.Z ), from.Map, 0x3709, 26, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X -6, from.Y - 6, from.Z ), from.Map, 0x3709, 26, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X +6, from.Y - 6, from.Z ), from.Map, 0x3709, 26, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X -6, from.Y + 6, from.Z ), from.Map, 0x3709, 26, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X +6, from.Y + 6, from.Z ), from.Map, 0x3709, 26, 0, 63, 0 );
//Eighth
Effects.SendLocationEffect( new Point3D( from.X + 7, from.Y , from.Z ), from.Map, 0x3709, 28, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X - 7, from.Y , from.Z ), from.Map, 0x3709, 28, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y + 7, from.Z ), from.Map, 0x3709, 28, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y - 7, from.Z ), from.Map, 0x3709, 28, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X -7, from.Y - 7, from.Z ), from.Map, 0x3709, 28, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X +7, from.Y - 7, from.Z ), from.Map, 0x3709, 28, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X -7, from.Y + 7, from.Z ), from.Map, 0x3709, 28, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X +7, from.Y + 7, from.Z ), from.Map, 0x3709, 28, 0, 63, 0 );
//ninth
Effects.SendLocationEffect( new Point3D( from.X + 8, from.Y , from.Z ), from.Map, 0x3709, 30, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X - 8, from.Y , from.Z ), from.Map, 0x3709, 30, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y + 8, from.Z ), from.Map, 0x3709, 30, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y - 8, from.Z ), from.Map, 0x3709, 30, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X -8, from.Y - 8, from.Z ), from.Map, 0x3709, 30, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X +8, from.Y - 8, from.Z ), from.Map, 0x3709, 30, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X -8, from.Y + 8, from.Z ), from.Map, 0x3709, 30, 0, 63, 0 );
Effects.SendLocationEffect( new Point3D( from.X +8, from.Y + 8, from.Z ), from.Map, 0x3709, 30, 0, 63, 0 );

//Second Effect

//First row
Effects.SendLocationEffect( new Point3D( from.X + 1, from.Y , from.Z ), from.Map, 0x36BD, 14, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X - 1, from.Y , from.Z ), from.Map, 0x36BD, 14, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y + 1, from.Z ), from.Map, 0x36BD, 14, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y - 1, from.Z ), from.Map, 0x36BD, 14, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X -1, from.Y - 1, from.Z ), from.Map, 0x36BD, 14, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X +1, from.Y - 1, from.Z ), from.Map, 0x36BD, 14, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X -1, from.Y + 1, from.Z ), from.Map, 0x36BD, 14, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X +1, from.Y + 1, from.Z ), from.Map, 0x36BD, 14, 0, 1666, 0 );
//Second Row
Effects.SendLocationEffect( new Point3D( from.X + 2, from.Y , from.Z ), from.Map, 0x36BD, 16, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X - 2, from.Y , from.Z ), from.Map, 0x36BD, 16, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y + 2, from.Z ), from.Map, 0x36BD, 16, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y - 2, from.Z ), from.Map, 0x36BD, 16, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X -2, from.Y - 2, from.Z ), from.Map, 0x36BD, 16, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X +2, from.Y - 2, from.Z ), from.Map, 0x36BD, 16, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X -2, from.Y + 2, from.Z ), from.Map, 0x36BD, 16, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X +2, from.Y + 2, from.Z ), from.Map, 0x36BD, 16, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X + 2, from.Y +1, from.Z ), from.Map, 0x36BD, 16, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X - 2, from.Y -1, from.Z ), from.Map, 0x36BD, 16, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X +1, from.Y + 2, from.Z ), from.Map, 0x36BD, 16, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X -1, from.Y - 2, from.Z ), from.Map, 0x36BD, 16, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X + 2, from.Y -1, from.Z ), from.Map, 0x36BD, 16, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X - 2, from.Y +1, from.Z ), from.Map, 0x36BD, 16, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X +1, from.Y - 2, from.Z ), from.Map, 0x36BD, 16, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X -1, from.Y + 2, from.Z ), from.Map, 0x36BD, 16, 0, 1666, 0 );
//Third Row
Effects.SendLocationEffect( new Point3D( from.X + 3, from.Y , from.Z ), from.Map, 0x36BD, 18, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X +3, from.Y + 3, from.Z ), from.Map, 0x36BD, 18, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X +3, from.Y - 3, from.Z ), from.Map, 0x36BD, 18, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X - 3, from.Y , from.Z ), from.Map, 0x36BD, 18, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X -3, from.Y - 3, from.Z ), from.Map, 0x36BD, 18, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X -3, from.Y + 3, from.Z ), from.Map, 0x36BD, 18, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y + 3, from.Z ), from.Map, 0x36BD, 18, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y - 3, from.Z ), from.Map, 0x36BD, 18, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X + 3, from.Y +2, from.Z ), from.Map, 0x36BD, 18, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X -3, from.Y - 2, from.Z ), from.Map, 0x36BD, 18, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X +2, from.Y + 3, from.Z ), from.Map, 0x36BD, 18, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X - 2, from.Y -3, from.Z ), from.Map, 0x36BD, 18, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X +3, from.Y - 2, from.Z ), from.Map, 0x36BD, 18, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X -3, from.Y + 2, from.Z ), from.Map, 0x36BD, 18, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X +2, from.Y - 3, from.Z ), from.Map, 0x36BD, 18, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X -2, from.Y + 3, from.Z ), from.Map, 0x36BD, 18, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X + 3, from.Y +1, from.Z ), from.Map, 0x36BD, 18, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X -3, from.Y - 1, from.Z ), from.Map, 0x36BD, 18, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X +1, from.Y + 3, from.Z ), from.Map, 0x36BD, 18, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X - 1, from.Y -3, from.Z ), from.Map, 0x36BD, 18, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X +3, from.Y - 1, from.Z ), from.Map, 0x36BD, 18, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X -3, from.Y + 1, from.Z ), from.Map, 0x36BD, 18, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X +1, from.Y - 3, from.Z ), from.Map, 0x36BD, 18, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X -1, from.Y + 3, from.Z ), from.Map, 0x36BD, 18, 0, 1666, 0 );
//Forth Row
Effects.SendLocationEffect( new Point3D( from.X + 4, from.Y , from.Z ), from.Map, 0x36BD, 20, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X - 4, from.Y , from.Z ), from.Map, 0x36BD, 20, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y + 4, from.Z ), from.Map, 0x36BD, 20, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y - 4, from.Z ), from.Map, 0x36BD, 20, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X -4, from.Y - 4, from.Z ), from.Map, 0x36BD, 20, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X +4, from.Y - 4, from.Z ), from.Map, 0x36BD, 20, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X -4, from.Y + 4, from.Z ), from.Map, 0x36BD, 20, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X +4, from.Y + 4, from.Z ), from.Map, 0x36BD, 20, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X +4, from.Y -3, from.Z ), from.Map, 0x36BD, 20, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X +4, from.Y +3, from.Z ), from.Map, 0x36BD, 20, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X +3, from.Y -4, from.Z ), from.Map, 0x36BD, 20, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X +3, from.Y +4, from.Z ), from.Map, 0x36BD, 20, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X -4, from.Y -3, from.Z ), from.Map, 0x36BD, 20, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X -4, from.Y +3, from.Z ), from.Map, 0x36BD, 20, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X -3, from.Y -4, from.Z ), from.Map, 0x36BD, 20, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X -3, from.Y +4, from.Z ), from.Map, 0x36BD, 20, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X +4, from.Y -2, from.Z ), from.Map, 0x36BD, 20, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X +4, from.Y +2, from.Z ), from.Map, 0x36BD, 20, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X +2, from.Y -4, from.Z ), from.Map, 0x36BD, 20, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X +2, from.Y +4, from.Z ), from.Map, 0x36BD, 20, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X -4, from.Y -2, from.Z ), from.Map, 0x36BD, 20, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X -4, from.Y +2, from.Z ), from.Map, 0x36BD, 20, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X -2, from.Y -4, from.Z ), from.Map, 0x36BD, 20, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X -2, from.Y +4, from.Z ), from.Map, 0x36BD, 20, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X +4, from.Y -1, from.Z ), from.Map, 0x36BD, 20, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X +4, from.Y +1, from.Z ), from.Map, 0x36BD, 20, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X +1, from.Y -4, from.Z ), from.Map, 0x36BD, 20, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X +1, from.Y +4, from.Z ), from.Map, 0x36BD, 20, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X -4, from.Y -1, from.Z ), from.Map, 0x36BD, 20, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X -4, from.Y +1, from.Z ), from.Map, 0x36BD, 20, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X -1, from.Y -4, from.Z ), from.Map, 0x36BD, 20, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X -1, from.Y +4, from.Z ), from.Map, 0x36BD, 20, 0, 1666, 0 );
//Fifth Row
Effects.SendLocationEffect( new Point3D( from.X + 5, from.Y , from.Z ), from.Map, 0x36BD, 22, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X - 5, from.Y , from.Z ), from.Map, 0x36BD, 22, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y + 5, from.Z ), from.Map, 0x36BD, 22, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y - 5, from.Z ), from.Map, 0x36BD, 22, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X -5, from.Y - 5, from.Z ), from.Map, 0x36BD, 22, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X +5, from.Y - 5, from.Z ), from.Map, 0x36BD, 22, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X -5, from.Y + 5, from.Z ), from.Map, 0x36BD, 22, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X +5, from.Y + 5, from.Z ), from.Map, 0x36BD, 22, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X + 5, from.Y , from.Z ), from.Map, 0x36BD, 22, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X - 5, from.Y , from.Z ), from.Map, 0x36BD, 22, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y + 5, from.Z ), from.Map, 0x36BD, 22, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y - 5, from.Z ), from.Map, 0x36BD, 22, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X -5, from.Y - 5, from.Z ), from.Map, 0x36BD, 22, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X +5, from.Y - 5, from.Z ), from.Map, 0x36BD, 22, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X -5, from.Y + 5, from.Z ), from.Map, 0x36BD, 22, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X +5, from.Y + 5, from.Z ), from.Map, 0x36BD, 22, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X +5, from.Y -4, from.Z ), from.Map, 0x36BD, 22, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X +5, from.Y +4, from.Z ), from.Map, 0x36BD, 22, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X +4, from.Y -5, from.Z ), from.Map, 0x36BD, 22, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X +4, from.Y +5, from.Z ), from.Map, 0x36BD, 22, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X -5, from.Y -4, from.Z ), from.Map, 0x36BD, 22, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X -5, from.Y +4, from.Z ), from.Map, 0x36BD, 22, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X -4, from.Y -5, from.Z ), from.Map, 0x36BD, 22, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X -4, from.Y +5, from.Z ), from.Map, 0x36BD, 22, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X +5, from.Y -3, from.Z ), from.Map, 0x36BD, 22, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X +5, from.Y +3, from.Z ), from.Map, 0x36BD, 22, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X +3, from.Y -5, from.Z ), from.Map, 0x36BD, 22, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X +3, from.Y +5, from.Z ), from.Map, 0x36BD, 22, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X -5, from.Y -3, from.Z ), from.Map, 0x36BD, 22, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X -5, from.Y +3, from.Z ), from.Map, 0x36BD, 22, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X -3, from.Y -5, from.Z ), from.Map, 0x36BD, 22, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X -3, from.Y +5, from.Z ), from.Map, 0x36BD, 22, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X +5, from.Y -2, from.Z ), from.Map, 0x36BD, 22, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X +5, from.Y +2, from.Z ), from.Map, 0x36BD, 22, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X +2, from.Y -5, from.Z ), from.Map, 0x36BD, 22, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X +2, from.Y +5, from.Z ), from.Map, 0x36BD, 22, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X -5, from.Y -2, from.Z ), from.Map, 0x36BD, 22, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X -5, from.Y +2, from.Z ), from.Map, 0x36BD, 22, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X -2, from.Y -5, from.Z ), from.Map, 0x36BD, 22, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X -2, from.Y +5, from.Z ), from.Map, 0x36BD, 22, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X +5, from.Y -1, from.Z ), from.Map, 0x36BD, 22, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X +5, from.Y +1, from.Z ), from.Map, 0x36BD, 22, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X +1, from.Y -5, from.Z ), from.Map, 0x36BD, 22, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X +1, from.Y +5, from.Z ), from.Map, 0x36BD, 22, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X -5, from.Y -1, from.Z ), from.Map, 0x36BD, 22, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X -5, from.Y +1, from.Z ), from.Map, 0x36BD, 22, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X -1, from.Y -5, from.Z ), from.Map, 0x36BD, 22, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X -1, from.Y +5, from.Z ), from.Map, 0x36BD, 22, 0, 1666, 0 );
//Sixth
Effects.SendLocationEffect( new Point3D( from.X + 5, from.Y , from.Z ), from.Map, 0x36BD, 24, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X - 5, from.Y , from.Z ), from.Map, 0x36BD, 24, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y + 5, from.Z ), from.Map, 0x36BD, 24, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y - 5, from.Z ), from.Map, 0x36BD, 24, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X -5, from.Y - 5, from.Z ), from.Map, 0x36BD, 24, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X +5, from.Y - 5, from.Z ), from.Map, 0x36BD, 24, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X -5, from.Y + 5, from.Z ), from.Map, 0x36BD, 24, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X +5, from.Y + 5, from.Z ), from.Map, 0x36BD, 24, 0, 1666, 0 );
//Seventh
Effects.SendLocationEffect( new Point3D( from.X + 6, from.Y , from.Z ), from.Map, 0x36BD, 26, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X - 6, from.Y , from.Z ), from.Map, 0x36BD, 26, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y + 6, from.Z ), from.Map, 0x36BD, 26, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y - 6, from.Z ), from.Map, 0x36BD, 26, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X -6, from.Y - 6, from.Z ), from.Map, 0x36BD, 26, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X +6, from.Y - 6, from.Z ), from.Map, 0x36BD, 26, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X -6, from.Y + 6, from.Z ), from.Map, 0x36BD, 26, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X +6, from.Y + 6, from.Z ), from.Map, 0x36BD, 26, 0, 1666, 0 );
//Eighth
Effects.SendLocationEffect( new Point3D( from.X + 7, from.Y , from.Z ), from.Map, 0x36BD, 28, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X - 7, from.Y , from.Z ), from.Map, 0x36BD, 28, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y + 7, from.Z ), from.Map, 0x36BD, 28, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y - 7, from.Z ), from.Map, 0x36BD, 28, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X -7, from.Y - 7, from.Z ), from.Map, 0x36BD, 28, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X +7, from.Y - 7, from.Z ), from.Map, 0x36BD, 28, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X -7, from.Y + 7, from.Z ), from.Map, 0x36BD, 28, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X +7, from.Y + 7, from.Z ), from.Map, 0x36BD, 28, 0, 1666, 0 );
//ninth
Effects.SendLocationEffect( new Point3D( from.X + 8, from.Y , from.Z ), from.Map, 0x36BD, 30, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X - 8, from.Y , from.Z ), from.Map, 0x36BD, 30, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y + 8, from.Z ), from.Map, 0x36BD, 30, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X, from.Y - 8, from.Z ), from.Map, 0x36BD, 30, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X -8, from.Y - 8, from.Z ), from.Map, 0x36BD, 30, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X +8, from.Y - 8, from.Z ), from.Map, 0x36BD, 30, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X -8, from.Y + 8, from.Z ), from.Map, 0x36BD, 30, 0, 1666, 0 );
Effects.SendLocationEffect( new Point3D( from.X +8, from.Y + 8, from.Z ), from.Map, 0x36BD, 30, 0, 1666, 0 );
		   from.PlaySound( 0x225 );

                      
            } 
      } 

	}
       
      public OslinsHidingRobe( Serial serial ) : base( serial ) 
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