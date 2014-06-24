using System;
using System.Collections;
using Server.Items;
using Server.Mobiles;

//
// XmlQuestBookGump
// modified from RC0 BOBGump.cs
//
namespace Server.Gumps
{
    public class XmlQuestBookGump : Gump
    {
        private const int LabelColor = 0x7FFF;
        private readonly PlayerMobile m_From;
        private readonly XmlQuestBook m_Book;
        private readonly ArrayList m_List;
        private readonly int m_Page;
        public XmlQuestBookGump(PlayerMobile from, XmlQuestBook book)
            : this(from, book, 0, null)
        {
        }

        public XmlQuestBookGump(PlayerMobile from, XmlQuestBook book, int page, ArrayList list)
            : base(12, 24)
        {
            from.CloseGump(typeof(XmlQuestBookGump));

            this.m_From = from;
            this.m_Book = book;
            this.m_Page = page;

            if (list == null)
            {
                // make a new list based on the number of items in the book
                int nquests = 0;

                Item[] questitems = book.FindItemsByType(typeof(IXmlQuest));

                if (questitems != null)
                    nquests = questitems.Length;

                list = new ArrayList(nquests);

                for (int i = 0; i < nquests; ++i)
                {
                    list.Add(questitems[i]);
                }
            }

            this.m_List = list;

            int index = this.GetIndexForPage(page);
            int count = this.GetCountForIndex(index);

            int tableIndex = 0;

            int width = 600;

            width = 516;

            this.X = (624 - width) / 2;
			
            int xoffset = 0;
            if (this.m_Book.Locked)
                xoffset = 20;

            this.AddPage(0);

            this.AddBackground(10, 10, width, 439, 5054);
            this.AddImageTiled(18, 20, width - 17, 420, 2624);

            this.AddImageTiled(58 - xoffset, 64, 36, 352, 200); // open
            this.AddImageTiled(96 - xoffset, 64, 163, 352, 1416);  // name
            this.AddImageTiled(261 - xoffset, 64, 55, 352, 200); // type
            this.AddImageTiled(308 - xoffset, 64, 85, 352, 1416);  // status
            this.AddImageTiled(395 - xoffset, 64, 116, 352, 200);  // expires

            for (int i = index; i < (index + count) && i >= 0 && i < list.Count; ++i)
            {
                object obj = list[i];

                this.AddImageTiled(24, 94 + (tableIndex * 32), 489, 2, 2624);

                ++tableIndex;
            }

            this.AddAlphaRegion(18, 20, width - 17, 420);
            this.AddImage(5, 5, 10460);
            this.AddImage(width - 15, 5, 10460);
            this.AddImage(5, 424, 10460);
            this.AddImage(width - 15, 424, 10460);

            this.AddHtmlLocalized(224, 32, 200, 32, 1046026, LabelColor, false, false); // Quest Log
            this.AddHtmlLocalized(63 - xoffset, 64, 200, 32, 3000362, LabelColor, false, false); // Open
            this.AddHtmlLocalized(147 - xoffset, 64, 200, 32, 3005104, LabelColor, false, false); // Name
            this.AddHtmlLocalized(270 - xoffset, 64, 200, 32, 1062213, LabelColor, false, false); // Type
            this.AddHtmlLocalized(326 - xoffset, 64, 200, 32, 3000132, LabelColor, false, false); // Status
            this.AddHtmlLocalized(429 - xoffset, 64, 200, 32, 1062465, LabelColor, false, false); // Expires

            this.AddButton(375 - xoffset, 416, 4017, 4018, 0, GumpButtonType.Reply, 0);

            this.AddHtmlLocalized(410 - xoffset, 416, 120, 20, 1011441, LabelColor, false, false); // EXIT
            if (!this.m_Book.Locked)
                this.AddHtmlLocalized(26, 64, 50, 32, 1062212, LabelColor, false, false); // Drop

            tableIndex = 0;

            if (page > 0)
            {
                this.AddButton(75, 416, 4014, 4016, 2, GumpButtonType.Reply, 0);
                this.AddHtmlLocalized(110, 416, 150, 20, 1011067, LabelColor, false, false); // Previous page
            }

            if (this.GetIndexForPage(page + 1) < list.Count)
            {
                this.AddButton(225, 416, 4005, 4007, 3, GumpButtonType.Reply, 0);
                this.AddHtmlLocalized(260, 416, 150, 20, 1011066, LabelColor, false, false); // Next page
            }

            for (int i = index; i < (index + count) && i >= 0 && i < list.Count; ++i)
            {
                object obj = list[i];

                if (obj is IXmlQuest)
                {
                    IXmlQuest e = (IXmlQuest)obj;

                    int y = 96 + (tableIndex++ * 32);

                    if (!this.m_Book.Locked)
                        this.AddButton(35, y + 2, 5602, 5606, 1000 + i, GumpButtonType.Reply, 0); // drop

                    this.AddButton(60 - xoffset, y + 2, 0xFAB, 0xFAD, 2000 + i, GumpButtonType.Reply, 0); // open gump

                    int color;

                    if (!e.IsValid)
                    {
                        color = 33;
                    }
                    else if (e.IsCompleted)
                    {
                        color = 67;
                    }
                    else
                    {
                        color = 5;
                    }

                    this.AddLabel(100 - xoffset, y, color, (string)e.Name);

                    //AddHtmlLocalized( 315, y, 200, 32, e.IsCompleted ? 1049071 : 1049072, htmlcolor, false, false ); // Completed/Incomplete
                    this.AddLabel(315 - xoffset, y, color, e.IsCompleted ? "Completed" : "In Progress");

                    // indicate the expiration time
                    if (e.IsValid)
                    {
                        // do a little parsing of the expiration string to fit it in the space
                        string substring = e.ExpirationString;
                        if (e.ExpirationString.IndexOf("Expires in") >= 0)
                        {
                            substring = e.ExpirationString.Substring(11);
                        }
                        this.AddLabel(400 - xoffset, y, color, (string)substring);
                    }
                    else
                    {
                        this.AddLabel(400 - xoffset, y, color, "No longer valid");
                    }

                    if (e.PartyEnabled)
                    {
                        this.AddLabel(270 - xoffset, y, color, "Party");
                        //AddHtmlLocalized( 250, y, 200, 32, 3000332, htmlcolor, false, false ); // Party
                    }
                    else
                    {
                        this.AddLabel(270 - xoffset, y, color, "Solo");
                    }
                }
            }
        }

