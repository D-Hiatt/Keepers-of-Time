using System;

namespace Server.Items
{
    public class GOOBERRing : GoldRing
    {
        [Constructable]
        public GOOBERRing()
        {
            this.Hue = 1174;
			this.Name = "GOOBER Ring";
			switch ( Utility.Random( 3 ))
            {
				case 0:
				this.Attributes.Luck = 1;
				break;
				case 1:
				this.Attributes.Luck = 10;
				break;
				case 2:
				this.Attributes.Luck = 100;
				break;
			}
			switch ( Utility.Random( 3 ))
            {
				case 0:
				this.Attributes.BonusDex = 15;
				break;
				case 1:
				this.Attributes.WeaponDamage = 25;
				break;
				case 2:
				this.Attributes.LowerManaCost = 8;
				break;
			}
			switch ( Utility.Random( 3 ))
            {
				case 0: 
				this.Attributes.DefendChance = 15;
				break;
				case 1:
				this.Attributes.AttackChance = 15;
				break;
				case 2:
				this.Attributes.SpellDamage = 12;
				break;
			}
			switch ( Utility.Random( 2 ))
            {
				case 0: 
				this.Attributes.CastSpeed = 1;
				break;
				case 1:
				this.Attributes.CastSpeed = 2;
				break;
			}			
        }

        public GOOBERRing(Serial serial)
            : base(serial)
        {
        }
        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write((int)0);
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();

            if (this.Hue == 1174)
                this.Hue = 1174;
        }
    }
}