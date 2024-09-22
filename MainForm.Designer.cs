
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
            this.serverpanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.configurationgrpbx = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.txtpowershellcommand = new System.Windows.Forms.RichTextBox();
            this.txtpowershellresponse = new System.Windows.Forms.RichTextBox();
            this.monitoringgrpbx = new System.Windows.Forms.GroupBox();
            this.diskusageprogressbar = new System.Windows.Forms.ProgressBar();
            this.networkusageprogressbar = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.memoryusageprogressbar = new System.Windows.Forms.ProgressBar();
            this.cpuusageprogressbar = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.devicetypegrpbx = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.devicelistgrpbx = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.devicelistdtgview = new System.Windows.Forms.DataGridView();
            this.DeviceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServerIP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServerUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServerPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServerGUID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SwitchGUID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RouterGUID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CameraGUID = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.serverpanel.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.configurationgrpbx.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.monitoringgrpbx.SuspendLayout();
            this.devicetypegrpbx.SuspendLayout();
            this.panel1.SuspendLayout();
            this.devicelistgrpbx.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.devicelistdtgview)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Devices);
            this.tabControl1.Controls.Add(this.Monitoring);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1083, 707);
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
            this.Devices.Size = new System.Drawing.Size(1075, 679);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1065, 669);
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
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 59);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1059, 555);
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
            this.dataGridView1.Size = new System.Drawing.Size(1053, 549);
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
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1059, 50);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // addcamera
            // 
            this.addcamera.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addcamera.Location = new System.Drawing.Point(58, 12);
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
            this.addserver.Location = new System.Drawing.Point(324, 12);
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
            this.addswitch.Location = new System.Drawing.Point(590, 12);
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
            this.addrouter.Location = new System.Drawing.Point(853, 12);
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
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 620);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1059, 46);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(924, 15);
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
            this.progressBar1.Size = new System.Drawing.Size(880, 40);
            this.progressBar1.TabIndex = 8;
            // 
            // Monitoring
            // 
            this.Monitoring.Controls.Add(this.tableLayoutPanel5);
            this.Monitoring.Location = new System.Drawing.Point(4, 24);
            this.Monitoring.Name = "Monitoring";
            this.Monitoring.Padding = new System.Windows.Forms.Padding(3);
            this.Monitoring.Size = new System.Drawing.Size(1075, 679);
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
            this.tableLayoutPanel5.Size = new System.Drawing.Size(1069, 673);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // devicemonitoringgrpbx
            // 
            this.devicemonitoringgrpbx.Controls.Add(this.serverpanel);
            this.devicemonitoringgrpbx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.devicemonitoringgrpbx.Location = new System.Drawing.Point(401, 3);
            this.devicemonitoringgrpbx.Name = "devicemonitoringgrpbx";
            this.devicemonitoringgrpbx.Size = new System.Drawing.Size(665, 667);
            this.devicemonitoringgrpbx.TabIndex = 1;
            this.devicemonitoringgrpbx.TabStop = false;
            this.devicemonitoringgrpbx.Text = "Device Monitoring";
            // 
            // serverpanel
            // 
            this.serverpanel.Controls.Add(this.tableLayoutPanel6);
            this.serverpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.serverpanel.Location = new System.Drawing.Point(3, 19);
            this.serverpanel.Name = "serverpanel";
            this.serverpanel.Size = new System.Drawing.Size(659, 645);
            this.serverpanel.TabIndex = 0;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.groupBox4, 1, 1);
            this.tableLayoutPanel6.Controls.Add(this.configurationgrpbx, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.monitoringgrpbx, 0, 1);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(659, 645);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(332, 325);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(324, 317);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            // 
            // configurationgrpbx
            // 
            this.tableLayoutPanel6.SetColumnSpan(this.configurationgrpbx, 2);
            this.configurationgrpbx.Controls.Add(this.tableLayoutPanel7);
            this.configurationgrpbx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.configurationgrpbx.Location = new System.Drawing.Point(3, 3);
            this.configurationgrpbx.Name = "configurationgrpbx";
            this.configurationgrpbx.Size = new System.Drawing.Size(653, 316);
            this.configurationgrpbx.TabIndex = 1;
            this.configurationgrpbx.TabStop = false;
            this.configurationgrpbx.Text = "Configuration";
            this.configurationgrpbx.Enter += new System.EventHandler(this.configurationgrpbx_Enter);
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Controls.Add(this.txtpowershellcommand, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.txtpowershellresponse, 0, 1);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 19);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 236F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(647, 294);
            this.tableLayoutPanel7.TabIndex = 0;
            // 
            // txtpowershellcommand
            // 
            this.txtpowershellcommand.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtpowershellcommand.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtpowershellcommand.ForeColor = System.Drawing.SystemColors.Window;
            this.txtpowershellcommand.Location = new System.Drawing.Point(3, 3);
            this.txtpowershellcommand.Name = "txtpowershellcommand";
            this.txtpowershellcommand.Size = new System.Drawing.Size(641, 52);
            this.txtpowershellcommand.TabIndex = 0;
            this.txtpowershellcommand.Text = "";
            this.txtpowershellcommand.TextChanged += new System.EventHandler(this.txtpowershell_TextChanged);
            this.txtpowershellcommand.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtpowershell_KeyDown);
            // 
            // txtpowershellresponse
            // 
            this.txtpowershellresponse.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtpowershellresponse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtpowershellresponse.ForeColor = System.Drawing.SystemColors.Window;
            this.txtpowershellresponse.Location = new System.Drawing.Point(3, 61);
            this.txtpowershellresponse.Name = "txtpowershellresponse";
            this.txtpowershellresponse.ReadOnly = true;
            this.txtpowershellresponse.Size = new System.Drawing.Size(641, 230);
            this.txtpowershellresponse.TabIndex = 1;
            this.txtpowershellresponse.Text = "";
            // 
            // monitoringgrpbx
            // 
            this.monitoringgrpbx.Controls.Add(this.diskusageprogressbar);
            this.monitoringgrpbx.Controls.Add(this.networkusageprogressbar);
            this.monitoringgrpbx.Controls.Add(this.label5);
            this.monitoringgrpbx.Controls.Add(this.label4);
            this.monitoringgrpbx.Controls.Add(this.memoryusageprogressbar);
            this.monitoringgrpbx.Controls.Add(this.cpuusageprogressbar);
            this.monitoringgrpbx.Controls.Add(this.label3);
            this.monitoringgrpbx.Controls.Add(this.label2);
            this.monitoringgrpbx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.monitoringgrpbx.Location = new System.Drawing.Point(3, 325);
            this.monitoringgrpbx.Name = "monitoringgrpbx";
            this.monitoringgrpbx.Size = new System.Drawing.Size(323, 317);
            this.monitoringgrpbx.TabIndex = 2;
            this.monitoringgrpbx.TabStop = false;
            this.monitoringgrpbx.Text = "Monitoring";
            // 
            // diskusageprogressbar
            // 
            this.diskusageprogressbar.Location = new System.Drawing.Point(151, 104);
            this.diskusageprogressbar.Maximum = 10000;
            this.diskusageprogressbar.Name = "diskusageprogressbar";
            this.diskusageprogressbar.Size = new System.Drawing.Size(166, 23);
            this.diskusageprogressbar.TabIndex = 7;
            // 
            // networkusageprogressbar
            // 
            this.networkusageprogressbar.Location = new System.Drawing.Point(151, 137);
            this.networkusageprogressbar.Maximum = 1100;
            this.networkusageprogressbar.Name = "networkusageprogressbar";
            this.networkusageprogressbar.Size = new System.Drawing.Size(166, 23);
            this.networkusageprogressbar.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Disk Usage";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Network Usage";
            // 
            // memoryusageprogressbar
            // 
            this.memoryusageprogressbar.Location = new System.Drawing.Point(151, 67);
            this.memoryusageprogressbar.Maximum = 1100;
            this.memoryusageprogressbar.Name = "memoryusageprogressbar";
            this.memoryusageprogressbar.Size = new System.Drawing.Size(166, 23);
            this.memoryusageprogressbar.TabIndex = 3;
            // 
            // cpuusageprogressbar
            // 
            this.cpuusageprogressbar.Location = new System.Drawing.Point(151, 30);
            this.cpuusageprogressbar.Maximum = 10;
            this.cpuusageprogressbar.Name = "cpuusageprogressbar";
            this.cpuusageprogressbar.Size = new System.Drawing.Size(166, 23);
            this.cpuusageprogressbar.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Memory Usage";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "CPU Usage";
            // 
            // devicetypegrpbx
            // 
            this.devicetypegrpbx.Controls.Add(this.panel1);
            this.devicetypegrpbx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.devicetypegrpbx.Location = new System.Drawing.Point(3, 3);
            this.devicetypegrpbx.Name = "devicetypegrpbx";
            this.devicetypegrpbx.Size = new System.Drawing.Size(183, 667);
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
            this.panel1.Size = new System.Drawing.Size(177, 645);
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
            this.treeView1.Size = new System.Drawing.Size(177, 645);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // devicelistgrpbx
            // 
            this.devicelistgrpbx.Controls.Add(this.panel2);
            this.devicelistgrpbx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.devicelistgrpbx.Location = new System.Drawing.Point(192, 3);
            this.devicelistgrpbx.Name = "devicelistgrpbx";
            this.devicelistgrpbx.Size = new System.Drawing.Size(203, 667);
            this.devicelistgrpbx.TabIndex = 1;
            this.devicelistgrpbx.TabStop = false;
            this.devicelistgrpbx.Text = "Device List";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.devicelistdtgview);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(197, 645);
            this.panel2.TabIndex = 0;
            // 
            // devicelistdtgview
            // 
            this.devicelistdtgview.AllowUserToAddRows = false;
            this.devicelistdtgview.AllowUserToDeleteRows = false;
            this.devicelistdtgview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.devicelistdtgview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.devicelistdtgview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.devicelistdtgview.ColumnHeadersVisible = false;
            this.devicelistdtgview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DeviceName,
            this.ServerIP,
            this.ServerUsername,
            this.ServerPassword,
            this.dataGridViewTextBoxColumn1,
            this.ServerGUID,
            this.SwitchGUID,
            this.RouterGUID,
            this.CameraGUID});
            this.devicelistdtgview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.devicelistdtgview.EnableHeadersVisualStyles = false;
            this.devicelistdtgview.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.devicelistdtgview.Location = new System.Drawing.Point(0, 0);
            this.devicelistdtgview.Name = "devicelistdtgview";
            this.devicelistdtgview.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.devicelistdtgview.RowHeadersVisible = false;
            this.devicelistdtgview.RowTemplate.Height = 25;
            this.devicelistdtgview.Size = new System.Drawing.Size(197, 645);
            this.devicelistdtgview.TabIndex = 0;
            this.devicelistdtgview.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.devicelistdtgview_CellContentDoubleClick);
            // 
            // DeviceName
            // 
            this.DeviceName.DataPropertyName = "DeviceName";
            this.DeviceName.HeaderText = "DeviceName";
            this.DeviceName.Name = "DeviceName";
            this.DeviceName.ReadOnly = true;
            // 
            // ServerIP
            // 
            this.ServerIP.DataPropertyName = "ServerIP";
            this.ServerIP.HeaderText = "ServerIP";
            this.ServerIP.Name = "ServerIP";
            this.ServerIP.Visible = false;
            // 
            // ServerUsername
            // 
            this.ServerUsername.DataPropertyName = "ServerUsername";
            this.ServerUsername.HeaderText = "ServerUsername";
            this.ServerUsername.Name = "ServerUsername";
            this.ServerUsername.Visible = false;
            // 
            // ServerPassword
            // 
            this.ServerPassword.DataPropertyName = "ServerPassword";
            this.ServerPassword.HeaderText = "ServerPassword";
            this.ServerPassword.Name = "ServerPassword";
            this.ServerPassword.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "DeviceName";
            this.dataGridViewTextBoxColumn1.HeaderText = "DeviceName";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // ServerGUID
            // 
            this.ServerGUID.DataPropertyName = "ServerGUID";
            this.ServerGUID.HeaderText = "ServerGUID";
            this.ServerGUID.Name = "ServerGUID";
            this.ServerGUID.Visible = false;
            // 
            // SwitchGUID
            // 
            this.SwitchGUID.DataPropertyName = "SwitchGUID";
            this.SwitchGUID.HeaderText = "SwitchGUID";
            this.SwitchGUID.Name = "SwitchGUID";
            this.SwitchGUID.Visible = false;
            // 
            // RouterGUID
            // 
            this.RouterGUID.DataPropertyName = "RouterGUID";
            this.RouterGUID.HeaderText = "RouterGUID";
            this.RouterGUID.Name = "RouterGUID";
            this.RouterGUID.Visible = false;
            // 
            // CameraGUID
            // 
            this.CameraGUID.DataPropertyName = "CameraGUID";
            this.CameraGUID.HeaderText = "CameraGUID";
            this.CameraGUID.Name = "CameraGUID";
            this.CameraGUID.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 707);
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
            this.serverpanel.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.configurationgrpbx.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.monitoringgrpbx.ResumeLayout(false);
            this.monitoringgrpbx.PerformLayout();
            this.devicetypegrpbx.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.devicelistgrpbx.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.devicelistdtgview)).EndInit();
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
        private System.Windows.Forms.Panel serverpanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView devicelistdtgview;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox monitoringgrpbx;
        private System.Windows.Forms.GroupBox configurationgrpbx;
        private System.Windows.Forms.RichTextBox txtpowershellcommand;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.RichTextBox txtpowershellresponse;
        private System.Windows.Forms.ProgressBar memoryusageprogressbar;
        private System.Windows.Forms.ProgressBar cpuusageprogressbar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar diskusageprogressbar;
        private System.Windows.Forms.ProgressBar networkusageprogressbar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeviceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServerIP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServerUsername;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServerPassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServerGUID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SwitchGUID;
        private System.Windows.Forms.DataGridViewTextBoxColumn RouterGUID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CameraGUID;
    }
}

