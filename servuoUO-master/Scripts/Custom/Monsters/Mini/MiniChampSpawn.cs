using System;
using System.Collections;
using Server;
using Server.Gumps;
using Server.Items;
using Server.Mobiles;
using Server.Regions;
using System.Collections.Generic;

namespace Server.Engines.SAMiniChamps
{
    public class MiniChampSpawn : Item
    {
        private bool m_Active;
        private bool m_RandomizeType;
        private MiniChampType m_Type;
        private List<Mobile> m_Creatures;
        private List<Item> m_RedSkulls;
        private List<Item> m_WhiteSkulls;
        private MiniChampPlatform m_MiniPlatform;
        private MiniChampAltar m_MiniAltar;
        private int m_Kills;
        private Mobile m_MiniChamp;

        //private int m_SpawnRange;
        private Rectangle2D m_SpawnArea;
        private MiniChampSpawnRegion m_Region;

        private TimeSpan m_ExpireDelay;
        private DateTime m_ExpireTime;

        private TimeSpan m_RestartDelay;
        private DateTime m_RestartTime;

        private Timer m_Timer, m_MiniRestartTimer;

        private bool m_HasBeenAdvanced;
        private bool m_ConfinedRoaming;

        private Dictionary<Mobile, int> m_DamageEntries;

        [CommandProperty(AccessLevel.GameMaster)]
        public bool ConfinedRoaming
        {
            get { return m_ConfinedRoaming; }
            set { m_ConfinedRoaming = value; }
        }

        [CommandProperty(AccessLevel.GameMaster)]
        public bool HasBeenAdvanced
        {
            get { return m_HasBeenAdvanced; }
            set { m_HasBeenAdvanced = value; }
        }
		
        [Constructable]
		public MiniChampSpawn()
			: base(0xBD2)
        {
            Movable = false;
            Visible = false;

            m_Creatures = new List<Mobile>();
            m_RedSkulls = new List<Item>();
            m_WhiteSkulls = new List<Item>();

            m_MiniPlatform = new MiniChampPlatform(this);
            m_MiniAltar = new MiniChampAltar(this);

            m_ExpireDelay = TimeSpan.FromMinutes(10.0);
            m_RestartDelay = TimeSpan.FromMinutes(5.0);

            m_DamageEntries = new Dictionary<Mobile, int>();

            Timer.DelayCall(TimeSpan.Zero, new TimerCallback(SetInitialSpawnArea));
        }

        public void SetInitialSpawnArea()
        {
            //Previous default used to be 24;
            SpawnArea = new Rectangle2D(new Point2D(X - 18, Y - 18), new Point2D(X + 18, Y + 18));
        }

        public void UpdateRegion()
        {
            if (m_Region != null)
                m_Region.Unregister();

            if (!Deleted && this.Map != Map.Internal)
            {
                m_Region = new MiniChampSpawnRegion(this);
                m_Region.Register();
            }
        }

        [CommandProperty(AccessLevel.GameMaster)]
        public bool RandomizeType
        {
            get { return m_RandomizeType; }
            set { m_RandomizeType = value; }
        }

        [CommandProperty(AccessLevel.GameMaster)]
        public int Kills
        {
            get
            {
                return m_Kills;
            }
            set
            {
                m_Kills = value;
                InvalidateProperties();
            }
        }

        [CommandProperty(AccessLevel.GameMaster)]
        public Rectangle2D SpawnArea
        {
            get
            {
                return m_SpawnArea;
            }
            set
            {
                m_SpawnArea = value;
                InvalidateProperties();
                UpdateRegion();
            }
        }

        [CommandProperty(AccessLevel.GameMaster)]
        public TimeSpan RestartDelay
        {
            get
            {
                return m_RestartDelay;
            }
            set
            {
                m_RestartDelay = value;
            }
        }

        [CommandProperty(AccessLevel.GameMaster)]
        public DateTime RestartTime
        {
            get
            {
                return m_RestartTime;
            }
        }

