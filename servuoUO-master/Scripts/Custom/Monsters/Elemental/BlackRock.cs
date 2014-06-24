using System;

namespace Server.Items
{
    public class BlackRockSmall : Item
    {
        [Constructable]
        public BlackRockSmall(): this(1)
        {
        }

        [Constructable]
        public BlackRockSmall(int amount): base(0x136C)
        {
            Name = "a piece of blackrock"; //not sure if this is correct name
            Hue = 1;
            Stackable = false; // not sure if this is stackable
            Amount = amount;
            Weight = Utility.Random(8, 22); //weight is between 8 and 22 stones
        }

        public BlackRockSmall(Serial serial): base(serial)
        {
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

    public class BlackRockLarge : Item
    {
        [Constructable]
        public BlackRockLarge(): this(1)
        {
        }

        [Constructable]
        public BlackRockLarge(int amount): base(0x136B)
        {
            Name = "a piece of blackrock"; //not sure if this is correct name
            Hue = 1;
            Stackable = false; // not sure if this is stackable
            Amount = amount;
            Weight = Utility.Random(8, 22); //weight is between 8 and 22 stones
        }

        public BlackRockLarge(Serial serial): base(serial)
        {
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