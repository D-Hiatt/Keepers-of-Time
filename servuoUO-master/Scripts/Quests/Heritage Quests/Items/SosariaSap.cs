using System;

namespace Server.Items
{
    public class SosariaSap : Item
    { 
        [Constructable]
        public SosariaSap()
            : base(0x1848)
        {
            this.Weight = 1.0;
            this.LootType = LootType.Blessed;
        }

        public SosariaSap(Serial serial)
            : base(serial)
        {
        }

        public override int LabelNumber
        {
            get
            {
                return 1074178;
            }
        }// Sap of Sosaria
        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
			
            writer.Write((int)0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
			
            int version = reader.ReadInt();
        }
    }
}