        [CommandProperty(AccessLevel.GameMaster)]
        public TimeSpan ExpireDelay
        {
            get
            {
                return m_ExpireDelay;
            }
            set
            {
                m_ExpireDelay = value;
            }
        }

        [CommandProperty(AccessLevel.GameMaster)]
        public DateTime ExpireTime
        {
            get
            {
                return m_ExpireTime;
            }
            set
            {
                m_ExpireTime = value;
            }
        }

        [CommandProperty(AccessLevel.GameMaster)]
        public MiniChampType Type
        {
            get
            {
                return m_Type;
            }
            set
            {
                m_Type = value;
                InvalidateProperties();
            }
        }

        [CommandProperty(AccessLevel.GameMaster)]
        public bool Active
        {
            get
            {
                return m_Active;
            }
            set
            {
                if (value)
                    Start();
                else
                    Stop();

                InvalidateProperties();
            }
        }

        [CommandProperty(AccessLevel.GameMaster)]
        public Mobile MiniChamp
        {
            get
            {
                return m_MiniChamp;
            }
            set
            {
                m_MiniChamp = value;
            }
        }

        [CommandProperty(AccessLevel.GameMaster)]
        public int Level
        {
            get
            {
                return m_RedSkulls.Count;
            }
            set
            {
                for (int i = m_RedSkulls.Count - 1; i >= value; --i)
                {
                    m_RedSkulls[i].Delete();
                    m_RedSkulls.RemoveAt(i);
                }

                for (int i = m_RedSkulls.Count; i < value; ++i)
                {
                    Item skull = new Item(0x1854);

                    skull.Hue = 0x26;
                    skull.Movable = false;
					skull.Visible = false;
                    skull.Light = LightType.Circle150;

                    skull.MoveToWorld(GetRedSkullLocation(i), Map);

                    m_RedSkulls.Add(skull);
                }

                InvalidateProperties();
            }
        }

        public int MaxKills
        {
			get
			{
				return 85 - (Level * 1);
			}
		}

		public bool IsMiniChampSpawn( Mobile m )
		{
			return m_Creatures.Contains( m );
		}

        public void SetWhiteSkullCount(int val)
        {
            for (int i = m_WhiteSkulls.Count - 1; i >= val; --i)
            {
                m_WhiteSkulls[i].Delete();
                m_WhiteSkulls.RemoveAt(i);
            }

            for (int i = m_WhiteSkulls.Count; i < val; ++i)
            {
                Item skull = new Item(0x1854);

                skull.Movable = false;
				skull.Visible = false;
                skull.Light = LightType.Circle150;

                skull.MoveToWorld(GetWhiteSkullLocation(i), Map);

                m_WhiteSkulls.Add(skull);

                Effects.PlaySound(skull.Location, skull.Map, 0x29);
                Effects.SendLocationEffect(new Point3D(skull.X + 1, skull.Y + 1, skull.Z), skull.Map, 0x3728, 10);
			}
        }

        public void Start()
        {
            if (m_Active || Deleted)
                return;

            m_Active = true;
            m_HasBeenAdvanced = false;

            if (m_Timer != null)
                m_Timer.Stop();

            m_Timer = new MiniSliceTimer(this);
            m_Timer.Start();

            if (m_MiniRestartTimer != null)
                m_MiniRestartTimer.Stop();

            m_MiniRestartTimer = null;

            if (m_MiniAltar != null)
            {
                if (m_MiniChamp != null)
                    m_MiniAltar.Hue = 0x26;
                else
                    m_MiniAltar.Hue = 0;
            }

            if (m_MiniPlatform != null)
                m_MiniPlatform.Hue = 0x452;
        }

        public void Stop()
        {
            if (!m_Active || Deleted)
                return;

            m_Active = false;
            m_HasBeenAdvanced = false;

            if (m_Timer != null)
                m_Timer.Stop();

            m_Timer = null;

            if (m_MiniRestartTimer != null)
                m_MiniRestartTimer.Stop();

            m_MiniRestartTimer = null;

            if (m_MiniAltar != null)
                m_MiniAltar.Hue = 0;

            if (m_MiniPlatform != null)
                m_MiniPlatform.Hue = 0x497;
        }

