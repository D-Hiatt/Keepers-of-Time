using System;
using Server.Items;

namespace Server.Engines.Quests
{ 
    public class InstrumentOfWarQuest : BaseQuest
    { 
        public InstrumentOfWarQuest()
            : base()
        { 
            this.AddObjective(new ObtainObjective(typeof(Broadsword), "broadswords", 12, 0xF5E));
			
            this.AddReward(new BaseReward(typeof(SmithsCraftsmanSatchel), 1074282));
        }

        /* Instrument of War */
        public override object Title
        {
            get
            {
                return 1074055;
            }
        }
        /* Pathetic, this human craftsmanship! Take their broadswords - overgrown butter knives, in reality. 
        No, I cannot do them justice - you must see for yourself. Bring me broadswords and I will demonstrate 
        their feebleness. */
        public override object Description
        {
            get
            {
                return 1074149;
            }
        }
        /* Fine then, I'm shall find another to run my errands then. */
        public override object Refuse
        {
            get
            {
                return 1074063;
            }
        }
        /* Hurry up! I don't have all day to wait for you to bring what I desire! */
        public override object Uncomplete
        {
            get
            {
                return 1074064;
            }
        }
        /* These human made goods are laughable! It offends so -- I must show you what elven skill is capable of! */
        public override object Complete
        {
            get
            {
                return 1074065;
            }
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

    public class TheShieldQuest : BaseQuest
    { 
        public TheShieldQuest()
            : base()
        { 
            this.AddObjective(new ObtainObjective(typeof(HeaterShield), "heater shields", 10, 0x1B76));
			
            this.AddReward(new BaseReward(typeof(SmithsCraftsmanSatchel), 1074282));
        }

        /* The Shield */
        public override object Title
        {
            get
            {
                return 1074054;
            }
        }
        /* I doubt very much a human shield would stop a good stout elven arrow. You doubt me? I will show you - 
        get me some of these heater shields and I will piece them with sharp elven arrows! */
        public override object Description
        {
            get
            {
                return 1074148;
            }
        }
        /* Fine then, I'm shall find another to run my errands then. */
        public override object Refuse
        {
            get
            {
                return 1074063;
            }
        }
        /* Hurry up! I don't have all day to wait for you to bring what I desire! */
        public override object Uncomplete
        {
            get
            {
                return 1074064;
            }
        }
        /* These human made goods are laughable! It offends so -- I must show you what elven skill is capable of! */
        public override object Complete
        {
            get
            {
                return 1074065;
            }
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

    public class MusicToMyEarsQuest : BaseQuest
    { 
        public MusicToMyEarsQuest()
            : base()
        { 
            this.AddObjective(new ObtainObjective(typeof(LapHarp), "lap harp", 10, 0xEB2));
			
            this.AddReward(new BaseReward(typeof(CarpentersCraftsmanSatchel), 1074282));
        }

        /* Music to my Ears */
        public override object Title
        {
            get
            {
                return 1074023;
            }
        }
        /* You think you know something of music? Laughable! Take your lap harp. Crude, indelicate instruments that 
        make a noise not unlike the wailing of a choleric child or a dying cat. I will show you - bring lap harps, 
        and I will demonstrate. */
        public override object Description
        {
            get
            {
                return 1074117;
            }
        }
        /* Fine then, I'm shall find another to run my errands then. */
        public override object Refuse
        {
            get
            {
                return 1074063;
            }
        }
        /* Hurry up! I don't have all day to wait for you to bring what I desire! */
        public override object Uncomplete
        {
            get
            {
                return 1074064;
            }
        }
        /* These human made goods are laughable! It offends so -- I must show you what elven skill is capable of! */
        public override object Complete
        {
            get
            {
                return 1074065;
            }
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

    public class TheGlassEyeQuest : BaseQuest
    { 
        public TheGlassEyeQuest()
            : base()
        { 
            this.AddObjective(new ObtainObjective(typeof(Spyglass), "spyglasses", 10, 0x14F5));
			
            this.AddReward(new BaseReward(typeof(TinkersCraftsmanSatchel), 1074282));
        }

        /* The Glass Eye */
        public override object Title
        {
            get
            {
                return 1074050;
            }
        }
        /* Humans are so pathetically weak, they must be augmented by glass and metal! Imagine such a thing! 
        I must see one of these spyglasses for myself, to understand the pathetic limits of human sight! */
        public override object Description
        {
            get
            {
                return 1074144;
            }
        }
        /* Fine then, I'm shall find another to run my errands then. */
        public override object Refuse
        {
            get
            {
                return 1074063;
            }
        }
        /* Hurry up! I don't have all day to wait for you to bring what I desire! */
        public override object Uncomplete
        {
            get
            {
                return 1074064;
            }
        }
        /* These human made goods are laughable! It offends so -- I must show you what elven skill is capable of! */
        public override object Complete
        {
            get
            {
                return 1074065;
            }
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

    public class LazyHumansQuest : BaseQuest
    { 
        public LazyHumansQuest()
            : base()
        { 
            this.AddObjective(new ObtainObjective(typeof(FootStool), "foot stools", 10, 0xB5E));
			
            this.AddReward(new BaseReward(typeof(CarpentersCraftsmanSatchel), 1074282));
        }

        /* Lazy Humans */
        public override object Title
        {
            get
            {
                return 1074024;
            }
        }
        /* Human fancy knows no bounds!  It's pathetic that they are so weak that they must create a special stool 
        upon which to rest their feet when they recline!  Humans don't have any clue how to live.  Bring me some of 
        these foot stools to examine and I may teach you something worthwhile. */
        public override object Description
        {
            get
            {
                return 1074118;
            }
        }
        /* Fine then, I'm shall find another to run my errands then. */
        public override object Refuse
        {
            get
            {
                return 1074063;
            }
        }
        /* Hurry up! I don't have all day to wait for you to bring what I desire! */
        public override object Uncomplete
        {
            get
            {
                return 1074064;
            }
        }
        /* These human made goods are laughable! It offends so -- I must show you what elven skill is capable of! */
        public override object Complete
        {
            get
            {
                return 1074065;
            }
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

    public class InventiveToolsQuest : BaseQuest
    { 
        public InventiveToolsQuest()
            : base()
        { 
            this.AddObjective(new ObtainObjective(typeof(TinkerTools), "tinker's tools", 10, 0x1EB8));
			
            this.AddReward(new BaseReward(typeof(TinkersCraftsmanSatchel), 1074282));
        }

        /* Inventive Tools */
        public override object Title
        {
            get
            {
                return 1074048;
            }
        }
        /* Bring me some of these tinker's tools! I am certain, in the hands of an elf, they will fashion objects of 
        ingenuity and delight that will shame all human invention! Hurry, do this quickly and I might deign to show you 
        my skill.  */
        public override object Description
        {
            get
            {
                return 1074142;
            }
        }
        /* Fine then, I'm shall find another to run my errands then. */
        public override object Refuse
        {
            get
            {
                return 1074063;
            }
        }
        /* Hurry up! I don't have all day to wait for you to bring what I desire! */
        public override object Uncomplete
        {
            get
            {
                return 1074064;
            }
        }
        /* These human made goods are laughable! It offends so -- I must show you what elven skill is capable of! */
        public override object Complete
        {
            get
            {
                return 1074065;
            }
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

    public class Danoel : MondainQuester
    { 
        [Constructable]
        public Danoel()
            : base("Danoel", "the metal weaver")
        { 
        }

        public Danoel(Serial serial)
            : base(serial)
        {
        }

        public override Type[] Quests
        { 
            get
            {
                return new Type[] 
                {
                    typeof(ReptilianDentistQuest),
                    typeof(TickTockQuest),
                    typeof(NothingFancyQuest),
                    typeof(InstrumentOfWarQuest),
                    typeof(TheShieldQuest),
                    typeof(TheGlassEyeQuest),
                    typeof(MusicToMyEarsQuest),
                    typeof(LazyHumansQuest),
                    typeof(InventiveToolsQuest),
                    typeof(LeatherAndLaceQuest)
                };
            }
        }
        public override void InitBody()
        {
            this.InitStats(100, 100, 25);
			
            this.Female = true;
            this.CantWalk = true;
            this.Race = Race.Elf;
			
            this.Hue = 0x8579;
            this.HairItemID = 0x2FC0;
            this.HairHue = 0x206;
        }

        public override void InitOutfit()
        {
            this.AddItem(new ElvenBoots(0x901));
            this.AddItem(new ElvenPants(0x386));
            this.AddItem(new ElvenShirt(0x71D));
            this.AddItem(new SmithHammer());
            this.AddItem(new RoyalCirclet());
            this.AddItem(new FullApron(0x1BB));
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