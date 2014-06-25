using System;
using Server;
using Server.Items;
using Server.Mobiles;

namespace Xanthos.Evo
{
	public class PhoenixDust : BaseEvoDust
	{
		[Constructable]
		public PhoenixDust() : this( 1 )
		{
		}

		[Constructable]
		public PhoenixDust( int amount ) : base( amount )
		{
			Amount = amount;
			Name = "Phoenix Dust";
			Hue = 1984;
		}

		public PhoenixDust( Serial serial ) : base ( serial )
		{
		}

		public override BaseEvoDust NewDust()
		{
			return new PhoenixDust();
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