        public void BeginRestart(TimeSpan ts)
        {
            if (m_MiniRestartTimer != null)
                m_MiniRestartTimer.Stop();

            m_RestartTime = DateTime.Now + ts;

            m_MiniRestartTimer = new MiniRestartTimer(this, ts);
            m_MiniRestartTimer.Start();
        }

        public void EndRestart()
        {
            if (RandomizeType)
            {
                switch (Utility.Random(5))
                {
                    case 0: Type = MiniChampType.SecretGarden; break;
                    case 1: Type = MiniChampType.StygianDragonLair; break;
                    case 2: Type = MiniChampType.CrimsonVeins; break;
                    case 3: Type = MiniChampType.AbyssalLair; break;
                    case 4: Type = MiniChampType.FireTemple; break;
                }
            }

            m_HasBeenAdvanced = false;

            Start();
        }

        public void OnSlice()
        {
            if (!m_Active || Deleted)
                return;

            if (m_MiniChamp != null)
            {
                if (m_MiniChamp.Deleted)
                {
                    RegisterDamageTo(m_MiniChamp);					
                    m_DamageEntries.Clear();
					
					for( int i = 0; i < m_Creatures.Count; ++i )
					{
						Mobile mob = (Mobile)m_Creatures[i];

						if( !mob.Player )
							mob.Delete();
					}

					m_Creatures.Clear();
                    if (m_MiniPlatform != null)
                        m_MiniPlatform.Hue = 0x497;

                    if (m_MiniAltar != null)
                    {
                        m_MiniAltar.Hue = 0;
                    }

                    m_MiniChamp = null;
                    Stop();

                    BeginRestart(m_RestartDelay);
                }
            }
            else
            {
                int kills = m_Kills;

                for (int i = 0; i < m_Creatures.Count; ++i)
                {
                    Mobile m = m_Creatures[i];

                    if (m.Deleted)
                    {
						if( m.Corpse != null && !m.Corpse.Deleted )
						{
							((Corpse)m.Corpse).BeginDecay( TimeSpan.FromMinutes( 1 ));
						}
                        m_Creatures.RemoveAt(i);
                        --i;
                        ++m_Kills;

                        Mobile killer = m.FindMostRecentDamager(false);

                        RegisterDamageTo(m);
                    }
                }

                // Only really needed once.
                
				if (m_Kills > kills)
                    InvalidateProperties();

                double n = m_Kills / (double)MaxKills;
                int p = (int)(n * 85);

                if (p >= 22)
                    AdvanceLevel();
                else if (p > 0)
                    SetWhiteSkullCount(p / 5);

                if (DateTime.Now >= m_ExpireTime)
                    Expire();

                Respawn();
            }
        }

        public void AdvanceLevel()
        {
            m_ExpireTime = DateTime.Now + m_ExpireDelay;

            if (Level < 3)
            {
                m_Kills = 0;
                ++Level;
                InvalidateProperties();
                SetWhiteSkullCount(0);

                if (m_MiniAltar != null)
                {
                    Effects.PlaySound(m_MiniAltar.Location, m_MiniAltar.Map, 0x29);
                    Effects.SendLocationEffect(new Point3D(m_MiniAltar.X + 1, m_MiniAltar.Y + 1, m_MiniAltar.Z), m_MiniAltar.Map, 0x3728, 10);
                }
            }
            else
            {
                SpawnMiniChamp();
            }
        }

        public void SpawnMiniChamp()
        {
            if (m_MiniAltar != null)
                m_MiniAltar.Hue = 0x26;

            if (m_MiniPlatform != null)
                m_MiniPlatform.Hue = 0x452;

            m_Kills = 0;
            Level = 0;
            InvalidateProperties();
            SetWhiteSkullCount(0);

            try
            {
                m_MiniChamp = Activator.CreateInstance(MiniChampSpawnInfo.GetInfo(m_Type).MiniChamp) as Mobile;
            }
            catch { }

            if (m_MiniChamp != null)
                m_MiniChamp.MoveToWorld(new Point3D(X, Y, Z - 15), Map);
        }

