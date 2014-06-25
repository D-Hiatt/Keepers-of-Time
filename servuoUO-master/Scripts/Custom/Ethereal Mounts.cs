using System; 
using Server.Mobiles;

namespace Server.Items
{
    public class EtherealPolarBear : EtherealMount
    {
        [Constructable]
        public EtherealPolarBear()
            : base(11676, 0x3E92)
        {
            Name = "Ehereal Polar Bear Statuette";
            ItemID = 8417;
            MountedID = 16069;
            RegularID = 8417;
            LootType = LootType.Blessed;
        } 

    private string _title;
    
    public string Title
    {
        get{ return _title; }
        set{ _title = value; }
    }
    
    	public override void OnAdded(object parent)
	{
	base.OnAdded(parent);
 
	if(parent is Mobile)
	{
	Mobile from = (Mobile)parent;
 
	Title = from.Title;
	from.Title = "The Wise";
 	 from.RawInt += 10;
	}
		}
 
	public override void OnRemoved(object parent)
	{
	base.OnRemoved(parent);
 
	if(parent is Mobile)
	{
	Mobile from = (Mobile)parent;
 
	from.Title = Title;
	Title = null;
	 from.RawInt -= 10;
	}
		}

        public EtherealPolarBear(Serial serial)
            : base(serial)
        {
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write((int)0);
            writer.Write(Title);
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();
        
        switch(version)
        {
            case 0:
                Title = reader.ReadString();
                break;
	}
            if (Name != "Ethereal Polar Bear Statuette")
                Name = "Ethereal Polar Bear Statuette";
        }
    }

    //__________________________________________________________________________________________________________________________

    public class EtherealSkeletalSteed : EtherealMount
    {

        [Constructable]
        public EtherealSkeletalSteed()
            : base(11669, 0x3E90)
        {
            Name = "Ethereal Skeletal Steed Statuette";
            ItemID = 9751;
            MountedID = 16059;
            RegularID = 9751;
            LootType = LootType.Blessed;
        }

    private string _title;
    
    public string Title
    {
        get{ return _title; }
        set{ _title = value; }
    }
    
    public override void OnAdded(object parent)
	{
	base.OnAdded(parent);
 
	if(parent is Mobile)
	{
	Mobile from = (Mobile)parent;
 
	Title = from.Title;
	from.Title = "The Mighty";
 	 from.RawStr += 10;
	}
		}
 
	public override void OnRemoved(object parent)
	{
	base.OnRemoved(parent);
 
	if(parent is Mobile)
	{
	Mobile from = (Mobile)parent;
 
	from.Title = Title;
	Title = null;
	 from.RawStr -= 10;
	}
		}

        public EtherealSkeletalSteed(Serial serial)
            : base(serial)
        {
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write((int)0);
            writer.Write(Title);
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();
        
        switch(version)
        {
            case 0:
                Title = reader.ReadString();
                break;
	}

            if (Name != "Ethereal Skeletal Steed Statuette")
                Name = "Ethereal Skeletal Steed Statuette";
        }
    }

    //__________________________________________________________________________________________________________________________

    public class EtherealChimera : EtherealMount
    {

        [Constructable]
        public EtherealChimera()
            : base(11670, 0x3E91)
        {
            Name = "Ethereal Chimera Statuette";
            ItemID = 11669;
            MountedID = 16016;
            RegularID = 11669;
            LootType = LootType.Blessed;
        }

    private string _title;
    
    public string Title
    {
        get{ return _title; }
        set{ _title = value; }
    }
    
    public override void OnAdded(object parent)
	{
	base.OnAdded(parent);
 
	if(parent is Mobile)
	{
	Mobile from = (Mobile)parent;
 
	Title = from.Title;
	from.Title = "The Quick";
 	 from.RawDex += 10;
	}
		}
 
	public override void OnRemoved(object parent)
	{
	base.OnRemoved(parent);
 
	if(parent is Mobile)
	{
	Mobile from = (Mobile)parent;
 
	from.Title = Title;
	Title = null;
	 from.RawDex -= 10;
	}
		}

        public EtherealChimera(Serial serial)
            : base(serial)
        {
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write((int)0);
            writer.Write(Title);
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();
        
        switch(version)
        {
            case 0:
                Title = reader.ReadString();
                break;
	}
            if (Name != "Ethereal Chimera Statuette")
                Name = "Ethereal Chimera Statuette";
        }
    }

    //_____________________________________________________________________________________________________________________________________________________________________

    public class EtherealChargerOfTheFallen : EtherealMount
    {

        [Constructable]
        public EtherealChargerOfTheFallen()
            : base(11670, 0x3E91)
        {
            Name = "Ethereal Charger Of The Fallen Statuette";
            ItemID = 11676;
            MountedID = 16018;
            RegularID = 11676;
            LootType = LootType.Blessed;
        }

    private string _title;
    
    public string Title
    {
        get{ return _title; }
        set{ _title = value; }
    }
    
    public override void OnAdded(object parent)
	{
	base.OnAdded(parent);
 
	if(parent is Mobile)
	{
	Mobile from = (Mobile)parent;
 
	Title = from.Title;
	from.Title = "The Blessed";
 	 from.RawInt += 10;
 	 from.RawStr += 10;
 	 from.RawDex += 10;
	}
		}
 
	public override void OnRemoved(object parent)
	{
	base.OnRemoved(parent);
 
	if(parent is Mobile)
	{
	Mobile from = (Mobile)parent;
 
	from.Title = Title;
	Title = null;
	 from.RawInt -= 10;
	 from.RawStr -= 10;
	 from.RawDex -= 10;
	}
		}

        public EtherealChargerOfTheFallen(Serial serial)
            : base(serial)
        {
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write((int)0);
            writer.Write(Title);
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();
        
        switch(version)
        {
            case 0:
                Title = reader.ReadString();
                break;
	}
            if (Name != "Ethereal Charger Of The Fallen Statuette")
                Name = "Ethereal Charger Of The Fallen Statuette";
        }
    }
}