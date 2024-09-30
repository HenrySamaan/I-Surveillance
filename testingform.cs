using Microsoft.Web.WebView2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MSTSCLib;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace I_Surveillance
{
    public partial class testingform : Form
    {
        private DateTime lastClickTime;
        private const int doubleClickThreshold = 300;
       public string CamIP, CamUsername, CamPassword;
        // Import necessary Win32 API functions
        [DllImport("user32.dll")]
        private static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

        [DllImport("user32.dll")]
        private static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

        [DllImport("user32.dll")]
        private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        private const uint SWP_NOZORDER = 0x0004;
        private const uint SWP_SHOWWINDOW = 0x0040;
        public testingform()
        {
            InitializeComponent();

            LoadCameraData();
            StartRdpSession("192.168.15.231", "admin", "6SS@Charbel#Pass");
            EmbedRDPWindow();
        }
        private void EmbedRDPWindow()
        {
            IntPtr rdpWindowHandle = FindWindow("TscShellContainerClass", null);

            // Check if the window handle is valid
            if (rdpWindowHandle != IntPtr.Zero)
            {
                // Set the parent of the RDP window to the panel
                SetParent(rdpWindowHandle, serverpanel.Handle);

                // Resize and reposition the embedded RDP window
                SetWindowPos(rdpWindowHandle, IntPtr.Zero, 0, 0, serverpanel.Width, serverpanel.Height, SWP_NOZORDER | SWP_SHOWWINDOW);
            }
            else
            {
                EmbedRDPWindow();
            }
        }

        private void StartRdpSession(string serverIP, string username, string password)
        {
            try
            {
                System.Diagnostics.Process cmdKeyProcess = new System.Diagnostics.Process();
                cmdKeyProcess.StartInfo.FileName = "cmd.exe";
                cmdKeyProcess.StartInfo.Arguments = $"/C cmdkey /generic:TERMSRV/{serverIP} /user:{username} /pass:{password}";
                cmdKeyProcess.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                cmdKeyProcess.Start();
                cmdKeyProcess.WaitForExit();

                System.Diagnostics.Process rdpProcess = new System.Diagnostics.Process();
                rdpProcess.StartInfo.FileName = "mstsc";
                rdpProcess.StartInfo.Arguments = $"/v:{serverIP} /f";
                rdpProcess.Start();
                EmbedRDPWindow();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to RDP: " + ex.Message);
            }
        }

        private void PasteValueIntoTextBox(string value)
        {
            try
            {
                Clipboard.SetText(value);

                SendKeys.Send("^v");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error pasting value: " + ex.Message);
            }
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
        public void LoadCameraData()
        {
            // Connection string - update with your actual database connection details

            // SQL query to retrieve all data from the Cameras table
            string query = @"
        SELECT [CameraGuid]
              ,[CameraIP]
              ,[CameraUsername]
              ,[CameraPassword]
              ,[CameraLink]
              ,[DeviceName]
          FROM [ISurveillance].[dbo].[Cameras]";

            // Using block to ensure proper disposal of resources
            using (SqlConnection connection = new SqlConnection(Variables.connectionString))
            {
                try
                {
                    // Open the connection
                    connection.Open();

                    // SqlDataAdapter is used to retrieve data from the database
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                    // DataTable to hold the retrieved data
                    DataTable dataTable = new DataTable();

                    // Fill the DataTable with data
                    adapter.Fill(dataTable);

                    // Bind the DataTable to the DataGridView
                    camerasdtgv.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    // Show any errors that occur during database operations
                    MessageBox.Show("Error retrieving camera data: " + ex.Message);
                }
            }
        }

        private void camerasdtgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           // cameraaccessgrpbx.Clea
            if (camerasdtgv.SelectedCells.Count > 0)
            {

                DataGridViewRow selectedRow = camerasdtgv.Rows[e.RowIndex];

                var CameraGuid = selectedRow.Cells["CameraGuid"].Value.ToString();
                var CameraIP = selectedRow.Cells["CameraIP"].Value.ToString();
                var CameraUsername = selectedRow.Cells["CameraUsername"].Value.ToString();
                var CameraPassword = selectedRow.Cells["CameraPassword"].Value.ToString();
                var CameraLink = selectedRow.Cells["CameraLink"].Value.ToString();
                var DeviceName = selectedRow.Cells["DeviceName"].Value.ToString();
                initializeWebView(cameraaccessgrpbx,CameraIP, CameraUsername, CameraPassword);
                this.CamIP = CameraIP.ToString();
                this.CamUsername = CameraUsername.ToString();
                this.CamPassword = CameraPassword.ToString();

            }
        }


        private void camerasdtgv_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
         {

            if (camerasdtgv.SelectedCells.Count > 0)
            {
                DataGridViewRow selectedRow = camerasdtgv.Rows[e.RowIndex];

                var CameraGuid = selectedRow.Cells["CameraGuid"].Value.ToString();
                var CameraIP = selectedRow.Cells["CameraIP"].Value.ToString();
                var CameraUsername = selectedRow.Cells["CameraUsername"].Value.ToString();
                var CameraPassword = selectedRow.Cells["CameraPassword"].Value.ToString();
                var CameraLink = selectedRow.Cells["CameraLink"].Value.ToString();
                var DeviceName = selectedRow.Cells["DeviceName"].Value.ToString();
                initializeWebView(cameraaccessgrpbx,CameraIP, CameraUsername, CameraPassword);
                this.CamIP = CameraIP.ToString();
                this.CamUsername = CameraUsername.ToString();
                this.CamPassword = CameraPassword.ToString();
            }
        }

        private void webviewbtn_Click(object sender, EventArgs e)
        {
            livecameragrpbx.Visible = false;
            cameramonitoringpanel.SetColumnSpan(cameraaccessgrpbx, 4);
        }

        private void returnbtn_Click(object sender, EventArgs e)
        {
            returnviews();
        }
        public void returnviews()
        {
            livecameragrpbx.Visible = true;
            cameraaccessgrpbx.Visible = true;
            cameramonitoringpanel.Controls.Add(cameraaccessgrpbx, 0, 0);
            cameramonitoringpanel.SetColumn(cameraaccessgrpbx, 0);
            cameramonitoringpanel.SetColumnSpan(cameraaccessgrpbx, 2);

            cameramonitoringpanel.Controls.Add(livecameragrpbx, 2, 0);
            cameramonitoringpanel.SetColumn(livecameragrpbx, 2);
            cameramonitoringpanel.SetColumnSpan(livecameragrpbx, 2);
        }

        private void livebtn_Click(object sender, EventArgs e)
        {
            cameraaccessgrpbx.Visible = false;
            cameramonitoringpanel.SetColumn(livecameragrpbx, 0);
            cameramonitoringpanel.SetColumnSpan(livecameragrpbx, 4);
        }

        private void webviewbtn_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                DateTime now = DateTime.Now;
                if ((now - lastClickTime).TotalMilliseconds <= doubleClickThreshold)
                {
                    //FullScreen fullScreen = new FullScreen(MainForm);
                    //fullScreen.FormClosed += (s, e) => fullScreen.Dispose();
                    //fullScreen.AddControlToPanel(cameraaccessgrpbx);
                    //initializeWebView(fullScreen.fullscreenpanel, CamIP, CamUsername, CamPassword);
                    //fullScreen.Show();

                }
                lastClickTime = now;
            }
        }
    }
}