        public void Respawn()
        {
            if (!m_Active || Deleted || m_MiniChamp != null)
                return;

            if (m_Type == MiniChampType.SecretGarden || m_Type == MiniChampType.EnslavedGoblins)
            {
                while( m_Creatures.Count < (5 - (GetSubLevel() * 2)) )
                {
                    Mobile m = Spawn();

                    if (m == null)
                        return;

                    Point3D loc = GetSpawnLocation();

                    // Allow creatures to turn into Paragons at Ilshenar champions.
                    m.OnBeforeSpawn(loc, Map);

                    m_Creatures.Add(m);
                    m.MoveToWorld(loc, Map);

                    if (m is BaseCreature)
                    {
                        BaseCreature bc = m as BaseCreature;
                        bc.Tamable = false;

                        if (!m_ConfinedRoaming)
                        {
                            bc.Home = this.Location;
                            bc.RangeHome = (int)(Math.Sqrt(m_SpawnArea.Width * m_SpawnArea.Width + m_SpawnArea.Height * m_SpawnArea.Height) / 2);
                        }
                        else
                        {
                            bc.Home = bc.Location;

                            Point2D xWall1 = new Point2D(m_SpawnArea.X, bc.Y);
                            Point2D xWall2 = new Point2D(m_SpawnArea.X + m_SpawnArea.Width, bc.Y);
                            Point2D yWall1 = new Point2D(bc.X, m_SpawnArea.Y);
                            Point2D yWall2 = new Point2D(bc.X, m_SpawnArea.Y + m_SpawnArea.Height);

                            double minXDist = Math.Min(bc.GetDistanceToSqrt(xWall1), bc.GetDistanceToSqrt(xWall2));
                            double minYDist = Math.Min(bc.GetDistanceToSqrt(yWall1), bc.GetDistanceToSqrt(yWall2));

                            bc.RangeHome = (int)Math.Min(minXDist, minYDist);
                        }
                    }
                }
            }
            else
            {
                while (m_Creatures.Count < (39 - (GetSubLevel() * 3)))
                {
                    Mobile m = Spawn();

                    if (m == null)
                        return;

                    Point3D loc = GetSpawnLocation();

                    // Allow creatures to turn into Paragons at Ilshenar champions.
                    m.OnBeforeSpawn(loc, Map);

                    m_Creatures.Add(m);
                    m.MoveToWorld(loc, Map);

                    if (m is BaseCreature)
                    {
                        BaseCreature bc = m as BaseCreature;
                        bc.Tamable = false;

                        if (!m_ConfinedRoaming)
                        {
                            bc.Home = this.Location;
                            bc.RangeHome = (int)(Math.Sqrt(m_SpawnArea.Width * m_SpawnArea.Width + m_SpawnArea.Height * m_SpawnArea.Height) / 2);
                        }
                        else
                        {
                            bc.Home = bc.Location;

                            Point2D xWall1 = new Point2D(m_SpawnArea.X, bc.Y);
                            Point2D xWall2 = new Point2D(m_SpawnArea.X + m_SpawnArea.Width, bc.Y);
                            Point2D yWall1 = new Point2D(bc.X, m_SpawnArea.Y);
                            Point2D yWall2 = new Point2D(bc.X, m_SpawnArea.Y + m_SpawnArea.Height);

                            double minXDist = Math.Min(bc.GetDistanceToSqrt(xWall1), bc.GetDistanceToSqrt(xWall2));
                            double minYDist = Math.Min(bc.GetDistanceToSqrt(yWall1), bc.GetDistanceToSqrt(yWall2));

                            bc.RangeHome = (int)Math.Min(minXDist, minYDist);
                        }
                    }
                }
            }
        }

