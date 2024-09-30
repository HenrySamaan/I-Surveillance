using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using System.IO;
using System.Runtime.InteropServices;
using Renci.SshNet;
using Microsoft.Web.WebView2.WinForms;

namespace I_Surveillance
{
    public partial class MainForm : MaterialForm
    {
        private PerformanceCounter cpuCounter, ramCounter, diskusage, networkusage;
        private static string remoteServerIp = "", Interface;
        private Thread monitoringThread;
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        private static string ip = "", username = "", password = "";

        private Process powerShellProcess;
        private StreamWriter powerShellInput;
        private Thread powerShellOutputThread;

        public MainForm()
        {
            InitializeComponent();
            //materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            //materialSkinManager.EnforceBackcolorOnAllComponents = true;
            //materialSkinManager.AddFormToManage(this);
            //materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            ////materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.FromArgb(160, 14, 101));
            //materialSkinManager.ColorScheme = new ColorScheme(
            //    Primary.Pink800,           // Choose a predefined primary color (closest to rgb(160, 14, 101))
            //    Primary.Pink900,           // Dark primary
            //    Primary.Pink400,           // Light primary
            //    Accent.Pink200,            // Accent color
            //    TextShade.WHITE            // Text shade
            //);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Variables.UserPrivilege == "Administrator")
            {
                Variables.LoadDevicesIntoDataGridView();
            }
            else
            {
                this.tabControl1.TabPages.Remove(Devices);
            }

        }


        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        #region Adding Devices to DB
        private void addcamera_Click(object sender, EventArgs e)
        {
            if (!Variables.checkifbuttonchecked())
            {
                Variables.cameraAddForm = new CameraAddForm();
                Variables.cameraAddForm.Show();
                Variables.checkedbuttons.Add(Variables.buttonclicked);
            }
        }

        private void addserver_Click(object sender, EventArgs e)
        {
            if (!Variables.checkifbuttonchecked())
            {
                Variables.addServerForm = new AddServerForm();
                Variables.addServerForm.Show();
                Variables.checkedbuttons.Add(Variables.buttonclicked);
            }
        }

        private void addswitch_Click(object sender, EventArgs e)
        {
            if (!Variables.checkifbuttonchecked())
            {
                Variables.addSwitchForm = new AddSwitchForm();
                Variables.addSwitchForm.Show();
                Variables.checkedbuttons.Add(Variables.buttonclicked);
            }
        }

        private void addrouter_Click(object sender, EventArgs e)
        {
            if (!Variables.checkifbuttonchecked())
            {
                Variables.addRouterForm = new AddRouter();
                Variables.addRouterForm.Show();
                Variables.checkedbuttons.Add(Variables.buttonclicked);
            }
        }

