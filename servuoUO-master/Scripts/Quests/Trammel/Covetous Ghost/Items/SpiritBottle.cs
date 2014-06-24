using System;

namespace Server.Items
{
    public class SpiritBottle : Item
    {
        [Constructable]
        public SpiritBottle()
            : base(0xEFB)
        {
            this.LootType = LootType.Blessed;
            this.Weight = 1.0;
        }

        public SpiritBottle(Serial serial)
            : base(serial)
        {
        }

        public override int LabelNumber
        {
            get
            {
                return 1075283;
            }
        }// Spirit bottle
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