        public Point3D GetSpawnLocation()
        {
            Map map = Map;

            if (map == null)
                return Location;

            // Try 20 times to find a spawnable location.
            for (int i = 0; i < 20; i++)
            {
                int x = Utility.Random(m_SpawnArea.X, m_SpawnArea.Width);
                int y = Utility.Random(m_SpawnArea.Y, m_SpawnArea.Height);

                int z = Map.GetAverageZ(x, y);

                if (Map.CanSpawnMobile(new Point2D(x, y), z))
                    return new Point3D(x, y, z);
            }

            return Location;
        }

		private const int Level1 = 2;  // First spawn level from 0-5 red skulls
		private const int Level2 = 4;  // Second spawn level from 6-9 red skulls
		private const int Level3 = 6; // Third spawn level from 10-13 red skulls

        public int GetSubLevel()
        {
            int level = this.Level;

            if (level <= Level1)
                return 0;
            else if (level <= Level2)
                return 1;
            else if (level <= Level3)
                return 2;

            return 3;
        }

        public int GetSubLevelFor(Mobile m)
        {
            Type[][] types = MiniChampSpawnInfo.GetInfo(m_Type).MiniSpawnTypes;
            Type t = m.GetType();

            for (int i = 0; i < types.GetLength(0); i++)
            {
                Type[] individualTypes = types[i];

                for (int j = 0; j < individualTypes.Length; j++)
                {
                    if (t == individualTypes[j])
                        return i;
                }
            }

            return -1;
        }

        public Mobile Spawn()
        {
            Type[][] types = MiniChampSpawnInfo.GetInfo(m_Type).MiniSpawnTypes;

            int v = GetSubLevel();

            if (v >= 0 && v < types.Length)
                return Spawn(types[v]);

            return null;
        }

        public Mobile Spawn(params Type[] types)
        {
            try
            {
                return Activator.CreateInstance(types[Utility.Random(types.Length)]) as Mobile;
            }
            catch
            {
                return null;
            }
        }

        public void Expire()
        {
            m_Kills = 0;

            if (m_WhiteSkulls.Count == 0)
            {
                // They didn't even get 20%, go back a level

                if (Level > 0)
                    --Level;

                InvalidateProperties();
            }
            else
            {
                SetWhiteSkullCount(0);
            }

            m_ExpireTime = DateTime.Now + m_ExpireDelay;
        }

        public Point3D GetRedSkullLocation(int index)
        {
            int x, y;

            if (index < 5)
            {
                x = index - 2;
                y = -2;
            }
            else if (index < 9)
            {
                x = 2;
                y = index - 6;
            }
            else if (index < 13)
            {
                x = 10 - index;
                y = 2;
            }
            else
            {
                x = -2;
                y = 14 - index;
            }

            return new Point3D(X + x, Y + y, Z - 15);
        }

        public Point3D GetWhiteSkullLocation(int index)
        {
            int x, y;

            switch (index)
            {
                default:
                case 0: x = -1; y = -1; break;
                case 1: x = 1; y = -1; break;
                case 2: x = 1; y = 1; break;
                case 3: x = -1; y = 1; break;
            }

            return new Point3D(X + x, Y + y, Z - 15);
        }

        public override void AddNameProperty(ObjectPropertyList list)
        {
            list.Add("mini champ spawn");
        }

        public override void GetProperties(ObjectPropertyList list)
        {
            base.GetProperties(list);

            if (m_Active)
            {
                list.Add(1060742); // active
                list.Add(1060658, "Type\t{0}", m_Type); // ~1_val~: ~2_val~
                list.Add(1060659, "Level\t{0}", Level); // ~1_val~: ~2_val~
                list.Add(1060660, "Kills\t{0} of {1} ({2:F1}%)", m_Kills, MaxKills, 100.0 * ((double)m_Kills / MaxKills)); // ~1_val~: ~2_val~
            }
            else
            {
                list.Add(1060743); // inactive
            }
        }

        public override void OnSingleClick(Mobile from)
        {
            if (m_Active)
                LabelTo(from, "{0} (Active; Level: {1}; Kills: {2}/{3})", m_Type, Level, m_Kills, MaxKills);
            else
                LabelTo(from, "{0} (Inactive)", m_Type);
        }

