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

namespace I_Surveillance
{
    public partial class MainForm : MaterialForm
    {
        private PerformanceCounter cpuCounter, ramCounter, diskusage, networkusage;
        private static string remoteServerIp = "", Interface;
        private Thread monitoringThread;
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;


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
            string host = "192.168.15.64";  // Replace with the actual server address
            int port = 23;                    // Telnet default port is 23
            string username = "Administrator"; // Replace with your username
            string password = "newDDSP@SSW0RD"; // Replace with your password

            TelnetClient telnetClient = new TelnetClient();
            telnetClient.LoginToTelnet(host, port, username, password);
        }
        private void addbuttonstolist()
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Variables.UserPrivilege == "Administrator")
            {
                progressbarthread();
                Variables.LoadDevicesIntoDataGridView();
            }
            else
            {
                this.tabControl1.TabPages.Remove(Devices);
            }

        }
        private void progressbarthread()
        {
            //Thread thread = new Thread(new ThreadStart(progressbarvalueupdate));
            //thread.IsBackground = true;
            //thread.Start();
        }
        private void progressbarvalueupdate()
        {

            while (true)
            {
                int count = Math.Max(0, Variables.count);

                int percentage = Variables.maxcount > 0 ? (int)((double)count / Variables.maxcount * 100) : 0;

                percentage = Math.Min(Math.Max(percentage, 0), 100);

                if (progressBar1.InvokeRequired)
                {
                    progressBar1.BeginInvoke(new Action(() =>
                    {
                        progressBar1.Value = percentage;
                        dataGridView1.DataSource = Variables.dataTable;
                    }));
                }
                else
                {
                    progressBar1.Value = percentage;
                }
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

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
        public void LoadServerNames()
        {
            string query = "SELECT [ServerIP],[ServerUsername],[ServerPassword],[DeviceName],[ServerGUID] FROM [dbo].[Servers]";
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
                    devicelistdtgview.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while retrieving server names: " + ex.Message);
            }
        }
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            LoadServerNames();
        }
        private void checkandloadserver()
        {

        }

        private void txtpowershell_TextChanged(object sender, EventArgs e)
        {

        }

        private void OpenPowerShellWithProcess()
        {
            // Create a new process
            Process powerShellProcess = new Process();

            // Configure the process
            powerShellProcess.StartInfo.FileName = "powershell.exe";
            powerShellProcess.StartInfo.Arguments = "-Command \"" + txtpowershellcommand.Text.Trim() + "\""; // Example command
            powerShellProcess.StartInfo.RedirectStandardOutput = true;
            powerShellProcess.StartInfo.RedirectStandardError = true;
            powerShellProcess.StartInfo.UseShellExecute = false;
            powerShellProcess.StartInfo.CreateNoWindow = true;

            // Start the process
            powerShellProcess.Start();

            // Capture the output
            string output = powerShellProcess.StandardOutput.ReadToEnd();
            string error = powerShellProcess.StandardError.ReadToEnd();

            // Wait for the process to finish
            powerShellProcess.WaitForExit();

            // Display the output in the txtPowerShell RichTextBox
            txtpowershellresponse.Clear();
            txtpowershellresponse.AppendText(output);

            // Optionally, display any errors (if any occurred)
            if (!string.IsNullOrWhiteSpace(error))
            {
                txtpowershellresponse.AppendText(Environment.NewLine + "Errors:" + Environment.NewLine);
                txtpowershellresponse.AppendText(error);
            }
        }

        private void StartPowerShell()
        {
            powerShellProcess = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "powershell.exe",
                    Arguments = "-NoExit -Command -",  // Keep PowerShell open
                    RedirectStandardInput = true,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                }
            };
            powerShellProcess.Start();

            powerShellInput = powerShellProcess.StandardInput;

            // Start reading the output asynchronously
            powerShellOutputThread = new Thread(ReadPowerShellOutput);
            powerShellOutputThread.Start();
        }

        private void ReadPowerShellOutput()
        {
            StreamReader outputReader = powerShellProcess.StandardOutput;

            while (!outputReader.EndOfStream)
            {
                string line = outputReader.ReadLine();
                this.Invoke(new Action(() =>
                {
                    txtpowershellresponse.AppendText(line + Environment.NewLine);
                }));
            }
        }

        private void ExecutePowerShellCommand(string command)
        {
            try
            {
                powerShellInput.WriteLine(command);
                powerShellInput.Flush();
            }
            catch
            {
                ExecutePowerShellCommand(command);
            }
 
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
        private void txtpowershell_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                // OpenPowerShellWithProcess();
                ExecutePowerShellCommand(txtpowershellcommand.Text.Trim());
            }
            if (e.Control && e.KeyCode == Keys.C)
            {
                e.SuppressKeyPress = true;
                SendCtrlC();
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.tabControl1.TabPages.Add(Devices);
        }
        public static string GetActiveNIC()
        {
            PerformanceCounterCategory category = new PerformanceCounterCategory("Network Interface");
            string[] instances = category.GetInstanceNames();

            foreach (var instance in instances)
            {
                using (PerformanceCounter bytesSentCounter = new PerformanceCounter("Network Interface", "Bytes Sent/sec", instance))
                using (PerformanceCounter bytesReceivedCounter = new PerformanceCounter("Network Interface", "Bytes Received/sec", instance))
                {
                    DateTime startTime = DateTime.Now;
                    while ((DateTime.Now - startTime).TotalSeconds < 10)
                    {
                        float bytesSent = bytesSentCounter.NextValue();
                        float bytesReceived = bytesReceivedCounter.NextValue();

                        if (bytesSent > 0 || bytesReceived > 0)
                        {
                            return instance;
                        }
                    }
                }
            }

            return null; 
        }
        public static void LoginToSsh(string host, string username, string password)
        {
            try
            {
                using (var client = new SshClient(host, username, password))
                {
                    client.Connect();

                    var result = client.RunCommand("whoami");

                    client.Disconnect();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
        private void devicelistdtgview_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (devicelistdtgview.SelectedCells.Count > 0)
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


                DataGridViewRow selectedRow = devicelistdtgview.Rows[e.RowIndex];

                var ServerIP = selectedRow.Cells["ServerIP"].Value.ToString();
                var ServerUsername = selectedRow.Cells["ServerUsername"].Value.ToString();
                var ServerPassword = selectedRow.Cells["ServerPassword"].Value.ToString();
                var ServerName = selectedRow.Cells["DeviceName"].Value.ToString();
                remoteServerIp = ServerIP;
                LoginToSsh(remoteServerIp, ServerUsername, ServerPassword);
                string activeNIC = GetActiveNIC();
                if (activeNIC != null)
                {
                    Interface = activeNIC;
                }

                cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total", remoteServerIp);
                ramCounter = new PerformanceCounter("Memory", "Available MBytes", "", remoteServerIp);
                diskusage = new PerformanceCounter("PhysicalDisk", "% Disk Time", "_Total", remoteServerIp);
                networkusage = new PerformanceCounter("Network Interface", "Bytes Sent/sec", Interface, remoteServerIp);
                if (monitoringThread != null && monitoringThread.IsAlive)
                {
                    monitoringThread.Abort();
                }
                else
                {
                    StartPowerShell();
                    monitoringThread = new Thread(CheckPerformanceMetrics);
                    monitoringThread.IsBackground = true;
                    monitoringThread.Start();
                }

            }

        }

        private void configurationgrpbx_Enter(object sender, EventArgs e)
        {

        }
        private void CheckPerformanceMetrics()
        {
            while (true)
            {
                try
                {
                    //float cpuUsage = cpuCounter.NextValue(); 
                    //float availableMemory = ramCounter.NextValue();
                    //float disk = diskusage.NextValue() * 100;
                    //float network = networkusage.NextValue() /100;

                    // CPU Usage (already a percentage)
                    float cpuUsage = cpuCounter.NextValue(); // Between 0 and 100

                    // Memory Usage (convert available memory to percentage of used memory)
                    float totalMemory = 16384; // Example: 16 GB (16384 MB)
                    float availableMemory = ramCounter.NextValue();
                    float memoryUsagePercentage = (1 - (availableMemory / totalMemory)) * 100;

                    // Disk Usage (already a percentage)
                    float diskUsage = diskusage.NextValue(); // Between 0 and 100

                    // Network Usage (convert bytes/sec to percentage of max bandwidth)
                    float maxBandwidth = 125000000; // 1 Gbps in bytes/sec
                    float networkUsage = networkusage.NextValue();
                    float networkUsagePercentage = (networkUsage / maxBandwidth) * 100;
                    networkUsagePercentage *= 1000;
                    // Clamp the values between 0 and 100 to avoid ArgumentOutOfRangeException
                    cpuUsage = (float)Math.Round(Math.Min(100, Math.Max(0, cpuUsage)), 2);
                    memoryUsagePercentage = (float)Math.Round(Math.Min(100, Math.Max(0, memoryUsagePercentage)), 2);
                    diskUsage = (float)Math.Round(Math.Min(100, Math.Max(0, diskUsage)), 2);
                    networkUsagePercentage = (float)Math.Round(Math.Min(100, Math.Max(0, networkUsagePercentage)), 2);


                    // Invoke the UI update on the main thread
                    this.BeginInvoke(new Action(() =>
                    {
                        cpuusageprogressbar.Value = Convert.ToInt32(cpuUsage); cpulbl.Text = cpuUsage.ToString();
                        memoryusageprogressbar.Value = Convert.ToInt32(memoryUsagePercentage); ramlbl.Text = memoryUsagePercentage.ToString();
                        diskusageprogressbar.Value = Convert.ToInt32(diskUsage); disklbl.Text = diskUsage.ToString();
                        networkusageprogressbar.Value = Convert.ToInt32(networkUsagePercentage); netlbl.Text = networkUsagePercentage.ToString();
                    }));


                    // Sleep for a short period before checking again (e.g., every second)
                    Thread.Sleep(1000);
                }
                catch (Exception ex)
                {
                    // Handle any exceptions, e.g., display a message or log
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        // Update the progress bar and change color if needed
        private void UpdateProgressBar(ProgressBar progressBar, float value)
        {
            // Ensure value is within bounds
            int progressValue = (int)Math.Min(10, Math.Max(0, value));
            progressBar.Value = progressValue;

            // Change color if value exceeds 9/10 or 90%
            if (progressValue >= 9)
            {
                // Change color to red
                progressBar.ForeColor = Color.Red;
            }
            else
            {
                // Change color to default (e.g., green or system default)
                progressBar.ForeColor = Color.Green;
            }
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
