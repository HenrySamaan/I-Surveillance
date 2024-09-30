
namespace I_Surveillance
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Servers");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Cameras");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Switches");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Routers");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Network Devices", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Devices = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DeviceType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.addcamera = new System.Windows.Forms.Button();
            this.addserver = new System.Windows.Forms.Button();
            this.addswitch = new System.Windows.Forms.Button();
            this.addrouter = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.Monitoring = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.devicemonitoringgrpbx = new System.Windows.Forms.GroupBox();
            this.CameraPanel = new System.Windows.Forms.Panel();
            this.cameramonitoringpanel = new System.Windows.Forms.TableLayoutPanel();
            this.minimizebtn = new System.Windows.Forms.Button();
            this.pasteusernamebtn = new System.Windows.Forms.Button();
            this.deviceaccessgrpbx = new System.Windows.Forms.GroupBox();
            this.fullscreenbtn = new System.Windows.Forms.Button();
            this.pastepasswordbtn = new System.Windows.Forms.Button();
            this.devicetypegrpbx = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.devicelistgrpbx = new System.Windows.Forms.GroupBox();
            this.serverspanel = new System.Windows.Forms.Panel();
            this.serverlistdtgview = new System.Windows.Forms.DataGridView();
            this.DeviceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeviceGUID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DevicType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Configuration = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1.SuspendLayout();
            this.Devices.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.Monitoring.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.devicemonitoringgrpbx.SuspendLayout();
            this.CameraPanel.SuspendLayout();
            this.cameramonitoringpanel.SuspendLayout();
            this.devicetypegrpbx.SuspendLayout();
            this.panel1.SuspendLayout();
            this.devicelistgrpbx.SuspendLayout();
            this.serverspanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serverlistdtgview)).BeginInit();
            this.Configuration.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Devices);
            this.tabControl1.Controls.Add(this.Monitoring);
            this.tabControl1.Controls.Add(this.Configuration);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 64);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1077, 658);
            this.tabControl1.TabIndex = 0;
            // 
            // Devices
            // 
            this.Devices.BackColor = System.Drawing.Color.Transparent;
            this.Devices.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Devices.Controls.Add(this.tableLayoutPanel1);
            this.Devices.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Devices.Location = new System.Drawing.Point(4, 24);
            this.Devices.Name = "Devices";
            this.Devices.Padding = new System.Windows.Forms.Padding(3);
            this.Devices.Size = new System.Drawing.Size(1069, 630);
            this.Devices.TabIndex = 0;
            this.Devices.Text = "Devices";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.076175F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.92383F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1059, 620);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 54);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1053, 511);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DeviceType,
            this.IP,
            this.Username,
            this.Password});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Highlight;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1047, 505);
            this.dataGridView1.TabIndex = 0;
            // 
            // DeviceType
            // 
            this.DeviceType.DataPropertyName = "DeviceType";
            this.DeviceType.HeaderText = "Device Type";
            this.DeviceType.Name = "DeviceType";
            this.DeviceType.ReadOnly = true;
            // 
            // IP
            // 
            this.IP.DataPropertyName = "IP";
            this.IP.HeaderText = "IP";
            this.IP.Name = "IP";
            this.IP.ReadOnly = true;
            // 
            // Username
            // 
            this.Username.DataPropertyName = "Username";
            this.Username.HeaderText = "Username";
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            // 
            // Password
            // 
            this.Password.DataPropertyName = "Password";
            this.Password.HeaderText = "Password";
            this.Password.Name = "Password";
            this.Password.ReadOnly = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.99876F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00041F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00041F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00041F));
            this.tableLayoutPanel3.Controls.Add(this.addcamera, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.addserver, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.addswitch, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.addrouter, 3, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1053, 45);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // addcamera
            // 
            this.addcamera.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addcamera.Location = new System.Drawing.Point(58, 10);
            this.addcamera.Name = "addcamera";
            this.addcamera.Size = new System.Drawing.Size(147, 25);
            this.addcamera.TabIndex = 7;
            this.addcamera.Text = "Add Camera";
            this.addcamera.UseVisualStyleBackColor = true;
            this.addcamera.Click += new System.EventHandler(this.addcamera_Click);
            // 
            // addserver
            // 
            this.addserver.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addserver.Location = new System.Drawing.Point(322, 10);
            this.addserver.Name = "addserver";
            this.addserver.Size = new System.Drawing.Size(144, 25);
            this.addserver.TabIndex = 8;
            this.addserver.Text = "Add Server";
            this.addserver.UseVisualStyleBackColor = true;
            this.addserver.Click += new System.EventHandler(this.addserver_Click);
            // 
            // addswitch
            // 
            this.addswitch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addswitch.Location = new System.Drawing.Point(587, 10);
            this.addswitch.Name = "addswitch";
            this.addswitch.Size = new System.Drawing.Size(140, 25);
            this.addswitch.TabIndex = 9;
            this.addswitch.Text = "Add Switch";
            this.addswitch.UseVisualStyleBackColor = true;
            this.addswitch.Click += new System.EventHandler(this.addswitch_Click);
            // 
            // addrouter
            // 
            this.addrouter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addrouter.Location = new System.Drawing.Point(849, 10);
            this.addrouter.Name = "addrouter";
            this.addrouter.Size = new System.Drawing.Size(144, 25);
            this.addrouter.TabIndex = 10;
            this.addrouter.Text = "Add Router";
            this.addrouter.UseVisualStyleBackColor = true;
            this.addrouter.Click += new System.EventHandler(this.addrouter_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.66383F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.33617F));
            this.tableLayoutPanel4.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.progressBar1, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 571);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1053, 46);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(918, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Network Devices\r\n";
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar1.Location = new System.Drawing.Point(3, 3);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(874, 40);
            this.progressBar1.TabIndex = 8;
            // 
            // Monitoring
            // 
            this.Monitoring.Controls.Add(this.tableLayoutPanel5);
            this.Monitoring.Location = new System.Drawing.Point(4, 24);
            this.Monitoring.Name = "Monitoring";
            this.Monitoring.Padding = new System.Windows.Forms.Padding(3);
            this.Monitoring.Size = new System.Drawing.Size(1069, 630);
            this.Monitoring.TabIndex = 1;
            this.Monitoring.Text = "Monitoring";
            this.Monitoring.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 209F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 671F));
            this.tableLayoutPanel5.Controls.Add(this.devicemonitoringgrpbx, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.devicetypegrpbx, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.devicelistgrpbx, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(1063, 624);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // devicemonitoringgrpbx
            // 
            this.devicemonitoringgrpbx.Controls.Add(this.CameraPanel);
            this.devicemonitoringgrpbx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.devicemonitoringgrpbx.Location = new System.Drawing.Point(395, 3);
            this.devicemonitoringgrpbx.Name = "devicemonitoringgrpbx";
            this.devicemonitoringgrpbx.Size = new System.Drawing.Size(665, 618);
            this.devicemonitoringgrpbx.TabIndex = 1;
            this.devicemonitoringgrpbx.TabStop = false;
            this.devicemonitoringgrpbx.Text = "Device Monitoring";
            // 
            // CameraPanel
            // 
            this.CameraPanel.Controls.Add(this.cameramonitoringpanel);
            this.CameraPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CameraPanel.Location = new System.Drawing.Point(3, 19);
            this.CameraPanel.Name = "CameraPanel";
            this.CameraPanel.Size = new System.Drawing.Size(659, 596);
            this.CameraPanel.TabIndex = 1;
            // 
            // cameramonitoringpanel
            // 
            this.cameramonitoringpanel.ColumnCount = 4;
            this.cameramonitoringpanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.cameramonitoringpanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.cameramonitoringpanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.cameramonitoringpanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.cameramonitoringpanel.Controls.Add(this.minimizebtn, 0, 1);
            this.cameramonitoringpanel.Controls.Add(this.pasteusernamebtn, 1, 1);
            this.cameramonitoringpanel.Controls.Add(this.deviceaccessgrpbx, 0, 0);
            this.cameramonitoringpanel.Controls.Add(this.fullscreenbtn, 0, 1);
            this.cameramonitoringpanel.Controls.Add(this.pastepasswordbtn, 3, 1);
            this.cameramonitoringpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cameramonitoringpanel.Location = new System.Drawing.Point(0, 0);
            this.cameramonitoringpanel.Name = "cameramonitoringpanel";
            this.cameramonitoringpanel.RowCount = 2;
            this.cameramonitoringpanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 95F));
            this.cameramonitoringpanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.cameramonitoringpanel.Size = new System.Drawing.Size(659, 596);
            this.cameramonitoringpanel.TabIndex = 0;
            // 
            // minimizebtn
            // 
            this.minimizebtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.minimizebtn.Location = new System.Drawing.Point(167, 569);
            this.minimizebtn.Name = "minimizebtn";
            this.minimizebtn.Size = new System.Drawing.Size(158, 24);
            this.minimizebtn.TabIndex = 6;
            this.minimizebtn.Text = "Minimize";
            this.minimizebtn.UseVisualStyleBackColor = true;
            // 
            // pasteusernamebtn
            // 
            this.pasteusernamebtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pasteusernamebtn.Location = new System.Drawing.Point(331, 569);
            this.pasteusernamebtn.Name = "pasteusernamebtn";
            this.pasteusernamebtn.Size = new System.Drawing.Size(158, 24);
            this.pasteusernamebtn.TabIndex = 4;
            this.pasteusernamebtn.Text = "Username";
            this.pasteusernamebtn.UseVisualStyleBackColor = true;
            // 
            // deviceaccessgrpbx
            // 
            this.cameramonitoringpanel.SetColumnSpan(this.deviceaccessgrpbx, 4);
            this.deviceaccessgrpbx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deviceaccessgrpbx.Location = new System.Drawing.Point(3, 3);
            this.deviceaccessgrpbx.Name = "deviceaccessgrpbx";
            this.deviceaccessgrpbx.Size = new System.Drawing.Size(653, 560);
            this.deviceaccessgrpbx.TabIndex = 2;
            this.deviceaccessgrpbx.TabStop = false;
            this.deviceaccessgrpbx.Text = "Device Access";
            // 
            // fullscreenbtn
            // 
            this.fullscreenbtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fullscreenbtn.Location = new System.Drawing.Point(3, 569);
            this.fullscreenbtn.Name = "fullscreenbtn";
            this.fullscreenbtn.Size = new System.Drawing.Size(158, 24);
            this.fullscreenbtn.TabIndex = 3;
            this.fullscreenbtn.Text = "Maximize";
            this.fullscreenbtn.UseVisualStyleBackColor = true;
            this.fullscreenbtn.Click += new System.EventHandler(this.fullscreenbtn_Click);
            // 
            // pastepasswordbtn
            // 
            this.pastepasswordbtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pastepasswordbtn.Location = new System.Drawing.Point(495, 569);
            this.pastepasswordbtn.Name = "pastepasswordbtn";
            this.pastepasswordbtn.Size = new System.Drawing.Size(161, 24);
            this.pastepasswordbtn.TabIndex = 5;
            this.pastepasswordbtn.Text = "Password";
            this.pastepasswordbtn.UseVisualStyleBackColor = true;
            this.pastepasswordbtn.Click += new System.EventHandler(this.pastepasswordbtn_Click);
            // 
            // devicetypegrpbx
            // 
            this.devicetypegrpbx.Controls.Add(this.panel1);
            this.devicetypegrpbx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.devicetypegrpbx.Location = new System.Drawing.Point(3, 3);
            this.devicetypegrpbx.Name = "devicetypegrpbx";
            this.devicetypegrpbx.Size = new System.Drawing.Size(177, 618);
            this.devicetypegrpbx.TabIndex = 0;
            this.devicetypegrpbx.TabStop = false;
            this.devicetypegrpbx.Text = "Device Type";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.treeView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(171, 596);
            this.panel1.TabIndex = 0;
            // 
            // treeView1
            // 
            this.treeView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode1.ForeColor = System.Drawing.Color.Navy;
            treeNode1.Name = "serversnode";
            treeNode1.Text = "Servers";
            treeNode2.ForeColor = System.Drawing.Color.Navy;
            treeNode2.Name = "camerasnode";
            treeNode2.Text = "Cameras";
            treeNode3.ForeColor = System.Drawing.Color.Navy;
            treeNode3.Name = "switchnode";
            treeNode3.Text = "Switches";
            treeNode4.ForeColor = System.Drawing.Color.Navy;
            treeNode4.Name = "routersnode";
            treeNode4.Text = "Routers";
            treeNode5.ForeColor = System.Drawing.Color.Blue;
            treeNode5.Name = "Node0";
            treeNode5.Text = "Network Devices";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5});
            this.treeView1.Size = new System.Drawing.Size(171, 596);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // devicelistgrpbx
            // 
            this.devicelistgrpbx.Controls.Add(this.serverspanel);
            this.devicelistgrpbx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.devicelistgrpbx.Location = new System.Drawing.Point(186, 3);
            this.devicelistgrpbx.Name = "devicelistgrpbx";
            this.devicelistgrpbx.Size = new System.Drawing.Size(203, 618);
            this.devicelistgrpbx.TabIndex = 1;
            this.devicelistgrpbx.TabStop = false;
            this.devicelistgrpbx.Text = "Device List";
            // 
            // serverspanel
            // 
            this.serverspanel.Controls.Add(this.serverlistdtgview);
            this.serverspanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.serverspanel.Location = new System.Drawing.Point(3, 19);
            this.serverspanel.Name = "serverspanel";
            this.serverspanel.Size = new System.Drawing.Size(197, 596);
            this.serverspanel.TabIndex = 0;
            // 
            // serverlistdtgview
            // 
            this.serverlistdtgview.AllowUserToAddRows = false;
            this.serverlistdtgview.AllowUserToDeleteRows = false;
            this.serverlistdtgview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.serverlistdtgview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.serverlistdtgview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.serverlistdtgview.ColumnHeadersVisible = false;
            this.serverlistdtgview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DeviceName,
            this.DeviceGUID,
            this.DevicType});
            this.serverlistdtgview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.serverlistdtgview.EnableHeadersVisualStyles = false;
            this.serverlistdtgview.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.serverlistdtgview.Location = new System.Drawing.Point(0, 0);
            this.serverlistdtgview.Name = "serverlistdtgview";
            this.serverlistdtgview.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.serverlistdtgview.RowHeadersVisible = false;
            this.serverlistdtgview.RowTemplate.Height = 25;
            this.serverlistdtgview.Size = new System.Drawing.Size(197, 596);
            this.serverlistdtgview.TabIndex = 0;
            this.serverlistdtgview.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.devicelistdtgview_CellContentDoubleClick);
            // 
            // DeviceName
            // 
            this.DeviceName.DataPropertyName = "DeviceName";
            this.DeviceName.HeaderText = "DeviceName";
            this.DeviceName.Name = "DeviceName";
            this.DeviceName.ReadOnly = true;
            this.DeviceName.Visible = false;
            // 
            // DeviceGUID
            // 
            this.DeviceGUID.DataPropertyName = "DeviceGUID";
            this.DeviceGUID.HeaderText = "DeviceGUID";
            this.DeviceGUID.Name = "DeviceGUID";
            this.DeviceGUID.ReadOnly = true;
            this.DeviceGUID.Visible = false;
            // 
            // DevicType
            // 
            this.DevicType.DataPropertyName = "DeviceType";
            this.DevicType.HeaderText = "DeviceType";
            this.DevicType.Name = "DevicType";
            this.DevicType.ReadOnly = true;
            this.DevicType.Visible = false;
            // 
            // Configuration
            // 
            this.Configuration.Controls.Add(this.tableLayoutPanel8);
            this.Configuration.Location = new System.Drawing.Point(4, 24);
            this.Configuration.Name = "Configuration";
            this.Configuration.Padding = new System.Windows.Forms.Padding(3);
            this.Configuration.Size = new System.Drawing.Size(1069, 630);
            this.Configuration.TabIndex = 2;
            this.Configuration.Text = "Configuration";
            this.Configuration.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 2;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel8.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(1063, 624);
            this.tableLayoutPanel8.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(534, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(526, 618);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "IIS Configuration";
            // 
            // groupBox1
            // 
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(525, 618);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SQL Configuration";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 725);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "I-Surveillance";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.Devices.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.Monitoring.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.devicemonitoringgrpbx.ResumeLayout(false);
            this.CameraPanel.ResumeLayout(false);
            this.cameramonitoringpanel.ResumeLayout(false);
            this.devicetypegrpbx.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.devicelistgrpbx.ResumeLayout(false);
            this.serverspanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.serverlistdtgview)).EndInit();
            this.Configuration.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Devices;
        private System.Windows.Forms.TabPage Monitoring;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button addcamera;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button addserver;
        private System.Windows.Forms.Button addswitch;
        private System.Windows.Forms.Button addrouter;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeviceType;
        private System.Windows.Forms.DataGridViewTextBoxColumn IP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.GroupBox devicemonitoringgrpbx;
        private System.Windows.Forms.GroupBox devicetypegrpbx;
        private System.Windows.Forms.GroupBox devicelistgrpbx;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Panel serverspanel;
        private System.Windows.Forms.DataGridView serverlistdtgview;
        private System.Windows.Forms.TabPage Configuration;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeviceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeviceGUID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DevicType;
        private System.Windows.Forms.Panel CameraPanel;
        internal System.Windows.Forms.TableLayoutPanel cameramonitoringpanel;
        private System.Windows.Forms.Button pasteusernamebtn;
        public System.Windows.Forms.GroupBox deviceaccessgrpbx;
        private System.Windows.Forms.Button fullscreenbtn;
        private System.Windows.Forms.Button pastepasswordbtn;
        private System.Windows.Forms.Button minimizebtn;
    }
}