        public override void OnDoubleClick(Mobile from)
        {
            from.SendGump(new PropertiesGump(from, this));
        }

        public override void OnLocationChange(Point3D oldLoc)
        {
            if (Deleted)
                return;

            if (m_MiniPlatform != null)
                m_MiniPlatform.Location = new Point3D(X, Y, Z - 20);

            if (m_MiniAltar != null)
                m_MiniAltar.Location = new Point3D(X, Y, Z - 15);

            if (m_RedSkulls != null)
            {
                for (int i = 0; i < m_RedSkulls.Count; ++i)
                    m_RedSkulls[i].Location = GetRedSkullLocation(i);
            }

            if (m_WhiteSkulls != null)
            {
                for (int i = 0; i < m_WhiteSkulls.Count; ++i)
                    m_WhiteSkulls[i].Location = GetWhiteSkullLocation(i);
            }

            m_SpawnArea.X += Location.X - oldLoc.X;
            m_SpawnArea.Y += Location.Y - oldLoc.Y;

            UpdateRegion();
        }

        public override void OnMapChange()
        {
            if (Deleted)
                return;

            if (m_MiniPlatform != null)
                m_MiniPlatform.Map = Map;

            if (m_MiniAltar != null)
                m_MiniAltar.Map = Map;

            if (m_RedSkulls != null)
            {
                for (int i = 0; i < m_RedSkulls.Count; ++i)
                    m_RedSkulls[i].Map = Map;
            }

            if (m_WhiteSkulls != null)
            {
                for (int i = 0; i < m_WhiteSkulls.Count; ++i)
                    m_WhiteSkulls[i].Map = Map;
            }

            UpdateRegion();
        }

        public override void OnAfterDelete()
        {
            base.OnAfterDelete();

            if (m_MiniPlatform != null)
                m_MiniPlatform.Delete();

            if (m_MiniAltar != null)
                m_MiniAltar.Delete();

            if (m_RedSkulls != null)
            {
                for (int i = 0; i < m_RedSkulls.Count; ++i)
                    m_RedSkulls[i].Delete();

                m_RedSkulls.Clear();
            }

            if (m_WhiteSkulls != null)
            {
                for (int i = 0; i < m_WhiteSkulls.Count; ++i)
                    m_WhiteSkulls[i].Delete();

                m_WhiteSkulls.Clear();
            }

            if (m_Creatures != null)
            {
                for (int i = 0; i < m_Creatures.Count; ++i)
                {
                    Mobile mob = m_Creatures[i];

                    if (!mob.Player)
                        mob.Delete();
                }

                m_Creatures.Clear();
            }

            if (m_MiniChamp != null && !m_MiniChamp.Player)
                m_MiniChamp.Delete();

            Stop();

            UpdateRegion();
        }

		public MiniChampSpawn(Serial serial)
			: base(serial)
        {
        }

        public virtual void RegisterDamageTo(Mobile m)
        {
            if (m == null)
                return;

            foreach (DamageEntry de in m.DamageEntries)
            {
                if (de.HasExpired)
                    continue;

                Mobile damager = de.Damager;

                Mobile master = damager.GetDamageMaster(m);

                if (master != null)
                    damager = master;

                RegisterDamage(damager, de.DamageGiven);
            }
        }

        public void RegisterDamage(Mobile from, int amount)
        {
            if (from == null || !from.Player)
                return;

            if (m_DamageEntries.ContainsKey(from))
                m_DamageEntries[from] += amount;
            else
                m_DamageEntries.Add(from, amount);
        }
		
        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write((int)5); // version


            writer.Write(m_DamageEntries.Count);
            foreach (KeyValuePair<Mobile, int> kvp in m_DamageEntries)
            {
                writer.Write(kvp.Key);
                writer.Write(kvp.Value);
            }

            writer.Write(m_ConfinedRoaming);
            writer.Write(m_HasBeenAdvanced);
            writer.Write(m_SpawnArea);

            writer.Write(m_RandomizeType);
            writer.Write(m_Kills);

