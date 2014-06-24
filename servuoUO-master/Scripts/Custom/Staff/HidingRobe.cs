using System; 
using Server; 
using Server.Misc;
using Server.Items; 
using Server.Targeting; 

namespace Server.Items 
{
	[FlipableAttribute( 0x7939, 0x7940 )] 
   public class HidingRobe  : BaseOuterTorso  
   { 
		private int m_UnHideEffect1ID;
		private int m_UnHideEffect1Hue;
		private int m_UnHideEffect1RenderMode;
		private int m_HideEffect1ID;
		private int m_HideEffect1Hue;
		private int m_HideEffect1RenderMode;
		private int m_UnHideEffect2ID;
		private int m_UnHideEffect2Hue;
		private int m_UnHideEffect2RenderMode;
		private int m_HideEffect2ID;
		private int m_HideEffect2Hue;
		private int m_HideEffect2RenderMode;
		private int m_UnHideSound;
		private int m_HideSound;
		private string m_UnHideSaying;
		private string m_HideSaying;
		private bool m_AreaEffect;

		[CommandProperty( AccessLevel.GameMaster )] 
		public int UnHideEffect1ID 
		{ 
			get { return m_UnHideEffect1ID; } 
			set { m_UnHideEffect1ID = value; } 
		} 
		[CommandProperty( AccessLevel.GameMaster )] 
		public int UnHideEffect1Hue 
		{ 
			get { return m_UnHideEffect1Hue; } 
			set { m_UnHideEffect1Hue = value; } 
		} 
		[CommandProperty( AccessLevel.GameMaster )] 
		public int UnHideEffect1RenderMode
		{ 
			get { return m_UnHideEffect1RenderMode; } 
			set { m_UnHideEffect1RenderMode = value; } 
		} 
		[CommandProperty( AccessLevel.GameMaster )] 
		public int HideEffect1ID 
		{ 
			get { return m_HideEffect1ID; } 
			set { m_HideEffect1ID = value; } 
		} 
		[CommandProperty( AccessLevel.GameMaster )] 
		public int HideEffect1Hue 
		{ 
			get { return m_HideEffect1Hue; } 
			set { m_HideEffect1Hue = value; } 
		} 
		[CommandProperty( AccessLevel.GameMaster )] 
		public int HideEffect1RenderMode 
		{ 
			get { return m_HideEffect1RenderMode; } 
			set { m_HideEffect1RenderMode = value; } 
		} 
		
		[CommandProperty( AccessLevel.GameMaster )] 
		public int UnHideEffect2ID 
		{ 
			get { return m_UnHideEffect2ID; } 
			set { m_UnHideEffect2ID = value; } 
		} 
		[CommandProperty( AccessLevel.GameMaster )] 
		public int UnHideEffect2Hue 
		{ 
			get { return m_UnHideEffect2Hue; } 
			set { m_UnHideEffect2Hue = value; } 
		} 

		[CommandProperty( AccessLevel.GameMaster )] 
		public int UnHideEffect2RenderMode
		{ 
			get { return m_UnHideEffect2RenderMode; } 
			set { m_UnHideEffect2RenderMode = value; } 
		} 
		[CommandProperty( AccessLevel.GameMaster )] 
		public int HideEffect2ID 
		{ 
			get { return m_HideEffect2ID; } 
			set { m_HideEffect2ID = value; } 
		} 
		[CommandProperty( AccessLevel.GameMaster )] 
		public int HideEffect2Hue 
		{ 
			get { return m_HideEffect2Hue; } 
			set { m_HideEffect2Hue = value; } 
		} 
		
		[CommandProperty( AccessLevel.GameMaster )] 
		public int HideEffect2RenderMode 
		{ 
			get { return m_HideEffect2RenderMode; } 
			set { m_HideEffect2RenderMode = value; } 
		} 
		
		[CommandProperty( AccessLevel.GameMaster )] 
		public int HideSound 
		{ 
			get { return m_HideSound; } 
			set { m_HideSound = value; } 
		} 
		[CommandProperty( AccessLevel.GameMaster )] 
		public int UnHideSound 
		{ 
			get { return m_UnHideSound; } 
			set { m_UnHideSound = value; } 
		} 
		[CommandProperty( AccessLevel.GameMaster )] 
		public string HideSaying 
		{ 
			get { return m_HideSaying; } 
			set { m_HideSaying = value; } 
		} 
		[CommandProperty( AccessLevel.GameMaster )] 
		public string UnHideSaying 
		{ 
			get { return m_UnHideSaying; } 
			set { m_UnHideSaying = value; } 
		} 
		[CommandProperty( AccessLevel.GameMaster )] 
		public bool AreaEffect 
		{ 
			get { return m_AreaEffect; } 
			set { m_AreaEffect = value; } 
		} 
		
   
      [Constructable] 
      public HidingRobe() :  base( 0x204F ) 
      { 
         Weight = 1.0; 
         Hue = 1984; 
         Name = "GM Robe"; 
         LootType = LootType.Blessed;
      } 
      public HidingRobe( Serial serial ) : base( serial ) 
      {     
      } 
	  
      public override bool OnEquip( Mobile from )
		{
     from.LightLevel = 25;
     return base.OnEquip( from );
		}
	  
