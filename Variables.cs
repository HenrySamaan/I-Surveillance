using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I_Surveillance
{
    class Variables
    {
        public static string Username;
        public static string Password;
        public static string buttonclicked = "true";
        public static List<string> EmptyStrings = new List<string>();
        public static List<string> checkedbuttons = new List<string>();
        public static CameraAddForm cameraAddForm;
        public static AddServerForm addServerForm;
        public static AddSwitchForm addSwitchForm;
        public static AddRouter addRouterForm;
        public static bool checkifvalueisempty()
        {
            foreach (string empty in Variables.EmptyStrings)
            {
                if (String.IsNullOrEmpty(empty))
                {
                    return true;
                    break;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }

        public static bool checkifbuttonchecked()
        {
            foreach (string clicked in Variables.checkedbuttons)
            {
                if (clicked == "true")
                {
                    return true;
                    break;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
    }
}
