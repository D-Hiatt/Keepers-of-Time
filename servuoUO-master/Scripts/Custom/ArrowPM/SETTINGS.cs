using System;
using System.Text;
using Bittiez.ArrowPM;
using Server;

namespace Bittiez.ArrowPM
{
	public class SETTINGS
    {
        #region MessageGump
        public static int MessageGump_W = 329; //Message gump width
        public static int MessageGump_H = 271;//Message gump height

        public static int MessageGump_X = 75; //Message gump X
        public static int MessageGump_Y = 75;//Message gump Y
        #endregion

        #region PMCommand
        public static string[] COMMAND_PREFIX = { "pm", "msg" };
        public static int Max_Name_Canididates = 10; //High number = less strict name matches, lower number = stricter name matching
        #endregion

        #region PM Options
        public static AccessLevel Top_Access = AccessLevel.Player; //This is the highest access level PLAYERS can send PM's to.
        #endregion

        #region Messages
        public static string Too_Many_Matches = "There were too many matches for the name you typed in.";
        public static string No_Matches = "No one by that name was found.";
        public static string Above_Top_Access = "You cannot send messages directly to staff, please use the help system.";
        public static string Message_Sent = "Message sent..";

        public static int Error_Message_Hue = 38;
        public static int Regular_Hue = 42;
        #endregion
    }
}
