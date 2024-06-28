
namespace I_Surveillance
{
    partial class CameraAddForm
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
            this.cameraiptxt = new System.Windows.Forms.TextBox();
            this.cameraimagetxt = new System.Windows.Forms.TextBox();
            this.camerartsptxt = new System.Windows.Forms.TextBox();
            this.cameraidtxt = new System.Windows.Forms.TextBox();
            this.camerapasstxt = new System.Windows.Forms.TextBox();
            this.camerausernametxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cameraiptxt
            // 
            this.cameraiptxt.Location = new System.Drawing.Point(175, 31);
            this.cameraiptxt.Name = "cameraiptxt";
            this.cameraiptxt.Size = new System.Drawing.Size(360, 23);
            this.cameraiptxt.TabIndex = 0;
            this.cameraiptxt.Text = "XXX.XXX.XXX.XXX OR XXX.XXX.XXX.XXX-XXX.XXX.XXX.XXX";
            // 
            // cameraimagetxt
            // 
            this.cameraimagetxt.Location = new System.Drawing.Point(175, 302);
            this.cameraimagetxt.Name = "cameraimagetxt";
            this.cameraimagetxt.Size = new System.Drawing.Size(360, 23);
            this.cameraimagetxt.TabIndex = 2;
            // 
            // camerartsptxt
            // 
            this.camerartsptxt.Location = new System.Drawing.Point(175, 250);
            this.camerartsptxt.Name = "camerartsptxt";
            this.camerartsptxt.Size = new System.Drawing.Size(360, 23);
            this.camerartsptxt.TabIndex = 3;
            // 
            // cameraidtxt
            // 
            this.cameraidtxt.Location = new System.Drawing.Point(175, 195);
            this.cameraidtxt.Name = "cameraidtxt";
            this.cameraidtxt.Size = new System.Drawing.Size(360, 23);
            this.cameraidtxt.TabIndex = 4;
            // 
            // camerapasstxt
            // 
            this.camerapasstxt.Location = new System.Drawing.Point(175, 137);
            this.camerapasstxt.Name = "camerapasstxt";
            this.camerapasstxt.Size = new System.Drawing.Size(360, 23);
            this.camerapasstxt.TabIndex = 5;
            // 
            // camerausernametxt
            // 
            this.camerausernametxt.Location = new System.Drawing.Point(175, 78);
            this.camerausernametxt.Name = "camerausernametxt";
            this.camerausernametxt.Size = new System.Drawing.Size(360, 23);
            this.camerausernametxt.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Camera IP Address/Range";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Camera Image Link";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Camera RTSP Link";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Camera ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Camera Password";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "Camera Username";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 353);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(523, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Scan for Cameras";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CameraAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 392);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.camerausernametxt);
            this.Controls.Add(this.camerapasstxt);
            this.Controls.Add(this.cameraidtxt);
            this.Controls.Add(this.camerartsptxt);
            this.Controls.Add(this.cameraimagetxt);
            this.Controls.Add(this.cameraiptxt);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CameraAddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Camera";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cameraiptxt;
        private System.Windows.Forms.TextBox cameraimagetxt;
        private System.Windows.Forms.TextBox camerartsptxt;
        private System.Windows.Forms.TextBox cameraidtxt;
        private System.Windows.Forms.TextBox camerapasstxt;
        private System.Windows.Forms.TextBox camerausernametxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
    }
}