using System; 
using Server; 

namespace Server.Items 
{ 
	public class LivingMandrakeroot : Item
	{ 

             [Constructable]
             public LivingMandrakeroot() : base( 0xC62 ) 
	     {
                    Movable = false;
                    Hue = 651;
                    Weight = 0.0; 
		    Name = "Living Mandrake Root"; 


	     }  
            
             public LivingMandrakeroot( Serial serial ) : base( serial ) 
	     { 
	     } 

             public override void Serialize( GenericWriter writer ) 
	     { 
			base.Serialize( writer ); 
			writer.Write( (int) 0 ); 
	     } 

             public override void Deserialize(GenericReader reader) 
	     { 
			base.Deserialize( reader ); 
			int version = reader.ReadInt(); 
	     }

             public override void OnDoubleClick( Mobile from ) 
	     {

                        MandrakeRoot root = new MandrakeRoot( 50 );

	                if ( !from.AddToBackpack( root ) ) 
		           root.Delete();    
                         
                        from.Damage( 45 );
                        this.Delete(); 

 
                        from.PlaySound( 603 );                  
                        
                        switch ( Utility.Random( 2 ) )
			{
				default:
				case  0: from.SendMessage( "The plant is pulled from the ground, It then shrieks in pain " ); break;
				
			}
		}
	} 
}