using System;

namespace Server.Items
{
    public class ElvenWashBasinEastAddon : BaseAddon
    {
        [Constructable]
        public ElvenWashBasinEastAddon()
        {
            this.AddComponent(new AddonComponent(0x30DF), 0, 0, 0);
            this.AddComponent(new AddonComponent(0x30E0), 0, 1, 0);
        }

        public ElvenWashBasinEastAddon(Serial serial)
            : base(serial)
        {
        }

        public override BaseAddonDeed Deed
        {
            get
            {
                return new ElvenWashBasinEastDeed();
            }
        }
        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.WriteEncodedInt(0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadEncodedInt();
        }
    }

    public class ElvenWashBasinEastDeed : BaseAddonDeed
    {
        [Constructable]
        public ElvenWashBasinEastDeed()
        {
        }

        public ElvenWashBasinEastDeed(Serial serial)
            : base(serial)
        {
        }

        public override BaseAddon Addon
        {
            get
            {
                return new ElvenWashBasinEastAddon();
            }
        }
        public override int LabelNumber
        {
            get
            {
                return 1073387;
            }
        }// elven wash basin (east)
        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.WriteEncodedInt(0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadEncodedInt();
        }
    }
}