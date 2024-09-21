using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace I_Surveillance
{
    class Variables
    {
        public static string connectionString = @"Server=HENRY\SQLEXPRESS2;Database=ISurveillance;Integrated Security=True;";
        public static DataTable dataTable = new DataTable();
        public static int count = 0, maxcount = 0;
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

        private static void addDevices(string type, string ip, string username, string password, string cameralink)
        {
            if (PingIpAddress(ip))
            {
                string query = deviceString(type);
                query = query.Replace("@ip", ip)
                             .Replace("@username", username)
                             .Replace("@password", password);

                if (query.ToLower().Contains("cameralink"))
                {
                    query = query.Replace("@cameralink", cameralink);
                }
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.ExecuteNonQuery();
                            LoadDevicesIntoDataGridView();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        if (connection.State == System.Data.ConnectionState.Open)
                        {
                            connection.Close();
                        }
                    }
                }
            }
        }

        private static string deviceString(string type)
        {
            string guid = Guid.NewGuid().ToString();
            string str = "";
            switch (type)
            {
                case "Switch":
                    str = "INSERT INTO [ISurveillance].[dbo].[Switches] ([SwitchGuid], [SwitchIP], [SwitchUsername], [SwitchPassword]) " +
                          "VALUES ('" + guid + "', '@ip', '@username', '@password');" +
                          "INSERT INTO [ISurveillance].[dbo].[Devices] ([DeviceType], [IP], [Username], [Password], [DeviceGUID]) " +
                          "VALUES ('Switch', '@ip', '@username', '@password', '" + guid + "');";
                    break;

                case "Server":
                    str = "INSERT INTO [ISurveillance].[dbo].[Servers] ([ServerGuid], [ServerIP], [ServerUsername], [ServerPassword]) " +
                          "VALUES ('" + guid + "', '@ip', '@username', '@password');" +
                          "INSERT INTO [ISurveillance].[dbo].[Devices] ([DeviceType], [IP], [Username], [Password], [DeviceGUID]) " +
                          "VALUES ('Server', '@ip', '@username', '@password', '" + guid + "');";
                    break;

                case "Router":
                    str = "INSERT INTO [ISurveillance].[dbo].[Routers] ([RouterGUID], [RouterIP], [RouterUsername], [RouterPassword]) " +
                          "VALUES ('" + guid + "', '@ip', '@username', '@password');" +
                          "INSERT INTO [ISurveillance].[dbo].[Devices] ([DeviceType], [IP], [Username], [Password], [DeviceGUID]) " +
                          "VALUES ('Router', '@ip', '@username', '@password', '" + guid + "');";
                    break;

                case "Camera":
                    str = "INSERT INTO [ISurveillance].[dbo].[Cameras] ([CameraGuid], [CameraIP], [CameraUsername], [CameraPassword], [CameraLink]) " +
                          "VALUES ('" + guid + "', '@ip', '@username', '@password', '@cameralink');" +
                          "INSERT INTO [ISurveillance].[dbo].[Devices] ([DeviceType], [IP], [Username], [Password], [DeviceGUID]) " +
                          "VALUES ('Camera', '@ip', '@username', '@password', '" + guid + "');";
                    break;

                default:
                    str = "Unknown type.";
                    break;
            }

            return str;
        }

        public static void HandleInput(string type, string IP, string username, string password, string cameralink)
        {
            string singleIpPattern = @"^\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}$";
            string rangeIpPattern = @"^(\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3})-(\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3})$";

            if (Regex.IsMatch(IP, singleIpPattern))
            {
                // Handle single IP address
                Task.Run(() => addDevices(type, IP, username, password, cameralink));
            }
            else if (Regex.IsMatch(IP, rangeIpPattern))
            {
                var match = Regex.Match(IP, rangeIpPattern);
                string startIp = match.Groups[1].Value;
                string endIp = match.Groups[2].Value;

                int startIpLastOctet = int.Parse(startIp.Split('.')[3]);
                int endIpLastOctet = int.Parse(endIp.Split('.')[3]);
                maxcount = endIpLastOctet;
                string baseIp = startIp.Substring(0, startIp.LastIndexOf('.') + 1);

                for (int i = startIpLastOctet; i <= endIpLastOctet; i++)
                {
                    string ip = baseIp + i;
                        Task.Run(() => addDevices(type, ip, username, password, cameralink));

                    count++;
                }
                count = 0;
            }
            else
            {
                MessageBox.Show("Invalid format detected.");
            }
        }

        private static bool PingIpAddress(string ipAddress)
        {
            try
            {
                using (Ping ping = new Ping())
                {
                    PingReply reply = ping.Send(ipAddress, 1000);
                    return reply.Status == IPStatus.Success;
                }
            }
            catch (PingException)
            {
                return false;
            }
        }
        public static void LoadDevicesIntoDataGridView()
        {
            string query = "SELECT [DeviceType], [IP], [Username], [Password] FROM [ISurveillance].[dbo].[Devices]";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        adapter.Fill(dataTable);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }
        }

        public static bool AuthenticateUser(string username, string password)
        {
            string query = "SELECT COUNT(1) FROM [ISurveillance].[dbo].[Users] WHERE [Username] = @Username AND [Password] = @Password";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);

                    try
                    {
                        connection.Open();

                        int count = (int)command.ExecuteScalar();

                        return count > 0;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred: {ex.Message}");
                        return false;
                    }
                }
            }
        }
    }
}
