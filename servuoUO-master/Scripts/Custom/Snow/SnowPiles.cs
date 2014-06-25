using System;
using Server;

namespace Server.Items
{
	[FlipableAttribute( 0x8EA, 0x8E9 )]
	public class SnowPile1 : Item
	{		
		[Constructable]
		public SnowPile1() : base( 0x8EA )
		{
			Name = "Pile of Snow";
			Hue = 1151;
			Weight = 2.0;
			LootType = LootType.Blessed;
		}

		public SnowPile1( Serial serial ) : base( serial )
		{
		}
		public override void GetProperties( ObjectPropertyList list )
		{
			base.GetProperties( list );

			list.Add( 1060662, "Happy Holiday's \t2009" );
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 0 );
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();
		}
	}
	
	[FlipableAttribute( 0x8E4, 0x8E5 )]
	public class SnowPile2 : Item
	{		
		[Constructable]
		public SnowPile2() : base( 0x8E4 )
		{
			Name = "Pile of Snow";
			Hue = 1151;
			Weight = 2.0;
			LootType = LootType.Blessed;
		}

		public SnowPile2( Serial serial ) : base( serial )
		{
		}
		public override void GetProperties( ObjectPropertyList list )
		{
			base.GetProperties( list );

			list.Add( 1060662, "Happy Holiday's \t2009" );
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 0 );
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();
		}
	}
	
	[FlipableAttribute( 0x8E0, 0x8E1 )]
	public class SnowPile3 : Item
	{		
		[Constructable]
		public SnowPile3() : base( 0x8E0 )
		{
			Name = "Pile of Snow";
			Hue = 1151;
			Weight = 2.0;
			LootType = LootType.Blessed;
		}

		public SnowPile3( Serial serial ) : base( serial )
		{
		}
		public override void GetProperties( ObjectPropertyList list )
		{
			base.GetProperties( list );

			list.Add( 1060662, "Happy Holiday's \t2009" );
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 0 );
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();
		}
	}
	
	
	public class SnowPile4 : Item
	{		
		[Constructable]
		public SnowPile4() : base( 0x8E7 )
		{
			Name = "Pile of Snow";
			Hue = 1151;
			Weight = 2.0;
			LootType = LootType.Blessed;
		}

		public SnowPile4( Serial serial ) : base( serial )
		{
		}
		public override void GetProperties( ObjectPropertyList list )
		{
			base.GetProperties( list );

			list.Add( 1060662, "Happy Holiday's \t2009" );
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 0 );
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();
		}
	}
	
	
	public class SnowPile5 : Item
	{		
		[Constructable]
		public SnowPile5() : base( 0x8E3 )
		{
			Name = "Pile of Snow";
			Hue = 1151;
			Weight = 2.0;
			LootType = LootType.Blessed;
		}

		public SnowPile5( Serial serial ) : base( serial )
		{
		}
		public override void GetProperties( ObjectPropertyList list )
		{
			base.GetProperties( list );

			list.Add( 1060662, "Happy Holiday's \t2009" );
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 0 );
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();
		}
	}
}

