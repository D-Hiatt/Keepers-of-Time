using System;

namespace Server.Items
{
    public class DecorativeTopiary : Item
    {
        [Constructable]
        public DecorativeTopiary()
            : base(0x2378)
        {
            this.Weight = 1.0;
            this.LootType = LootType.Blessed;
        }

        public DecorativeTopiary(Serial serial)
            : base(serial)
        {
        }

        public override void OnSingleClick(Mobile from)
        {
            base.OnSingleClick(from);

            this.LabelTo(from, 1070880); // Winter 2004
        }

        public override void GetProperties(ObjectPropertyList list)
        {
            base.GetProperties(list);

            list.Add(1070880); // Winter 2004
        }

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