    public override void OnDoubleClick( Mobile from ) 
	{ 
			if( Parent != from )
			{
				from.SendMessage( "You must be wearing the robe to use it!" );
			}
			if (from.AccessLevel < AccessLevel.GameMaster)
			from.SendMessage( "When you touch, it vanishes without trace..." );
			if (from.AccessLevel < AccessLevel.GameMaster)
			this.Consume() ;
			if (from.AccessLevel < AccessLevel.GameMaster)
			return ;
		{          	 
			if ( !from.Hidden == true )
			{ 
					from.Emote( from.Name + HideSaying );
					/*
				SendLocationEffect( IPoint3D p, Map map, int itemID, int duration, int speed, int hue, int renderMode )
				rendermode
				0 = regular hue chosen without any change.
				1 = creates a 'black' effect that when it hits the target, becomes a black outlined, transparent dark red/transparent ball of fire, not matter what the original hue chosen is. (the ball of fire is due to my own choice of explosion end effect)
				2 = creates a slightly transparent end effect in whichever hue you have chosen. There are no shadows in the effect (aka no black at all).
				3 = appears to be the same as 2.
				4 = like 2 and 3, but with a little shadow in it (aka a little black to add to the demension of the effect).
				5 = more transparent, and more black shadow.
				6 = transparent and black regardless of the hue that is chosen.
				7 = more true to the hue chosen, but dark and transparent. I would say that it has more contrast between the hue and the black shadow-like quality.
				*/		  
		   
Effects.SendLocationEffect( new Point3D( from.X, from.Y, from.Z ), from.Map, HideEffect1ID, 40, 0, HideEffect1Hue, HideEffect1RenderMode ); 
Effects.SendLocationEffect( new Point3D( from.X, from.Y, from.Z ), from.Map, HideEffect2ID, 40, 0, HideEffect2Hue, HideEffect2RenderMode ); 
//First row
Effects.SendLocationEffect( new Point3D( from.X + 1, from.Y , from.Z ), from.Map, HideEffect1ID, 38, 0, HideEffect1Hue, HideEffect1RenderMode );
Effects.SendLocationEffect( new Point3D( from.X - 1, from.Y , from.Z ), from.Map, HideEffect1ID, 38, 0, HideEffect1Hue, HideEffect1RenderMode );
Effects.SendLocationEffect( new Point3D( from.X, from.Y + 1, from.Z ), from.Map, HideEffect1ID, 38, 0, HideEffect1Hue, HideEffect1RenderMode );
Effects.SendLocationEffect( new Point3D( from.X, from.Y - 1, from.Z ), from.Map, HideEffect1ID, 38, 0, HideEffect1Hue, HideEffect1RenderMode );
Effects.SendLocationEffect( new Point3D( from.X -1, from.Y - 1, from.Z ), from.Map, HideEffect1ID, 38, 0, HideEffect1Hue, HideEffect1RenderMode );
Effects.SendLocationEffect( new Point3D( from.X +1, from.Y - 1, from.Z ), from.Map, HideEffect1ID, 38, 0, HideEffect1Hue, HideEffect1RenderMode );
Effects.SendLocationEffect( new Point3D( from.X -1, from.Y + 1, from.Z ), from.Map, HideEffect1ID, 38, 0, HideEffect1Hue, HideEffect1RenderMode );
Effects.SendLocationEffect( new Point3D( from.X +1, from.Y + 1, from.Z ), from.Map, HideEffect1ID, 38, 0, HideEffect1Hue, HideEffect1RenderMode );
Effects.SendLocationEffect( new Point3D( from.X + 1, from.Y , from.Z ), from.Map, HideEffect2ID, 38, 0, HideEffect1Hue, HideEffect2RenderMode );
Effects.SendLocationEffect( new Point3D( from.X - 1, from.Y , from.Z ), from.Map, HideEffect2ID, 38, 0, HideEffect1Hue, HideEffect2RenderMode );
Effects.SendLocationEffect( new Point3D( from.X, from.Y + 1, from.Z ), from.Map, HideEffect2ID, 38, 0, HideEffect1Hue, HideEffect2RenderMode );
Effects.SendLocationEffect( new Point3D( from.X, from.Y - 1, from.Z ), from.Map, HideEffect2ID, 38, 0, HideEffect1Hue, HideEffect2RenderMode );
Effects.SendLocationEffect( new Point3D( from.X -1, from.Y - 1, from.Z ), from.Map, HideEffect2ID, 38, 0, HideEffect1Hue, HideEffect2RenderMode );
Effects.SendLocationEffect( new Point3D( from.X +1, from.Y - 1, from.Z ), from.Map, HideEffect2ID, 38, 0, HideEffect1Hue, HideEffect2RenderMode );
Effects.SendLocationEffect( new Point3D( from.X -1, from.Y + 1, from.Z ), from.Map, HideEffect2ID, 38, 0, HideEffect1Hue, HideEffect2RenderMode );
Effects.SendLocationEffect( new Point3D( from.X +1, from.Y + 1, from.Z ), from.Map, HideEffect2ID, 38, 0, HideEffect1Hue, HideEffect2RenderMode );
//Second Row
Effects.SendLocationEffect( new Point3D( from.X + 2, from.Y , from.Z ), from.Map, HideEffect1ID, 36, 0, HideEffect1Hue, HideEffect1RenderMode );
Effects.SendLocationEffect( new Point3D( from.X - 2, from.Y , from.Z ), from.Map, HideEffect1ID, 36, 0, HideEffect1Hue, HideEffect1RenderMode );
Effects.SendLocationEffect( new Point3D( from.X, from.Y + 2, from.Z ), from.Map, HideEffect1ID, 36, 0, HideEffect1Hue, HideEffect1RenderMode );
Effects.SendLocationEffect( new Point3D( from.X, from.Y - 2, from.Z ), from.Map, HideEffect1ID, 36, 0, HideEffect1Hue, HideEffect1RenderMode );
Effects.SendLocationEffect( new Point3D( from.X -2, from.Y - 2, from.Z ), from.Map, HideEffect1ID, 36, 0, HideEffect1Hue, HideEffect1RenderMode );
Effects.SendLocationEffect( new Point3D( from.X +2, from.Y - 2, from.Z ), from.Map, HideEffect1ID, 36, 0, HideEffect1Hue, HideEffect1RenderMode );
Effects.SendLocationEffect( new Point3D( from.X -2, from.Y + 2, from.Z ), from.Map, HideEffect1ID, 36, 0, HideEffect1Hue, HideEffect1RenderMode );
Effects.SendLocationEffect( new Point3D( from.X +2, from.Y + 2, from.Z ), from.Map, HideEffect1ID, 36, 0, HideEffect1Hue, HideEffect1RenderMode );
Effects.SendLocationEffect( new Point3D( from.X + 2, from.Y +1, from.Z ), from.Map, HideEffect1ID, 36, 0, HideEffect1Hue, HideEffect1RenderMode );
Effects.SendLocationEffect( new Point3D( from.X - 2, from.Y -1, from.Z ), from.Map, HideEffect1ID, 36, 0, HideEffect1Hue, HideEffect1RenderMode );
Effects.SendLocationEffect( new Point3D( from.X +1, from.Y + 2, from.Z ), from.Map, HideEffect1ID, 36, 0, HideEffect1Hue, HideEffect1RenderMode );
Effects.SendLocationEffect( new Point3D( from.X -1, from.Y - 2, from.Z ), from.Map, HideEffect1ID, 36, 0, HideEffect1Hue, HideEffect1RenderMode );
Effects.SendLocationEffect( new Point3D( from.X + 2, from.Y -1, from.Z ), from.Map, HideEffect1ID, 36, 0, HideEffect1Hue, HideEffect1RenderMode );
Effects.SendLocationEffect( new Point3D( from.X - 2, from.Y +1, from.Z ), from.Map, HideEffect1ID, 36, 0, HideEffect1Hue, HideEffect1RenderMode );
Effects.SendLocationEffect( new Point3D( from.X +1, from.Y - 2, from.Z ), from.Map, HideEffect1ID, 36, 0, HideEffect1Hue, HideEffect1RenderMode );
Effects.SendLocationEffect( new Point3D( from.X -1, from.Y + 2, from.Z ), from.Map, HideEffect1ID, 36, 0, HideEffect1Hue, HideEffect1RenderMode );
Effects.SendLocationEffect( new Point3D( from.X + 2, from.Y , from.Z ), from.Map, HideEffect2ID, 36, 0, HideEffect1Hue, HideEffect2RenderMode );
Effects.SendLocationEffect( new Point3D( from.X - 2, from.Y , from.Z ), from.Map, HideEffect2ID, 36, 0, HideEffect1Hue, HideEffect2RenderMode );
Effects.SendLocationEffect( new Point3D( from.X, from.Y + 2, from.Z ), from.Map, HideEffect2ID, 36, 0, HideEffect1Hue, HideEffect2RenderMode );
Effects.SendLocationEffect( new Point3D( from.X, from.Y - 2, from.Z ), from.Map, HideEffect2ID, 36, 0, HideEffect1Hue, HideEffect2RenderMode );
Effects.SendLocationEffect( new Point3D( from.X -2, from.Y - 2, from.Z ), from.Map, HideEffect2ID, 36, 0, HideEffect1Hue, HideEffect2RenderMode );
Effects.SendLocationEffect( new Point3D( from.X +2, from.Y - 2, from.Z ), from.Map, HideEffect2ID, 36, 0, HideEffect1Hue, HideEffect2RenderMode );
Effects.SendLocationEffect( new Point3D( from.X -2, from.Y + 2, from.Z ), from.Map, HideEffect2ID, 36, 0, HideEffect1Hue, HideEffect2RenderMode );
Effects.SendLocationEffect( new Point3D( from.X +2, from.Y + 2, from.Z ), from.Map, HideEffect2ID, 36, 0, HideEffect1Hue, HideEffect2RenderMode );
Effects.SendLocationEffect( new Point3D( from.X + 2, from.Y +1, from.Z ), from.Map, HideEffect2ID, 36, 0, HideEffect1Hue, HideEffect2RenderMode );
Effects.SendLocationEffect( new Point3D( from.X - 2, from.Y -1, from.Z ), from.Map, HideEffect2ID, 36, 0, HideEffect1Hue, HideEffect2RenderMode );
Effects.SendLocationEffect( new Point3D( from.X +1, from.Y + 2, from.Z ), from.Map, HideEffect2ID, 36, 0, HideEffect1Hue, HideEffect2RenderMode );
Effects.SendLocationEffect( new Point3D( from.X -1, from.Y - 2, from.Z ), from.Map, HideEffect2ID, 36, 0, HideEffect1Hue, HideEffect2RenderMode );
Effects.SendLocationEffect( new Point3D( from.X + 2, from.Y -1, from.Z ), from.Map, HideEffect2ID, 36, 0, HideEffect1Hue, HideEffect2RenderMode );
Effects.SendLocationEffect( new Point3D( from.X - 2, from.Y +1, from.Z ), from.Map, HideEffect2ID, 36, 0, HideEffect1Hue, HideEffect2RenderMode );
Effects.SendLocationEffect( new Point3D( from.X +1, from.Y - 2, from.Z ), from.Map, HideEffect2ID, 36, 0, HideEffect1Hue, HideEffect2RenderMode );
Effects.SendLocationEffect( new Point3D( from.X -1, from.Y + 2, from.Z ), from.Map, HideEffect2ID, 36, 0, HideEffect1Hue, HideEffect2RenderMode );
//Third Row
Effects.SendLocationEffect( new Point3D( from.X + 3, from.Y , from.Z ), from.Map, HideEffect1ID, 34, 0, HideEffect1Hue, HideEffect1RenderMode );
Effects.SendLocationEffect( new Point3D( from.X +3, from.Y - 3, from.Z ), from.Map, HideEffect1ID, 34, 0, HideEffect1Hue, HideEffect1RenderMode );
Effects.SendLocationEffect( new Point3D( from.X +3, from.Y + 3, from.Z ), from.Map, HideEffect1ID, 34, 0, HideEffect1Hue, HideEffect1RenderMode );
Effects.SendLocationEffect( new Point3D( from.X - 3, from.Y , from.Z ), from.Map, HideEffect1ID, 34, 0, HideEffect1Hue, HideEffect1RenderMode );
Effects.SendLocationEffect( new Point3D( from.X -3, from.Y - 3, from.Z ), from.Map, HideEffect1ID, 34, 0, HideEffect1Hue, HideEffect1RenderMode );
Effects.SendLocationEffect( new Point3D( from.X -3, from.Y + 3, from.Z ), from.Map, HideEffect1ID, 34, 0, HideEffect1Hue, HideEffect1RenderMode );
Effects.SendLocationEffect( new Point3D( from.X, from.Y + 3, from.Z ), from.Map, HideEffect1ID, 34, 0, HideEffect1Hue, HideEffect1RenderMode );
Effects.SendLocationEffect( new Point3D( from.X, from.Y - 3, from.Z ), from.Map, HideEffect1ID, 34, 0, HideEffect1Hue, HideEffect1RenderMode );
Effects.SendLocationEffect( new Point3D( from.X + 3, from.Y -2, from.Z ), from.Map, HideEffect1ID, 34, 0, HideEffect1Hue, HideEffect1RenderMode );
Effects.SendLocationEffect( new Point3D( from.X +3, from.Y +2, from.Z ), from.Map, HideEffect1ID, 34, 0, HideEffect1Hue, HideEffect1RenderMode );
Effects.SendLocationEffect( new Point3D( from.X +2, from.Y + 3, from.Z ), from.Map, HideEffect1ID, 34, 0, HideEffect1Hue, HideEffect1RenderMode );
Effects.SendLocationEffect( new Point3D( from.X +2, from.Y -3, from.Z ), from.Map, HideEffect1ID, 34, 0, HideEffect1Hue, HideEffect1RenderMode );
Effects.SendLocationEffect( new Point3D( from.X -3, from.Y - 2, from.Z ), from.Map, HideEffect1ID, 34, 0, HideEffect1Hue, HideEffect1RenderMode );
Effects.SendLocationEffect( new Point3D( from.X -3, from.Y + 2, from.Z ), from.Map, HideEffect1ID, 34, 0, HideEffect1Hue, HideEffect1RenderMode );
Effects.SendLocationEffect( new Point3D( from.X -2, from.Y + 3, from.Z ), from.Map, HideEffect1ID, 34, 0, HideEffect1Hue, HideEffect1RenderMode );
Effects.SendLocationEffect( new Point3D( from.X -2, from.Y - 3, from.Z ), from.Map, HideEffect1ID, 34, 0, HideEffect1Hue, HideEffect1RenderMode );
Effects.SendLocationEffect( new Point3D( from.X + 3, from.Y -1, from.Z ), from.Map, HideEffect1ID, 34, 0, HideEffect1Hue, HideEffect1RenderMode );
Effects.SendLocationEffect( new Point3D( from.X +3, from.Y +1, from.Z ), from.Map, HideEffect1ID, 34, 0, HideEffect1Hue, HideEffect1RenderMode );
Effects.SendLocationEffect( new Point3D( from.X +1, from.Y + 3, from.Z ), from.Map, HideEffect1ID, 34, 0, HideEffect1Hue, HideEffect1RenderMode );
Effects.SendLocationEffect( new Point3D( from.X +1, from.Y -3, from.Z ), from.Map, HideEffect1ID, 34, 0, HideEffect1Hue, HideEffect1RenderMode );
Effects.SendLocationEffect( new Point3D( from.X -3, from.Y - 1, from.Z ), from.Map, HideEffect1ID, 34, 0, HideEffect1Hue, HideEffect1RenderMode );
Effects.SendLocationEffect( new Point3D( from.X -3, from.Y + 1, from.Z ), from.Map, HideEffect1ID, 34, 0, HideEffect1Hue, HideEffect1RenderMode );
Effects.SendLocationEffect( new Point3D( from.X -1, from.Y + 3, from.Z ), from.Map, HideEffect1ID, 34, 0, HideEffect1Hue, HideEffect1RenderMode );
Effects.SendLocationEffect( new Point3D( from.X -1, from.Y - 3, from.Z ), from.Map, HideEffect1ID, 34, 0, HideEffect1Hue, HideEffect1RenderMode );
Effects.SendLocationEffect( new Point3D( from.X + 3, from.Y , from.Z ), from.Map, HideEffect2ID, 34, 0, HideEffect1Hue, HideEffect2RenderMode );
Effects.SendLocationEffect( new Point3D( from.X +3, from.Y - 3, from.Z ), from.Map, HideEffect2ID, 34, 0, HideEffect1Hue, HideEffect2RenderMode );
Effects.SendLocationEffect( new Point3D( from.X +3, from.Y + 3, from.Z ), from.Map, HideEffect2ID, 34, 0, HideEffect1Hue, HideEffect2RenderMode );
Effects.SendLocationEffect( new Point3D( from.X - 3, from.Y , from.Z ), from.Map, HideEffect2ID, 34, 0, HideEffect1Hue, HideEffect2RenderMode );
Effects.SendLocationEffect( new Point3D( from.X -3, from.Y - 3, from.Z ), from.Map, HideEffect2ID, 34, 0, HideEffect1Hue, HideEffect2RenderMode );
Effects.SendLocationEffect( new Point3D( from.X -3, from.Y + 3, from.Z ), from.Map, HideEffect2ID, 34, 0, HideEffect1Hue, HideEffect2RenderMode );
Effects.SendLocationEffect( new Point3D( from.X, from.Y + 3, from.Z ), from.Map, HideEffect2ID, 34, 0, HideEffect1Hue, HideEffect2RenderMode );
Effects.SendLocationEffect( new Point3D( from.X, from.Y - 3, from.Z ), from.Map, HideEffect2ID, 34, 0, HideEffect1Hue, HideEffect2RenderMode );
Effects.SendLocationEffect( new Point3D( from.X + 3, from.Y -2, from.Z ), from.Map, HideEffect2ID, 34, 0, HideEffect1Hue, HideEffect2RenderMode );
Effects.SendLocationEffect( new Point3D( from.X +3, from.Y +2, from.Z ), from.Map, HideEffect2ID, 34, 0, HideEffect1Hue, HideEffect2RenderMode );
Effects.SendLocationEffect( new Point3D( from.X +2, from.Y + 3, from.Z ), from.Map, HideEffect2ID, 34, 0, HideEffect1Hue, HideEffect2RenderMode );
Effects.SendLocationEffect( new Point3D( from.X +2, from.Y -3, from.Z ), from.Map, HideEffect2ID, 34, 0, HideEffect1Hue, HideEffect2RenderMode );
Effects.SendLocationEffect( new Point3D( from.X -3, from.Y - 2, from.Z ), from.Map, HideEffect2ID, 34, 0, HideEffect1Hue, HideEffect2RenderMode );
Effects.SendLocationEffect( new Point3D( from.X -3, from.Y + 2, from.Z ), from.Map, HideEffect2ID, 34, 0, HideEffect1Hue, HideEffect2RenderMode );
Effects.SendLocationEffect( new Point3D( from.X -2, from.Y + 3, from.Z ), from.Map, HideEffect2ID, 34, 0, HideEffect1Hue, HideEffect2RenderMode );
Effects.SendLocationEffect( new Point3D( from.X -2, from.Y - 3, from.Z ), from.Map, HideEffect2ID, 34, 0, HideEffect1Hue, HideEffect2RenderMode );
Effects.SendLocationEffect( new Point3D( from.X + 3, from.Y -1, from.Z ), from.Map, HideEffect2ID, 34, 0, HideEffect1Hue, HideEffect2RenderMode );
Effects.SendLocationEffect( new Point3D( from.X +3, from.Y +1, from.Z ), from.Map, HideEffect2ID, 34, 0, HideEffect1Hue, HideEffect2RenderMode );
Effects.SendLocationEffect( new Point3D( from.X +1, from.Y + 3, from.Z ), from.Map, HideEffect2ID, 34, 0, HideEffect1Hue, HideEffect2RenderMode );
Effects.SendLocationEffect( new Point3D( from.X +1, from.Y -3, from.Z ), from.Map, HideEffect2ID, 34, 0, HideEffect1Hue, HideEffect2RenderMode );
Effects.SendLocationEffect( new Point3D( from.X -3, from.Y - 1, from.Z ), from.Map, HideEffect2ID, 34, 0, HideEffect1Hue, HideEffect2RenderMode );
Effects.SendLocationEffect( new Point3D( from.X -3, from.Y + 1, from.Z ), from.Map, HideEffect2ID, 34, 0, HideEffect1Hue, HideEffect2RenderMode );
Effects.SendLocationEffect( new Point3D( from.X -1, from.Y + 3, from.Z ), from.Map, HideEffect2ID, 34, 0, HideEffect1Hue, HideEffect2RenderMode );
Effects.SendLocationEffect( new Point3D( from.X -1, from.Y - 3, from.Z ), from.Map, HideEffect2ID, 34, 0, HideEffect1Hue, HideEffect2RenderMode );
//Forth Row
Effects.SendLocationEffect( new Point3D( from.X + 4, from.Y , from.Z ), from.Map, HideEffect1ID, 32, 0, HideEffect1Hue, HideEffect1RenderMode );
Effects.SendLocationEffect( new Point3D( from.X - 4, from.Y , from.Z ), from.Map, HideEffect1ID, 32, 0, HideEffect1Hue, HideEffect1RenderMode );
Effects.SendLocationEffect( new Point3D( from.X, from.Y + 4, from.Z ), from.Map, HideEffect1ID, 32, 0, HideEffect1Hue, HideEffect1RenderMode );
Effects.SendLocationEffect( new Point3D( from.X, from.Y - 4, from.Z ), from.Map, HideEffect1ID, 32, 0, HideEffect1Hue, HideEffect1RenderMode );
Effects.SendLocationEffect( new Point3D( from.X -4, from.Y - 4, from.Z ), from.Map, HideEffect1ID, 32, 0, HideEffect1Hue, HideEffect1RenderMode );
Effects.SendLocationEffect( new Point3D( from.X +4, from.Y - 4, from.Z ), from.Map, HideEffect1ID, 32, 0, HideEffect1Hue, HideEffect1RenderMode );
Effects.SendLocationEffect( new Point3D( from.X -4, from.Y + 4, from.Z ), from.Map, HideEffect1ID, 32, 0, HideEffect1Hue, HideEffect1RenderMode );
Effects.SendLocationEffect( new Point3D( from.X +4, from.Y + 4, from.Z ), from.Map, HideEffect1ID, 32, 0, HideEffect1Hue, HideEffect1RenderMode );

Effects.SendLocationEffect( new Point3D( from.X + 4, from.Y , from.Z ), from.Map, HideEffect2ID, 32, 0, HideEffect1Hue, HideEffect2RenderMode );
Effects.SendLocationEffect( new Point3D( from.X - 4, from.Y , from.Z ), from.Map, HideEffect2ID, 32, 0, HideEffect1Hue, HideEffect2RenderMode );
Effects.SendLocationEffect( new Point3D( from.X, from.Y + 4, from.Z ), from.Map, HideEffect2ID, 32, 0, HideEffect1Hue, HideEffect2RenderMode );
Effects.SendLocationEffect( new Point3D( from.X, from.Y - 4, from.Z ), from.Map, HideEffect2ID, 32, 0, HideEffect1Hue, HideEffect2RenderMode );
Effects.SendLocationEffect( new Point3D( from.X -4, from.Y - 4, from.Z ), from.Map, HideEffect2ID, 32, 0, HideEffect1Hue, HideEffect2RenderMode );
Effects.SendLocationEffect( new Point3D( from.X +4, from.Y - 4, from.Z ), from.Map, HideEffect2ID, 32, 0, HideEffect1Hue, HideEffect2RenderMode );
Effects.SendLocationEffect( new Point3D( from.X -4, from.Y + 4, from.Z ), from.Map, HideEffect2ID, 32, 0, HideEffect1Hue, HideEffect2RenderMode );
Effects.SendLocationEffect( new Point3D( from.X +4, from.Y + 4, from.Z ), from.Map, HideEffect2ID, 32, 0, HideEffect1Hue, HideEffect2RenderMode );
//Fifth Row
Effects.SendLocationEffect( new Point3D( from.X + 5, from.Y , from.Z ), from.Map, HideEffect1ID, 30, 0, HideEffect1Hue, HideEffect1RenderMode );
Effects.SendLocationEffect( new Point3D( from.X - 5, from.Y , from.Z ), from.Map, HideEffect1ID, 30, 0, HideEffect1Hue, HideEffect1RenderMode );
Effects.SendLocationEffect( new Point3D( from.X, from.Y + 5, from.Z ), from.Map, HideEffect1ID, 30, 0, HideEffect1Hue, HideEffect1RenderMode );
Effects.SendLocationEffect( new Point3D( from.X, from.Y - 5, from.Z ), from.Map, HideEffect1ID, 30, 0, HideEffect1Hue, HideEffect1RenderMode );
Effects.SendLocationEffect( new Point3D( from.X -5, from.Y - 5, from.Z ), from.Map, HideEffect1ID, 30, 0, HideEffect1Hue, HideEffect1RenderMode );
Effects.SendLocationEffect( new Point3D( from.X +5, from.Y - 5, from.Z ), from.Map, HideEffect1ID, 30, 0, HideEffect1Hue, HideEffect1RenderMode );
Effects.SendLocationEffect( new Point3D( from.X -5, from.Y + 5, from.Z ), from.Map, HideEffect1ID, 30, 0, HideEffect1Hue, HideEffect1RenderMode );
Effects.SendLocationEffect( new Point3D( from.X +5, from.Y + 5, from.Z ), from.Map, HideEffect1ID, 30, 0, HideEffect1Hue, HideEffect1RenderMode );

Effects.SendLocationEffect( new Point3D( from.X + 5, from.Y , from.Z ), from.Map, HideEffect2ID, 30, 0, HideEffect1Hue, HideEffect2RenderMode );
Effects.SendLocationEffect( new Point3D( from.X - 5, from.Y , from.Z ), from.Map, HideEffect2ID, 30, 0, HideEffect1Hue, HideEffect2RenderMode );
Effects.SendLocationEffect( new Point3D( from.X, from.Y + 5, from.Z ), from.Map, HideEffect2ID, 30, 0, HideEffect1Hue, HideEffect2RenderMode );
Effects.SendLocationEffect( new Point3D( from.X, from.Y - 5, from.Z ), from.Map, HideEffect2ID, 30, 0, HideEffect1Hue, HideEffect2RenderMode );
Effects.SendLocationEffect( new Point3D( from.X -5, from.Y - 5, from.Z ), from.Map, HideEffect2ID, 30, 0, HideEffect1Hue, HideEffect2RenderMode );
Effects.SendLocationEffect( new Point3D( from.X +5, from.Y - 5, from.Z ), from.Map, HideEffect2ID, 30, 0, HideEffect1Hue, HideEffect2RenderMode );
Effects.SendLocationEffect( new Point3D( from.X -5, from.Y + 5, from.Z ), from.Map, HideEffect2ID, 30, 0, HideEffect1Hue, HideEffect2RenderMode );
Effects.SendLocationEffect( new Point3D( from.X +5, from.Y + 5, from.Z ), from.Map, HideEffect2ID, 30, 0, HideEffect1Hue, HideEffect2RenderMode );
           from.PlaySound( HideSound );
	       from.Hidden = true;
			} 
            else 
            { 
           from.Hidden=false;
           from.Emote( from.Name + UnHideSaying);
Effects.SendLocationEffect( new Point3D( from.X, from.Y, from.Z ), from.Map, UnHideEffect1ID, 20, 0, UnHideEffect1Hue, UnHideEffect1RenderMode ); 
Effects.SendLocationEffect( new Point3D( from.X, from.Y, from.Z ), from.Map, UnHideEffect2ID, 20, 0, UnHideEffect2Hue, UnHideEffect2RenderMode ); 
//First row
Effects.SendLocationEffect( new Point3D( from.X + 1, from.Y , from.Z ), from.Map, UnHideEffect1ID, 22, 0, UnHideEffect1Hue, UnHideEffect1RenderMode );
Effects.SendLocationEffect( new Point3D( from.X - 1, from.Y , from.Z ), from.Map, UnHideEffect1ID, 22, 0, UnHideEffect1Hue, UnHideEffect1RenderMode );
Effects.SendLocationEffect( new Point3D( from.X, from.Y + 1, from.Z ), from.Map, UnHideEffect1ID, 22, 0, UnHideEffect1Hue, UnHideEffect1RenderMode );
Effects.SendLocationEffect( new Point3D( from.X, from.Y - 1, from.Z ), from.Map, UnHideEffect1ID, 22, 0, UnHideEffect1Hue, UnHideEffect1RenderMode );
Effects.SendLocationEffect( new Point3D( from.X -1, from.Y - 1, from.Z ), from.Map, UnHideEffect1ID, 22, 0, UnHideEffect1Hue, UnHideEffect1RenderMode );
Effects.SendLocationEffect( new Point3D( from.X +1, from.Y - 1, from.Z ), from.Map, UnHideEffect1ID, 22, 0, UnHideEffect1Hue, UnHideEffect1RenderMode );
Effects.SendLocationEffect( new Point3D( from.X -1, from.Y + 1, from.Z ), from.Map, UnHideEffect1ID, 22, 0, UnHideEffect1Hue, UnHideEffect1RenderMode );
Effects.SendLocationEffect( new Point3D( from.X +1, from.Y + 1, from.Z ), from.Map, UnHideEffect1ID, 22, 0, UnHideEffect1Hue, UnHideEffect1RenderMode );
Effects.SendLocationEffect( new Point3D( from.X + 1, from.Y , from.Z ), from.Map, UnHideEffect2ID, 22, 0, UnHideEffect2Hue, UnHideEffect2RenderMode );
Effects.SendLocationEffect( new Point3D( from.X - 1, from.Y , from.Z ), from.Map, UnHideEffect2ID, 22, 0, UnHideEffect2Hue, UnHideEffect2RenderMode );
Effects.SendLocationEffect( new Point3D( from.X, from.Y + 1, from.Z ), from.Map, UnHideEffect2ID, 22, 0, UnHideEffect2Hue, UnHideEffect2RenderMode );
Effects.SendLocationEffect( new Point3D( from.X, from.Y - 1, from.Z ), from.Map, UnHideEffect2ID, 22, 0, UnHideEffect2Hue, UnHideEffect2RenderMode );
Effects.SendLocationEffect( new Point3D( from.X -1, from.Y - 1, from.Z ), from.Map, UnHideEffect2ID, 22, 0, UnHideEffect2Hue, UnHideEffect2RenderMode );
Effects.SendLocationEffect( new Point3D( from.X +1, from.Y - 1, from.Z ), from.Map, UnHideEffect2ID, 22, 0, UnHideEffect2Hue, UnHideEffect2RenderMode );
Effects.SendLocationEffect( new Point3D( from.X -1, from.Y + 1, from.Z ), from.Map, UnHideEffect2ID, 22, 0, UnHideEffect2Hue, UnHideEffect2RenderMode );
Effects.SendLocationEffect( new Point3D( from.X +1, from.Y + 1, from.Z ), from.Map, UnHideEffect2ID, 22, 0, UnHideEffect2Hue, UnHideEffect2RenderMode );
//Second Row
Effects.SendLocationEffect( new Point3D( from.X + 2, from.Y , from.Z ), from.Map, UnHideEffect1ID, 24, 0, UnHideEffect1Hue, UnHideEffect1RenderMode );
Effects.SendLocationEffect( new Point3D( from.X - 2, from.Y , from.Z ), from.Map, UnHideEffect1ID, 24, 0, UnHideEffect1Hue, UnHideEffect1RenderMode );
Effects.SendLocationEffect( new Point3D( from.X, from.Y + 2, from.Z ), from.Map, UnHideEffect1ID, 24, 0, UnHideEffect1Hue, UnHideEffect1RenderMode );
Effects.SendLocationEffect( new Point3D( from.X, from.Y - 2, from.Z ), from.Map, UnHideEffect1ID, 24, 0, UnHideEffect1Hue, UnHideEffect1RenderMode );
Effects.SendLocationEffect( new Point3D( from.X -2, from.Y - 2, from.Z ), from.Map, UnHideEffect1ID, 24, 0, UnHideEffect1Hue, UnHideEffect1RenderMode );
Effects.SendLocationEffect( new Point3D( from.X +2, from.Y - 2, from.Z ), from.Map, UnHideEffect1ID, 24, 0, UnHideEffect1Hue, UnHideEffect1RenderMode );
Effects.SendLocationEffect( new Point3D( from.X -2, from.Y + 2, from.Z ), from.Map, UnHideEffect1ID, 24, 0, UnHideEffect1Hue, UnHideEffect1RenderMode );
Effects.SendLocationEffect( new Point3D( from.X +2, from.Y + 2, from.Z ), from.Map, UnHideEffect1ID, 24, 0, UnHideEffect1Hue, UnHideEffect1RenderMode );
Effects.SendLocationEffect( new Point3D( from.X + 2, from.Y +1, from.Z ), from.Map, UnHideEffect1ID, 24, 0, UnHideEffect1Hue, UnHideEffect1RenderMode );
Effects.SendLocationEffect( new Point3D( from.X - 2, from.Y -1, from.Z ), from.Map, UnHideEffect1ID, 24, 0, UnHideEffect1Hue, UnHideEffect1RenderMode );
Effects.SendLocationEffect( new Point3D( from.X +1, from.Y + 2, from.Z ), from.Map, UnHideEffect1ID, 24, 0, UnHideEffect1Hue, UnHideEffect1RenderMode );
Effects.SendLocationEffect( new Point3D( from.X -1, from.Y - 2, from.Z ), from.Map, UnHideEffect1ID, 24, 0, UnHideEffect1Hue, UnHideEffect1RenderMode );
Effects.SendLocationEffect( new Point3D( from.X + 2, from.Y -1, from.Z ), from.Map, UnHideEffect1ID, 24, 0, UnHideEffect1Hue, UnHideEffect1RenderMode );
Effects.SendLocationEffect( new Point3D( from.X - 2, from.Y +1, from.Z ), from.Map, UnHideEffect1ID, 24, 0, UnHideEffect1Hue, UnHideEffect1RenderMode );
Effects.SendLocationEffect( new Point3D( from.X +1, from.Y - 2, from.Z ), from.Map, UnHideEffect1ID, 24, 0, UnHideEffect1Hue, UnHideEffect1RenderMode );
Effects.SendLocationEffect( new Point3D( from.X -1, from.Y + 2, from.Z ), from.Map, UnHideEffect1ID, 24, 0, UnHideEffect1Hue, UnHideEffect1RenderMode );
Effects.SendLocationEffect( new Point3D( from.X + 2, from.Y , from.Z ), from.Map, UnHideEffect2ID, 24, 0, UnHideEffect2Hue, UnHideEffect2RenderMode );
Effects.SendLocationEffect( new Point3D( from.X - 2, from.Y , from.Z ), from.Map, UnHideEffect2ID, 24, 0, UnHideEffect2Hue, UnHideEffect2RenderMode );
Effects.SendLocationEffect( new Point3D( from.X, from.Y + 2, from.Z ), from.Map, UnHideEffect2ID, 24, 0, UnHideEffect2Hue, UnHideEffect2RenderMode );
Effects.SendLocationEffect( new Point3D( from.X, from.Y - 2, from.Z ), from.Map, UnHideEffect2ID, 24, 0, UnHideEffect2Hue, UnHideEffect2RenderMode );
Effects.SendLocationEffect( new Point3D( from.X -2, from.Y - 2, from.Z ), from.Map, UnHideEffect2ID, 24, 0, UnHideEffect2Hue, UnHideEffect2RenderMode );
Effects.SendLocationEffect( new Point3D( from.X +2, from.Y - 2, from.Z ), from.Map, UnHideEffect2ID, 24, 0, UnHideEffect2Hue, UnHideEffect2RenderMode );
Effects.SendLocationEffect( new Point3D( from.X -2, from.Y + 2, from.Z ), from.Map, UnHideEffect2ID, 24, 0, UnHideEffect2Hue, UnHideEffect2RenderMode );
Effects.SendLocationEffect( new Point3D( from.X +2, from.Y + 2, from.Z ), from.Map, UnHideEffect2ID, 24, 0, UnHideEffect2Hue, UnHideEffect2RenderMode );
Effects.SendLocationEffect( new Point3D( from.X + 2, from.Y +1, from.Z ), from.Map, UnHideEffect2ID, 24, 0, UnHideEffect2Hue, UnHideEffect2RenderMode );
Effects.SendLocationEffect( new Point3D( from.X - 2, from.Y -1, from.Z ), from.Map, UnHideEffect2ID, 24, 0, UnHideEffect2Hue, UnHideEffect2RenderMode );
Effects.SendLocationEffect( new Point3D( from.X +1, from.Y + 2, from.Z ), from.Map, UnHideEffect2ID, 24, 0, UnHideEffect2Hue, UnHideEffect2RenderMode );
Effects.SendLocationEffect( new Point3D( from.X -1, from.Y - 2, from.Z ), from.Map, UnHideEffect2ID, 24, 0, UnHideEffect2Hue, UnHideEffect2RenderMode );
Effects.SendLocationEffect( new Point3D( from.X + 2, from.Y -1, from.Z ), from.Map, UnHideEffect2ID, 24, 0, UnHideEffect2Hue, UnHideEffect2RenderMode );
Effects.SendLocationEffect( new Point3D( from.X - 2, from.Y +1, from.Z ), from.Map, UnHideEffect2ID, 24, 0, UnHideEffect2Hue, UnHideEffect2RenderMode );
Effects.SendLocationEffect( new Point3D( from.X +1, from.Y - 2, from.Z ), from.Map, UnHideEffect2ID, 24, 0, UnHideEffect2Hue, UnHideEffect2RenderMode );
Effects.SendLocationEffect( new Point3D( from.X -1, from.Y + 2, from.Z ), from.Map, UnHideEffect2ID, 24, 0, UnHideEffect2Hue, UnHideEffect2RenderMode );
//Third Row
Effects.SendLocationEffect( new Point3D( from.X + 3, from.Y , from.Z ), from.Map, UnHideEffect1ID, 26, 0, UnHideEffect1Hue, UnHideEffect1RenderMode );
Effects.SendLocationEffect( new Point3D( from.X +3, from.Y + 3, from.Z ), from.Map, UnHideEffect1ID, 26, 0, UnHideEffect1Hue, UnHideEffect1RenderMode );
Effects.SendLocationEffect( new Point3D( from.X +3, from.Y - 3, from.Z ), from.Map, UnHideEffect1ID, 26, 0, UnHideEffect1Hue, UnHideEffect1RenderMode );
Effects.SendLocationEffect( new Point3D( from.X - 3, from.Y , from.Z ), from.Map, UnHideEffect1ID, 26, 0, UnHideEffect1Hue, UnHideEffect1RenderMode );
Effects.SendLocationEffect( new Point3D( from.X -3, from.Y - 3, from.Z ), from.Map, UnHideEffect1ID, 26, 0, UnHideEffect1Hue, UnHideEffect1RenderMode );
Effects.SendLocationEffect( new Point3D( from.X -3, from.Y + 3, from.Z ), from.Map, UnHideEffect1ID, 26, 0, UnHideEffect1Hue, UnHideEffect1RenderMode );
Effects.SendLocationEffect( new Point3D( from.X, from.Y + 3, from.Z ), from.Map, UnHideEffect1ID, 26, 0, UnHideEffect1Hue, UnHideEffect1RenderMode );
Effects.SendLocationEffect( new Point3D( from.X, from.Y - 3, from.Z ), from.Map, UnHideEffect1ID, 26, 0, UnHideEffect1Hue, UnHideEffect1RenderMode );
Effects.SendLocationEffect( new Point3D( from.X + 3, from.Y +2, from.Z ), from.Map, UnHideEffect1ID, 26, 0, UnHideEffect1Hue, UnHideEffect1RenderMode );
Effects.SendLocationEffect( new Point3D( from.X -3, from.Y - 2, from.Z ), from.Map, UnHideEffect1ID, 26, 0, UnHideEffect1Hue, UnHideEffect1RenderMode );
Effects.SendLocationEffect( new Point3D( from.X +2, from.Y + 3, from.Z ), from.Map, UnHideEffect1ID, 26, 0, UnHideEffect1Hue, UnHideEffect1RenderMode );
Effects.SendLocationEffect( new Point3D( from.X - 2, from.Y -3, from.Z ), from.Map, UnHideEffect1ID, 26, 0, UnHideEffect1Hue, UnHideEffect1RenderMode );
Effects.SendLocationEffect( new Point3D( from.X +3, from.Y - 2, from.Z ), from.Map, UnHideEffect1ID, 26, 0, UnHideEffect1Hue, UnHideEffect1RenderMode );
Effects.SendLocationEffect( new Point3D( from.X -3, from.Y + 2, from.Z ), from.Map, UnHideEffect1ID, 26, 0, UnHideEffect1Hue, UnHideEffect1RenderMode );
Effects.SendLocationEffect( new Point3D( from.X +2, from.Y - 3, from.Z ), from.Map, UnHideEffect1ID, 26, 0, UnHideEffect1Hue, UnHideEffect1RenderMode );
Effects.SendLocationEffect( new Point3D( from.X -2, from.Y + 3, from.Z ), from.Map, UnHideEffect1ID, 26, 0, UnHideEffect1Hue, UnHideEffect1RenderMode );
Effects.SendLocationEffect( new Point3D( from.X + 3, from.Y +1, from.Z ), from.Map, UnHideEffect1ID, 26, 0, UnHideEffect1Hue, UnHideEffect1RenderMode );
Effects.SendLocationEffect( new Point3D( from.X -3, from.Y - 1, from.Z ), from.Map, UnHideEffect1ID, 26, 0, UnHideEffect1Hue, UnHideEffect1RenderMode );
Effects.SendLocationEffect( new Point3D( from.X +1, from.Y + 3, from.Z ), from.Map, UnHideEffect1ID, 26, 0, UnHideEffect1Hue, UnHideEffect1RenderMode );
Effects.SendLocationEffect( new Point3D( from.X - 1, from.Y -3, from.Z ), from.Map, UnHideEffect1ID, 26, 0, UnHideEffect1Hue, UnHideEffect1RenderMode );
Effects.SendLocationEffect( new Point3D( from.X +3, from.Y - 1, from.Z ), from.Map, UnHideEffect1ID, 26, 0, UnHideEffect1Hue, UnHideEffect1RenderMode );
Effects.SendLocationEffect( new Point3D( from.X -3, from.Y + 1, from.Z ), from.Map, UnHideEffect1ID, 26, 0, UnHideEffect1Hue, UnHideEffect1RenderMode );
Effects.SendLocationEffect( new Point3D( from.X +1, from.Y - 3, from.Z ), from.Map, UnHideEffect1ID, 26, 0, UnHideEffect1Hue, UnHideEffect1RenderMode );
Effects.SendLocationEffect( new Point3D( from.X -1, from.Y + 3, from.Z ), from.Map, UnHideEffect1ID, 26, 0, UnHideEffect1Hue, UnHideEffect1RenderMode );
Effects.SendLocationEffect( new Point3D( from.X + 3, from.Y , from.Z ), from.Map, UnHideEffect2ID, 26, 0, UnHideEffect2Hue, UnHideEffect2RenderMode );
Effects.SendLocationEffect( new Point3D( from.X +3, from.Y + 3, from.Z ), from.Map, UnHideEffect2ID, 26, 0, UnHideEffect2Hue, UnHideEffect2RenderMode );
Effects.SendLocationEffect( new Point3D( from.X +3, from.Y - 3, from.Z ), from.Map, UnHideEffect2ID, 26, 0, UnHideEffect2Hue, UnHideEffect2RenderMode );
Effects.SendLocationEffect( new Point3D( from.X - 3, from.Y , from.Z ), from.Map, UnHideEffect2ID, 26, 0, UnHideEffect2Hue, UnHideEffect2RenderMode );
Effects.SendLocationEffect( new Point3D( from.X -3, from.Y - 3, from.Z ), from.Map, UnHideEffect2ID, 26, 0, UnHideEffect2Hue, UnHideEffect2RenderMode );
Effects.SendLocationEffect( new Point3D( from.X -3, from.Y + 3, from.Z ), from.Map, UnHideEffect2ID, 26, 0, UnHideEffect2Hue, UnHideEffect2RenderMode );
Effects.SendLocationEffect( new Point3D( from.X, from.Y + 3, from.Z ), from.Map, UnHideEffect2ID, 26, 0, UnHideEffect2Hue, UnHideEffect2RenderMode );
Effects.SendLocationEffect( new Point3D( from.X, from.Y - 3, from.Z ), from.Map, UnHideEffect2ID, 26, 0, UnHideEffect2Hue, UnHideEffect2RenderMode );
Effects.SendLocationEffect( new Point3D( from.X + 3, from.Y +2, from.Z ), from.Map, UnHideEffect2ID, 26, 0, UnHideEffect2Hue, UnHideEffect2RenderMode );
Effects.SendLocationEffect( new Point3D( from.X -3, from.Y - 2, from.Z ), from.Map, UnHideEffect2ID, 26, 0, UnHideEffect2Hue, UnHideEffect2RenderMode );
Effects.SendLocationEffect( new Point3D( from.X +2, from.Y + 3, from.Z ), from.Map, UnHideEffect2ID, 26, 0, UnHideEffect2Hue, UnHideEffect2RenderMode );
Effects.SendLocationEffect( new Point3D( from.X - 2, from.Y -3, from.Z ), from.Map, UnHideEffect2ID, 26, 0, UnHideEffect2Hue, UnHideEffect2RenderMode );
Effects.SendLocationEffect( new Point3D( from.X +3, from.Y - 2, from.Z ), from.Map, UnHideEffect2ID, 26, 0, UnHideEffect2Hue, UnHideEffect2RenderMode );
Effects.SendLocationEffect( new Point3D( from.X -3, from.Y + 2, from.Z ), from.Map, UnHideEffect2ID, 26, 0, UnHideEffect2Hue, UnHideEffect2RenderMode );
Effects.SendLocationEffect( new Point3D( from.X +2, from.Y - 3, from.Z ), from.Map, UnHideEffect2ID, 26, 0, UnHideEffect2Hue, UnHideEffect2RenderMode );
Effects.SendLocationEffect( new Point3D( from.X -2, from.Y + 3, from.Z ), from.Map, UnHideEffect2ID, 26, 0, UnHideEffect2Hue, UnHideEffect2RenderMode );
Effects.SendLocationEffect( new Point3D( from.X + 3, from.Y +1, from.Z ), from.Map, UnHideEffect2ID, 26, 0, UnHideEffect2Hue, UnHideEffect2RenderMode );
Effects.SendLocationEffect( new Point3D( from.X -3, from.Y - 1, from.Z ), from.Map, UnHideEffect2ID, 26, 0, UnHideEffect2Hue, UnHideEffect2RenderMode );
Effects.SendLocationEffect( new Point3D( from.X +1, from.Y + 3, from.Z ), from.Map, UnHideEffect2ID, 26, 0, UnHideEffect2Hue, UnHideEffect2RenderMode );
Effects.SendLocationEffect( new Point3D( from.X - 1, from.Y -3, from.Z ), from.Map, UnHideEffect2ID, 26, 0, UnHideEffect2Hue, UnHideEffect2RenderMode );
Effects.SendLocationEffect( new Point3D( from.X +3, from.Y - 1, from.Z ), from.Map, UnHideEffect2ID, 26, 0, UnHideEffect2Hue, UnHideEffect2RenderMode );
Effects.SendLocationEffect( new Point3D( from.X -3, from.Y + 1, from.Z ), from.Map, UnHideEffect2ID, 26, 0, UnHideEffect2Hue, UnHideEffect2RenderMode );
Effects.SendLocationEffect( new Point3D( from.X +1, from.Y - 3, from.Z ), from.Map, UnHideEffect2ID, 26, 0, UnHideEffect2Hue, UnHideEffect2RenderMode );
Effects.SendLocationEffect( new Point3D( from.X -1, from.Y + 3, from.Z ), from.Map, UnHideEffect2ID, 26, 0, UnHideEffect2Hue, UnHideEffect2RenderMode );
//Forth Row
Effects.SendLocationEffect( new Point3D( from.X + 4, from.Y , from.Z ), from.Map, UnHideEffect1ID, 28, 0, UnHideEffect1Hue, UnHideEffect1RenderMode );
Effects.SendLocationEffect( new Point3D( from.X - 4, from.Y , from.Z ), from.Map, UnHideEffect1ID, 28, 0, UnHideEffect1Hue, UnHideEffect1RenderMode );
Effects.SendLocationEffect( new Point3D( from.X, from.Y + 4, from.Z ), from.Map, UnHideEffect1ID, 28, 0, UnHideEffect1Hue, UnHideEffect1RenderMode );
Effects.SendLocationEffect( new Point3D( from.X, from.Y - 4, from.Z ), from.Map, UnHideEffect1ID, 28, 0, UnHideEffect1Hue, UnHideEffect1RenderMode );
Effects.SendLocationEffect( new Point3D( from.X -4, from.Y - 4, from.Z ), from.Map, UnHideEffect1ID, 28, 0, UnHideEffect1Hue, UnHideEffect1RenderMode );
Effects.SendLocationEffect( new Point3D( from.X +4, from.Y - 4, from.Z ), from.Map, UnHideEffect1ID, 28, 0, UnHideEffect1Hue, UnHideEffect1RenderMode );
Effects.SendLocationEffect( new Point3D( from.X -4, from.Y + 4, from.Z ), from.Map, UnHideEffect1ID, 28, 0, UnHideEffect1Hue, UnHideEffect1RenderMode );
Effects.SendLocationEffect( new Point3D( from.X +4, from.Y + 4, from.Z ), from.Map, UnHideEffect1ID, 28, 0, UnHideEffect1Hue, UnHideEffect1RenderMode );

Effects.SendLocationEffect( new Point3D( from.X + 4, from.Y , from.Z ), from.Map, UnHideEffect2ID, 28, 0, UnHideEffect2Hue, UnHideEffect2RenderMode );
Effects.SendLocationEffect( new Point3D( from.X - 4, from.Y , from.Z ), from.Map, UnHideEffect2ID, 28, 0, UnHideEffect2Hue, UnHideEffect2RenderMode );
Effects.SendLocationEffect( new Point3D( from.X, from.Y + 4, from.Z ), from.Map, UnHideEffect2ID, 28, 0, UnHideEffect2Hue, UnHideEffect2RenderMode );
Effects.SendLocationEffect( new Point3D( from.X, from.Y - 4, from.Z ), from.Map, UnHideEffect2ID, 28, 0, UnHideEffect2Hue, UnHideEffect2RenderMode );
Effects.SendLocationEffect( new Point3D( from.X -4, from.Y - 4, from.Z ), from.Map, UnHideEffect2ID, 28, 0, UnHideEffect2Hue, UnHideEffect2RenderMode );
Effects.SendLocationEffect( new Point3D( from.X +4, from.Y - 4, from.Z ), from.Map, UnHideEffect2ID, 28, 0, UnHideEffect2Hue, UnHideEffect2RenderMode );
Effects.SendLocationEffect( new Point3D( from.X -4, from.Y + 4, from.Z ), from.Map, UnHideEffect2ID, 28, 0, UnHideEffect2Hue, UnHideEffect2RenderMode );
Effects.SendLocationEffect( new Point3D( from.X +4, from.Y + 4, from.Z ), from.Map, UnHideEffect2ID, 28, 0, UnHideEffect2Hue, UnHideEffect2RenderMode );
//Fifth Row
Effects.SendLocationEffect( new Point3D( from.X + 5, from.Y , from.Z ), from.Map, UnHideEffect1ID, 30, 0, UnHideEffect1Hue, UnHideEffect1RenderMode );
Effects.SendLocationEffect( new Point3D( from.X - 5, from.Y , from.Z ), from.Map, UnHideEffect1ID, 30, 0, UnHideEffect1Hue, UnHideEffect1RenderMode );
Effects.SendLocationEffect( new Point3D( from.X, from.Y + 5, from.Z ), from.Map, UnHideEffect1ID, 30, 0, UnHideEffect1Hue, UnHideEffect1RenderMode );
Effects.SendLocationEffect( new Point3D( from.X, from.Y - 5, from.Z ), from.Map, UnHideEffect1ID, 30, 0, UnHideEffect1Hue, UnHideEffect1RenderMode );
Effects.SendLocationEffect( new Point3D( from.X -5, from.Y - 5, from.Z ), from.Map, UnHideEffect1ID, 30, 0, UnHideEffect1Hue, UnHideEffect1RenderMode );
Effects.SendLocationEffect( new Point3D( from.X +5, from.Y - 5, from.Z ), from.Map, UnHideEffect1ID, 30, 0, UnHideEffect1Hue, UnHideEffect1RenderMode );
Effects.SendLocationEffect( new Point3D( from.X -5, from.Y + 5, from.Z ), from.Map, UnHideEffect1ID, 30, 0, UnHideEffect1Hue, UnHideEffect1RenderMode );
Effects.SendLocationEffect( new Point3D( from.X +5, from.Y + 5, from.Z ), from.Map, UnHideEffect1ID, 30, 0, UnHideEffect1Hue, UnHideEffect1RenderMode );

Effects.SendLocationEffect( new Point3D( from.X + 5, from.Y , from.Z ), from.Map, UnHideEffect2ID, 30, 0, UnHideEffect2Hue, UnHideEffect2RenderMode );
Effects.SendLocationEffect( new Point3D( from.X - 5, from.Y , from.Z ), from.Map, UnHideEffect2ID, 30, 0, UnHideEffect2Hue, UnHideEffect2RenderMode );
Effects.SendLocationEffect( new Point3D( from.X, from.Y + 5, from.Z ), from.Map, UnHideEffect2ID, 30, 0, UnHideEffect2Hue, UnHideEffect2RenderMode );
Effects.SendLocationEffect( new Point3D( from.X, from.Y - 5, from.Z ), from.Map, UnHideEffect2ID, 30, 0, UnHideEffect2Hue, UnHideEffect2RenderMode );
Effects.SendLocationEffect( new Point3D( from.X -5, from.Y - 5, from.Z ), from.Map, UnHideEffect2ID, 30, 0, UnHideEffect2Hue, UnHideEffect2RenderMode );
Effects.SendLocationEffect( new Point3D( from.X +5, from.Y - 5, from.Z ), from.Map, UnHideEffect2ID, 30, 0, UnHideEffect2Hue, UnHideEffect2RenderMode );
Effects.SendLocationEffect( new Point3D( from.X -5, from.Y + 5, from.Z ), from.Map, UnHideEffect2ID, 30, 0, UnHideEffect2Hue, UnHideEffect2RenderMode );
Effects.SendLocationEffect( new Point3D( from.X +5, from.Y + 5, from.Z ), from.Map, UnHideEffect2ID, 30, 0, UnHideEffect2Hue, UnHideEffect2RenderMode );
           from.PlaySound( UnHideSound );
            }     
        } 
	}


       

       
      public override void Serialize( GenericWriter writer ) 
      { 
         base.Serialize( writer ); 
		 
  		writer.Write( (int) 1 ); // version 
			writer.Write( (int) m_UnHideEffect1ID );
			writer.Write( (int) m_UnHideEffect1Hue );
			writer.Write( (int) m_UnHideEffect1RenderMode );
			writer.Write( (int) m_HideEffect1ID );
			writer.Write( (int) m_HideEffect1Hue );
			writer.Write( (int) m_HideEffect1RenderMode );
			writer.Write( (int) m_UnHideEffect2ID );
			writer.Write( (int) m_UnHideEffect2Hue );
			writer.Write( (int) m_UnHideEffect2RenderMode );
			writer.Write( (int) m_HideEffect2ID );
			writer.Write( (int) m_HideEffect2Hue );
			writer.Write( (int) m_HideEffect2RenderMode );
			writer.Write( (int) m_UnHideSound );
			writer.Write( (int) m_HideSound );
			writer.Write( (string) m_HideSaying );
			writer.Write( (string) m_UnHideSaying );
			writer.Write( (bool) m_AreaEffect );
      } 
       
      public override void Deserialize( GenericReader reader ) 
      { 
         base.Deserialize( reader ); 
         int version = reader.ReadInt(); 
			m_UnHideEffect1ID = reader.ReadInt(); 
			m_UnHideEffect1Hue = reader.ReadInt(); 
			m_UnHideEffect1RenderMode = reader.ReadInt(); 
			m_HideEffect1ID = reader.ReadInt(); 
			m_HideEffect1Hue = reader.ReadInt(); 
			m_HideEffect1RenderMode = reader.ReadInt(); 
			m_UnHideEffect2ID = reader.ReadInt(); 
			m_UnHideEffect2Hue = reader.ReadInt(); 
			m_UnHideEffect2RenderMode = reader.ReadInt(); 
			m_HideEffect2ID = reader.ReadInt(); 
			m_HideEffect2Hue = reader.ReadInt(); 
			m_HideEffect2RenderMode = reader.ReadInt(); 
			m_HideSound = reader.ReadInt(); 
			m_UnHideSound = reader.ReadInt(); 
			m_HideSaying = reader.ReadString(); 
			m_UnHideSaying = reader.ReadString(); 
			m_AreaEffect = reader.ReadBool();
      } 
       
   } 
}