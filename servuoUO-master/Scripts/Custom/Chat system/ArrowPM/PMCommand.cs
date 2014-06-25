using System;
using System.Collections.Generic;
using System.Text;
using Server.Commands;
using Server;

namespace Bittiez.ArrowPM
{
    public class PMCommand
    {
        public static int Version = 3;
        public static void Initialize()
        {
            Type t = ScriptCompiler.FindTypeByFullName("Bittiez.Tools");
            if (t == null)
            {
                Console.WriteLine("Bittiez Utilities is required for ArrowPM!");
                throw new Exception("Bittiez Utilities is required for ArrowPM!");
            }

            foreach (string pre in SETTINGS.COMMAND_PREFIX)
                CommandSystem.Register(pre, AccessLevel.GameMaster, new CommandEventHandler(On_PM));

            Bittiez.Tools.ConsoleWrite(ConsoleColor.Blue, "ArrowPM Version " + Bittiez.Tools.Format_Version(Version));
        }

        public static void On_PM(CommandEventArgs e)
        {
            Mobile Sender = e.Mobile;
            if (e.ArgString == null || e.ArgString == "")
            {
                Sender.SendGump(new WriteMessageGump("Write your message here", ""));
                return;
            }

            string Recipient = e.GetString(0);
            string Message = "";

            if (e.Arguments.Length < 2)
            {
                Sender.SendGump(new WriteMessageGump("Write your message here", Recipient));
                return;
            }

            if (e.Arguments.Length > 1)
                Message = e.ArgString.Substring(Recipient.Length + 1, e.ArgString.Length - Recipient.Length - 1);

            List<Mobile> MC = MessCandis(Recipient);

            if (MC.Count > SETTINGS.Max_Name_Canididates)
            {
                Sender.SendMessage(SETTINGS.Error_Message_Hue, SETTINGS.Too_Many_Matches);
                return;
            }

            if (MC.Count < 1)
            {
                Sender.SendMessage(SETTINGS.Error_Message_Hue, SETTINGS.No_Matches);
                return;
            }

            PersonalMessage PM = new PersonalMessage(Sender, MC[0], DateTime.Now, Message);
            MC[0].SendGump(new MessageGump(PM, true));
            Sender.SendMessage(SETTINGS.Regular_Hue, SETTINGS.Message_Sent);
        }

        public static List<Mobile> MessCandis(string name)
        {
            List<Mobile> MC = new List<Mobile>();
            List<Mobile> OP = Bittiez.Tools.List_Connected_Players();
            foreach (Mobile m in OP)
            {
                if (m.RawName.ToLower().Contains(name.ToLower()))
                {
                    MC.Add(m);
                }
            }
            return MC;
        }
    }
}
