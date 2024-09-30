using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace I_Surveillance
{
    class ServerConnection
    {
        private static string host, username, password, command;
        private static string domuser = @$"{username}";
        private static string psexec = $"psexec \\{host} -u {domuser} -p {password}";
        

        public static void loadserverscontrol(string username, string password, string host)
        {
            ServerConnection.username = username;
            ServerConnection.password = password;
            ServerConnection.host = host;
        }

        public static string loadCommand()
        {
            return psexec;
        }

    }
}