        public int GetIndexForPage(int page)
        {
            int index = 0;

            while (page-- > 0)
                index += this.GetCountForIndex(index);

            return index;
        }

        public int GetCountForIndex(int index)
        {
            int slots = 0;
            int count = 0;

            ArrayList list = this.m_List;

            for (int i = index; i >= 0 && i < list.Count; ++i)
            {
                object obj = list[i];

                int add;

                add = 1;

                if ((slots + add) > 10)
                    break;

                slots += add;

                ++count;
            }

            return count;
        }

        public override void OnResponse(Server.Network.NetState sender, RelayInfo info)
        {
            if (info == null || this.m_From == null)
                return;

            switch ( info.ButtonID )
            {
                case 0: // EXIT
                    {
                        break;
                    }

                case 2: // Previous page
                    {
                        if (this.m_Page > 0)
                            this.m_From.SendGump(new XmlQuestBookGump(this.m_From, this.m_Book, this.m_Page - 1, this.m_List));

                        return;
                    }
                case 3: // Next page
                    {
                        if (this.GetIndexForPage(this.m_Page + 1) < this.m_List.Count)
                            this.m_From.SendGump(new XmlQuestBookGump(this.m_From, this.m_Book, this.m_Page + 1, this.m_List));

                        break;
                    }

                default:
                    {
                        if (info.ButtonID >= 2000)
                        {
                            int index = info.ButtonID - 2000;

                            if (index < 0 || index >= this.m_List.Count)
                                break;

                            if (this.m_List[index] is IXmlQuest)
                            {
                                IXmlQuest o = this.m_List[index] as IXmlQuest;
    
                                if (o != null && !o.Deleted)
                                {
                                    this.m_From.SendGump(new XmlQuestBookGump(this.m_From, this.m_Book, this.m_Page, null));
                                    this.m_From.CloseGump(typeof(XmlQuestStatusGump));
                                    this.m_From.SendGump(new XmlQuestStatusGump(o, o.TitleString, 320, 0, true));
                                }
                            }
                        }
                        else if (info.ButtonID >= 1000)
                        {
                            int index = info.ButtonID - 1000;

                            if (index < 0 || index >= this.m_List.Count)
                                break;

                            // allow quests to be dropped from books that are either in the world or in the players backpack
                            if (this.m_Book.IsChildOf(this.m_From.Backpack) || (this.m_Book.Parent == null))
                            {
                                // move the item from the book to the players backpack
                                Item item = this.m_List[index] as Item;
  
                                if (item != null && !item.Deleted)
                                {
                                    this.m_From.AddToBackpack(item);

                                    this.m_From.SendGump(new XmlQuestBookGump(this.m_From, this.m_Book, this.m_Page, null));
                                }
                                else
                                {
                                    this.m_From.SendMessage("Internal error. The quest could not be retrieved.");
                                }
                            }
                        }

                        break;
                    }
            }
        }
    }
}