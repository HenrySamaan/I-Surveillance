
namespace I_Surveillance
{
    partial class testingform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CameraPanel = new System.Windows.Forms.Panel();
            this.cameramonitoringpanel = new System.Windows.Forms.TableLayoutPanel();
            this.returnbtn = new System.Windows.Forms.Button();
            this.cameraaccessgrpbx = new System.Windows.Forms.GroupBox();
            this.livecameragrpbx = new System.Windows.Forms.GroupBox();
            this.webviewbtn = new System.Windows.Forms.Button();
            this.livebtn = new System.Windows.Forms.Button();
            this.camerasdtgv = new System.Windows.Forms.DataGridView();
            this.CameraGuid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CameraIP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CameraUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CameraPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CameraLink = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeviceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cameraspanel = new System.Windows.Forms.Panel();
            this.serverpanel = new System.Windows.Forms.Panel();
            this.CameraPanel.SuspendLayout();
            this.cameramonitoringpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.camerasdtgv)).BeginInit();
            this.cameraspanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CameraPanel
            // 
            this.CameraPanel.Controls.Add(this.cameramonitoringpanel);
            this.CameraPanel.Location = new System.Drawing.Point(925, 12);
            this.CameraPanel.Name = "CameraPanel";
            this.CameraPanel.Size = new System.Drawing.Size(659, 596);
            this.CameraPanel.TabIndex = 0;
            // 
            // cameramonitoringpanel
            // 
            this.cameramonitoringpanel.ColumnCount = 4;
            this.cameramonitoringpanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.44444F));
            this.cameramonitoringpanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.555555F));
            this.cameramonitoringpanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.555555F));
            this.cameramonitoringpanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.44444F));
            this.cameramonitoringpanel.Controls.Add(this.returnbtn, 1, 1);
            this.cameramonitoringpanel.Controls.Add(this.cameraaccessgrpbx, 0, 0);
            this.cameramonitoringpanel.Controls.Add(this.livecameragrpbx, 2, 0);
            this.cameramonitoringpanel.Controls.Add(this.webviewbtn, 0, 1);
            this.cameramonitoringpanel.Controls.Add(this.livebtn, 3, 1);
            this.cameramonitoringpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cameramonitoringpanel.Location = new System.Drawing.Point(0, 0);
            this.cameramonitoringpanel.Name = "cameramonitoringpanel";
            this.cameramonitoringpanel.RowCount = 2;
            this.cameramonitoringpanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 95F));
            this.cameramonitoringpanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.cameramonitoringpanel.Size = new System.Drawing.Size(659, 596);
            this.cameramonitoringpanel.TabIndex = 0;
            // 
            // returnbtn
            // 
            this.cameramonitoringpanel.SetColumnSpan(this.returnbtn, 2);
            this.returnbtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.returnbtn.Location = new System.Drawing.Point(295, 569);
            this.returnbtn.Name = "returnbtn";
            this.returnbtn.Size = new System.Drawing.Size(66, 24);
            this.returnbtn.TabIndex = 4;
            this.returnbtn.Text = "Return";
            this.returnbtn.UseVisualStyleBackColor = true;
            this.returnbtn.Click += new System.EventHandler(this.returnbtn_Click);
            // 
            // cameraaccessgrpbx
            // 
            this.cameramonitoringpanel.SetColumnSpan(this.cameraaccessgrpbx, 2);
            this.cameraaccessgrpbx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cameraaccessgrpbx.Location = new System.Drawing.Point(3, 3);
            this.cameraaccessgrpbx.Name = "cameraaccessgrpbx";
            this.cameraaccessgrpbx.Size = new System.Drawing.Size(322, 560);
            this.cameraaccessgrpbx.TabIndex = 2;
            this.cameraaccessgrpbx.TabStop = false;
            this.cameraaccessgrpbx.Text = "Camera Access";
            // 
            // livecameragrpbx
            // 
            this.cameramonitoringpanel.SetColumnSpan(this.livecameragrpbx, 2);
            this.livecameragrpbx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.livecameragrpbx.Location = new System.Drawing.Point(331, 3);
            this.livecameragrpbx.Name = "livecameragrpbx";
            this.livecameragrpbx.Size = new System.Drawing.Size(325, 560);
            this.livecameragrpbx.TabIndex = 0;
            this.livecameragrpbx.TabStop = false;
            this.livecameragrpbx.Text = "Live";
            // 
            // webviewbtn
            // 
            this.webviewbtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webviewbtn.Location = new System.Drawing.Point(3, 569);
            this.webviewbtn.Name = "webviewbtn";
            this.webviewbtn.Size = new System.Drawing.Size(286, 24);
            this.webviewbtn.TabIndex = 3;
            this.webviewbtn.Text = "Web View";
            this.webviewbtn.UseVisualStyleBackColor = true;
            this.webviewbtn.Click += new System.EventHandler(this.webviewbtn_Click);
            this.webviewbtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.webviewbtn_MouseDown);
            // 
            // livebtn
            // 
            this.livebtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.livebtn.Location = new System.Drawing.Point(367, 569);
            this.livebtn.Name = "livebtn";
            this.livebtn.Size = new System.Drawing.Size(289, 24);
            this.livebtn.TabIndex = 5;
            this.livebtn.Text = "Live View";
            this.livebtn.UseVisualStyleBackColor = true;
            this.livebtn.Click += new System.EventHandler(this.livebtn_Click);
            // 
            // camerasdtgv
            // 
            this.camerasdtgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.camerasdtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.camerasdtgv.ColumnHeadersVisible = false;
            this.camerasdtgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CameraGuid,
            this.CameraIP,
            this.CameraUsername,
            this.CameraPassword,
            this.CameraLink,
            this.DeviceName});
            this.camerasdtgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.camerasdtgv.Location = new System.Drawing.Point(0, 0);
            this.camerasdtgv.Name = "camerasdtgv";
            this.camerasdtgv.ReadOnly = true;
            this.camerasdtgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.camerasdtgv.RowHeadersVisible = false;
            this.camerasdtgv.RowTemplate.Height = 25;
            this.camerasdtgv.Size = new System.Drawing.Size(197, 596);
            this.camerasdtgv.TabIndex = 1;
            this.camerasdtgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.camerasdtgv_CellContentClick);
            this.camerasdtgv.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.camerasdtgv_CellContentDoubleClick);
            // 
            // CameraGuid
            // 
            this.CameraGuid.DataPropertyName = "CameraGuid";
            this.CameraGuid.HeaderText = "CameraGuid";
            this.CameraGuid.Name = "CameraGuid";
            this.CameraGuid.ReadOnly = true;
            this.CameraGuid.Visible = false;
            // 
            // CameraIP
            // 
            this.CameraIP.DataPropertyName = "CameraIP";
            this.CameraIP.HeaderText = "CameraIP";
            this.CameraIP.Name = "CameraIP";
            this.CameraIP.ReadOnly = true;
            this.CameraIP.Visible = false;
            // 
            // CameraUsername
            // 
            this.CameraUsername.DataPropertyName = "CameraUsername";
            this.CameraUsername.HeaderText = "CameraUsername";
            this.CameraUsername.Name = "CameraUsername";
            this.CameraUsername.ReadOnly = true;
            this.CameraUsername.Visible = false;
            // 
            // CameraPassword
            // 
            this.CameraPassword.DataPropertyName = "CameraPassword";
            this.CameraPassword.HeaderText = "CameraPassword";
            this.CameraPassword.Name = "CameraPassword";
            this.CameraPassword.ReadOnly = true;
            this.CameraPassword.Visible = false;
            // 
            // CameraLink
            // 
            this.CameraLink.DataPropertyName = "CameraLink";
            this.CameraLink.HeaderText = "CameraLink";
            this.CameraLink.Name = "CameraLink";
            this.CameraLink.ReadOnly = true;
            this.CameraLink.Visible = false;
            // 
            // DeviceName
            // 
            this.DeviceName.DataPropertyName = "DeviceName";
            this.DeviceName.HeaderText = "DeviceName";
            this.DeviceName.Name = "DeviceName";
            this.DeviceName.ReadOnly = true;
            // 
            // cameraspanel
            // 
            this.cameraspanel.Controls.Add(this.camerasdtgv);
            this.cameraspanel.Location = new System.Drawing.Point(722, 15);
            this.cameraspanel.Name = "cameraspanel";
            this.cameraspanel.Size = new System.Drawing.Size(197, 596);
            this.cameraspanel.TabIndex = 2;
            // 
            // serverpanel
            // 
            this.serverpanel.Location = new System.Drawing.Point(12, 12);
            this.serverpanel.Name = "serverpanel";
            this.serverpanel.Size = new System.Drawing.Size(627, 680);
            this.serverpanel.TabIndex = 3;
            // 
            // testingform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1596, 845);
            this.Controls.Add(this.serverpanel);
            this.Controls.Add(this.cameraspanel);
            this.Controls.Add(this.CameraPanel);
            this.Name = "testingform";
            this.Text = "testingform";
            this.CameraPanel.ResumeLayout(false);
            this.cameramonitoringpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.camerasdtgv)).EndInit();
            this.cameraspanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel CameraPanel;
        internal System.Windows.Forms.TableLayoutPanel cameramonitoringpanel;
        public System.Windows.Forms.GroupBox livecameragrpbx;
        private System.Windows.Forms.DataGridView camerasdtgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn CameraGuid;
        private System.Windows.Forms.DataGridViewTextBoxColumn CameraIP;
        private System.Windows.Forms.DataGridViewTextBoxColumn CameraUsername;
        private System.Windows.Forms.DataGridViewTextBoxColumn CameraPassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn CameraLink;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeviceName;
        private System.Windows.Forms.Button returnbtn;
        public System.Windows.Forms.GroupBox cameraaccessgrpbx;
        private System.Windows.Forms.Button webviewbtn;
        private System.Windows.Forms.Button livebtn;
        private System.Windows.Forms.Panel cameraspanel;
        private System.Windows.Forms.Panel serverpanel;
    }
}