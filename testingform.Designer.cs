
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cameraaccessgrpbx = new System.Windows.Forms.GroupBox();
            this.livecameragrpbx = new System.Windows.Forms.GroupBox();
            this.CameraPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CameraPanel
            // 
            this.CameraPanel.Controls.Add(this.tableLayoutPanel1);
            this.CameraPanel.Location = new System.Drawing.Point(188, 12);
            this.CameraPanel.Name = "CameraPanel";
            this.CameraPanel.Size = new System.Drawing.Size(659, 596);
            this.CameraPanel.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.livecameragrpbx, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.cameraaccessgrpbx, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(659, 596);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // cameraaccessgrpbx
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.cameraaccessgrpbx, 2);
            this.cameraaccessgrpbx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cameraaccessgrpbx.Location = new System.Drawing.Point(3, 3);
            this.cameraaccessgrpbx.Name = "cameraaccessgrpbx";
            this.tableLayoutPanel1.SetRowSpan(this.cameraaccessgrpbx, 3);
            this.cameraaccessgrpbx.Size = new System.Drawing.Size(432, 590);
            this.cameraaccessgrpbx.TabIndex = 2;
            this.cameraaccessgrpbx.TabStop = false;
            this.cameraaccessgrpbx.Text = "Camera Access";
            // 
            // livecameragrpbx
            // 
            this.livecameragrpbx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.livecameragrpbx.Location = new System.Drawing.Point(441, 201);
            this.livecameragrpbx.Name = "livecameragrpbx";
            this.livecameragrpbx.Size = new System.Drawing.Size(215, 192);
            this.livecameragrpbx.TabIndex = 0;
            this.livecameragrpbx.TabStop = false;
            this.livecameragrpbx.Text = "Live";
            // 
            // testingform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 691);
            this.Controls.Add(this.CameraPanel);
            this.Name = "testingform";
            this.Text = "testingform";
            this.CameraPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel CameraPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox cameraaccessgrpbx;
        private System.Windows.Forms.GroupBox livecameragrpbx;
    }
}