        #endregion
        public void LoadDevicesNames(string devicetype)
        {
            string query = $"SELECT [DeviceGUID], [DeviceName], [DeviceType] FROM [ISurveillance].[dbo].[devices] where DeviceType like '{devicetype}'";
            DataTable dataTable = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(Variables.connectionString))
                {
                    connection.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        adapter.Fill(dataTable);
                    }
                    serverlistdtgview.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while retrieving server names: " + ex.Message);
            }
        }
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
                LoadDevicesNames(e.Node.Text.ToLower().Substring(0, e.Node.Text.ToLower().Length - 1));
        }
        private void openServerMonitor()
        {

        }
        private void openCameraMonitor()
        {

        }
        private void openSwitchMonitor()
        {

        }
        private void openRouterMonitor()
        {

        }


        private void txtpowershell_TextChanged(object sender, EventArgs e)
        {

        }

        private void SendCtrlC()
        {
            if (powerShellProcess != null && !powerShellProcess.HasExited)
            {
                // Simulate sending Ctrl+C to the PowerShell process
                GenerateCtrlC();
            }
        }

        private void GenerateCtrlC()
        {
            // Sending Ctrl+C signal to the PowerShell process
            IntPtr handle = powerShellProcess.MainWindowHandle;
            if (handle != IntPtr.Zero)
            {
                SendMessage(handle, WM_COPYDATA, IntPtr.Zero, IntPtr.Zero);
            }
        }

        [DllImport("user32.dll", SetLastError = true)]
        private static extern IntPtr SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);

        private const int WM_COPYDATA = 0x004A;

        private void fullscreenbtn_Click(object sender, EventArgs e)
        {
            FullScreen fullScreen = new FullScreen(this);
            fullScreen.FormClosed += (s, e) => fullScreen.Dispose();
            fullScreen.AddControlToPanel(deviceaccessgrpbx);
            initializeWebView(fullScreen.fullscreenpanel, ip, username, password);
            fullScreen.Show();
        }

        private void pasteusernamebtn_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(username);

                SendKeys.Send("^v");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error pasting value: " + ex.Message);
            }
        }

        private void pastepasswordbtn_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(password);

                SendKeys.Send("^v");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error pasting value: " + ex.Message);
            }
        }

        private void minimizebtn_Click(object sender, EventArgs e)
        {
            initializeWebView(this.deviceaccessgrpbx, ip, username, password);
        }

        public void returntonormal()
        {
            initializeWebView(this.deviceaccessgrpbx, ip, username, password);
        }
        public void initializeWebView(Control control, string address, string username, string password)
        {
            WebView2 webView = new WebView2
            {
                Dock = DockStyle.Fill
            };

            control.Controls.Add(webView);
            string url = @$"https://{address}/";
            webView.Source = new Uri(url);
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.tabControl1.TabPages.Add(Devices);
        }
        public void GetDeviceInfo(string deviceGUID, string deviceType)
        {
            // Local variables to store the returned values
            //string ip = string.Empty;
            //string username = string.Empty;
            //string password = string.Empty;
            string deviceName = string.Empty;

            // Specific variables for each table type
            string switchGUID = string.Empty;
            string serverGUID = string.Empty;
            string routerGUID = string.Empty;
            string cameraGUID = string.Empty;
            string cameraLink = string.Empty;
            string deviceTypeReturned = string.Empty; // For devices table


            using (SqlConnection connection = new SqlConnection(Variables.connectionString))
            {
                connection.Open();

                // Create the SQL command
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = @"
                    IF @DeviceType = 'Switch'
                    BEGIN
                        SELECT [SwitchIP] AS [IP], [SwitchUsername] AS [Username], [SwitchPassword] AS [Password], [SwitchGUID], [DeviceName]
                        FROM [ISurveillance].[dbo].[Switches]
                        WHERE [SwitchGUID] = @DeviceGUID;
                    END
                    ELSE IF @DeviceType = 'Server'
                    BEGIN
                        SELECT [ServerIP] AS [IP], [ServerUsername] AS [Username], [ServerPassword] AS [Password], [ServerGUID], [DeviceName]
                        FROM [ISurveillance].[dbo].[Servers]
                        WHERE [ServerGUID] = @DeviceGUID;
                    END
                    ELSE IF @DeviceType = 'Router'
                    BEGIN
                        SELECT [RouterIP] AS [IP], [RouterUsername] AS [Username], [RouterPassword] AS [Password], [RouterGUID], [DeviceName]
                        FROM [ISurveillance].[dbo].[Routers]
                        WHERE [RouterGUID] = @DeviceGUID;
                    END
                    ELSE IF @DeviceType = 'Camera'
                    BEGIN
                        SELECT [CameraIP] AS [IP], [CameraUsername] AS [Username], [CameraPassword] AS [Password], [CameraLink], [CameraGuid], [DeviceName]
                        FROM [ISurveillance].[dbo].[Cameras]
                        WHERE [CameraGuid] = @DeviceGUID;
                    END
                    ELSE
                    BEGIN
                        SELECT [IP], [Username], [Password], [DeviceGUID], [DeviceName], [DeviceType]
                        FROM [ISurveillance].[dbo].[devices]
                        WHERE [DeviceGUID] = @DeviceGUID;
                    END";

                    // Add parameters
                    command.Parameters.AddWithValue("@DeviceGUID", deviceGUID);
                    command.Parameters.AddWithValue("@DeviceType", deviceType);

                    // Execute the query
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            ip = reader["IP"]?.ToString() ?? string.Empty;
                            username = reader["Username"]?.ToString() ?? string.Empty;
                            password = reader["Password"]?.ToString() ?? string.Empty;
                            deviceName = reader["DeviceName"]?.ToString() ?? string.Empty;
                            if (!string.IsNullOrEmpty(username))
                            {
                                pasteusernamebtn.ForeColor = Color.Green;
                            }
                            if (!string.IsNullOrEmpty(password))
                            {
                                pastepasswordbtn.ForeColor = Color.Green;
                            }

                            if (deviceType == "Switch")
                            {
                                switchGUID = reader["SwitchGUID"]?.ToString() ?? string.Empty;
                                initializeWebView(this.deviceaccessgrpbx, ip, username, password);
                            }
                            else if (deviceType == "Server")
                            {
                                serverGUID = reader["ServerGUID"]?.ToString() ?? string.Empty;
                                ServerConnection.loadserverscontrol(username, password, ip);
                                return;
                            }
                            else if (deviceType == "Router")
                            {
                                routerGUID = reader["RouterGUID"]?.ToString() ?? string.Empty;
                                initializeWebView(this.deviceaccessgrpbx, ip, username, password);
                                return;
                            }
                            else if (deviceType == "Camera")
                            {
                                cameraGUID = reader["CameraGuid"]?.ToString() ?? string.Empty;
                                cameraLink = reader["CameraLink"]?.ToString() ?? string.Empty;
                                initializeWebView(this.deviceaccessgrpbx, ip, username, password);
                                return;
                            }
                            else
                            {
                                deviceTypeReturned = reader["DeviceType"]?.ToString() ?? string.Empty;
                                return;
                            }
                        }
                    }
                }
            }
        }

        private void devicelistdtgview_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (serverlistdtgview.SelectedCells.Count > 0)
            {
                if (powerShellProcess != null && !powerShellProcess.HasExited)
                {
                    powerShellInput.Close();

                    powerShellProcess.WaitForExit(1000); // Wait for 1 second

                    if (!powerShellProcess.HasExited)
                    {
                        powerShellProcess.Kill();
                    }

                    powerShellProcess.Dispose();
                }


                DataGridViewRow selectedRow = serverlistdtgview.Rows[e.RowIndex];
                var deviceguid = selectedRow.Cells["DeviceGUID"].Value.ToString();
                var devicetype = selectedRow.Cells["DevicType"].Value.ToString();
                GetDeviceInfo(deviceguid, devicetype);

            }

        }

        private void configurationgrpbx_Enter(object sender, EventArgs e)
        {

        }
        // Clean up the thread when closing the form
        //protected override void OnFormClosing(FormClosingEventArgs e)
        //{
        //    base.OnFormClosing(e);
        //    if (monitoringThread != null && monitoringThread.IsAlive)
        //    {
        //        monitoringThread.Abort(); // Stop the background thread
        //    }
        //}
    }
}
