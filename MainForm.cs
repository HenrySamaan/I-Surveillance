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


namespace I_Surveillance
{
    public partial class MainForm : Form
    {
        private PerformanceCounter cpuCounter, ramCounter, diskusage, networkusage;
        private static string remoteServerIp = "", Interface;
        private Thread monitoringThread;

        public MainForm()
        {
            InitializeComponent();
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
            Thread thread = new Thread(new ThreadStart(progressbarvalueupdate));
            thread.IsBackground = true;
            thread.Start();
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
        private void txtpowershell_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                OpenPowerShellWithProcess();
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
        private void devicelistdtgview_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (devicelistdtgview.SelectedCells.Count > 0)
            {

                DataGridViewRow selectedRow = devicelistdtgview.Rows[e.RowIndex];

                var ServerIP = selectedRow.Cells["ServerIP"].Value.ToString();
                var ServerUsername = selectedRow.Cells["ServerUsername"].Value.ToString();
                var ServerPassword = selectedRow.Cells["ServerPassword"].Value.ToString();
                var ServerName = selectedRow.Cells["DeviceName"].Value.ToString();
                remoteServerIp = ServerIP;

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
                    float cpuUsage = cpuCounter.NextValue(); 
                    float availableMemory = ramCounter.NextValue();
                    float disk = diskusage.NextValue() * 100;
                    float network = networkusage.NextValue() /100;

                    // Invoke the UI update on the main thread
                    this.BeginInvoke(new Action(() =>
                    {
                        cpuusageprogressbar.Value = Convert.ToInt32(cpuUsage);
                        memoryusageprogressbar.Value = Convert.ToInt32(availableMemory);
                        diskusageprogressbar.Value = Convert.ToInt32(disk);
                        networkusageprogressbar.Value = Convert.ToInt32(network);
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