            writer.Write((bool)m_Active);
            writer.Write((int)m_Type);
            writer.Write(m_Creatures, true);
            writer.Write(m_RedSkulls, true);
            writer.Write(m_WhiteSkulls, true);
            writer.WriteItem<MiniChampPlatform>(m_MiniPlatform);
            writer.WriteItem<MiniChampAltar>(m_MiniAltar);
            writer.Write(m_ExpireDelay);
            writer.WriteDeltaTime(m_ExpireTime);
            writer.Write(m_MiniChamp);
            writer.Write(m_RestartDelay);

            writer.Write(m_MiniRestartTimer != null);

            if (m_MiniRestartTimer != null)
                writer.WriteDeltaTime(m_RestartTime);
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            m_DamageEntries = new Dictionary<Mobile, int>();

            int version = reader.ReadInt();

            switch (version)
            {
                case 5:
                    {
                        int entries = reader.ReadInt();
                        Mobile m;
                        int damage;
                        for (int i = 0; i < entries; ++i)
                        {
                            m = reader.ReadMobile();
                            damage = reader.ReadInt();

                            if (m == null)
                                continue;

                            m_DamageEntries.Add(m, damage);
                        }

                        goto case 4;
                    }
                case 4:
                    {
                        m_ConfinedRoaming = reader.ReadBool();
                        m_HasBeenAdvanced = reader.ReadBool();

                        goto case 3;
                    }
                case 3:
                    {
                        m_SpawnArea = reader.ReadRect2D();

                        goto case 2;
                    }
                case 2:
                    {
                        m_RandomizeType = reader.ReadBool();

                        goto case 1;
                    }
                case 1:
                    {
                        if (version < 3)
                        {
                            int oldRange = reader.ReadInt();

                            m_SpawnArea = new Rectangle2D(new Point2D(X - oldRange, Y - oldRange), new Point2D(X + oldRange, Y + oldRange));
                        }

                        m_Kills = reader.ReadInt();

                        goto case 0;
                    }
                case 0:
                    {
                        if (version < 1)
                            m_SpawnArea = new Rectangle2D(new Point2D(X - 18, Y - 18), new Point2D(X + 18, Y + 18));	//Default was 24

                        bool active = reader.ReadBool();
                        m_Type = (MiniChampType)reader.ReadInt();
                        m_Creatures = reader.ReadStrongMobileList();
                        m_RedSkulls = reader.ReadStrongItemList();
                        m_WhiteSkulls = reader.ReadStrongItemList();
                        m_MiniPlatform = reader.ReadItem<MiniChampPlatform>();
                        m_MiniAltar = reader.ReadItem<MiniChampAltar>();
                        m_ExpireDelay = reader.ReadTimeSpan();
                        m_ExpireTime = reader.ReadDeltaTime();
                        m_MiniChamp = reader.ReadMobile();
                        m_RestartDelay = reader.ReadTimeSpan();

                        if (reader.ReadBool())
                        {
                            m_RestartTime = reader.ReadDeltaTime();
                            BeginRestart(m_RestartTime - DateTime.Now);
                        }

                        if (m_MiniPlatform == null || m_MiniAltar == null)
                            Delete();
                        else if (active)
                            Start();

                        break;
                    }
            }

            Timer.DelayCall(TimeSpan.Zero, new TimerCallback(UpdateRegion));
        }
    }

	public class MiniChampSpawnRegion : BaseRegion
    {
        private MiniChampSpawn m_Spawn;

        public MiniChampSpawn MiniChampSpawn
        {
            get { return m_Spawn; }
        }

		public MiniChampSpawnRegion(MiniChampSpawn spawn)
			: base(null, spawn.Map, Region.Find(spawn.Location, spawn.Map), spawn.SpawnArea)
        {
            m_Spawn = spawn;
        }

        public override bool AllowHousing(Mobile from, Point3D p)
        {
            return false;
        }

        public override void AlterLightLevel(Mobile m, ref int global, ref int personal)
        {
            base.AlterLightLevel(m, ref global, ref personal);
            global = Math.Max(global, 1 + m_Spawn.Level);
        }
    }
}