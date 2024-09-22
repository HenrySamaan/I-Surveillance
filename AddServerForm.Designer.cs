
namespace I_Surveillance
{
    partial class AddServerForm
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
            this.serveriptxt = new System.Windows.Forms.TextBox();
            this.serverdomaintxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.serverusernametxt = new System.Windows.Forms.TextBox();
            this.serverpasswordtxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addserverbutton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.devicenametxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // serveriptxt
            // 
            this.serveriptxt.Location = new System.Drawing.Point(154, 62);
            this.serveriptxt.Name = "serveriptxt";
            this.serveriptxt.Size = new System.Drawing.Size(418, 23);
            this.serveriptxt.TabIndex = 15;
            this.serveriptxt.Text = "XXX.XXX.XXX.XXX OR XXX.XXX.XXX.XXX-XXX.XXX.XXX.XXX";
            // 
            // serverdomaintxt
            // 
            this.serverdomaintxt.Location = new System.Drawing.Point(154, 109);
            this.serverdomaintxt.Name = "serverdomaintxt";
            this.serverdomaintxt.Size = new System.Drawing.Size(418, 23);
            this.serverdomaintxt.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "Server IP Address/Range";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 15);
            this.label8.TabIndex = 18;
            this.label8.Text = "Server Domain";
            // 
            // serverusernametxt
            // 
            this.serverusernametxt.Location = new System.Drawing.Point(154, 156);
            this.serverusernametxt.Name = "serverusernametxt";
            this.serverusernametxt.Size = new System.Drawing.Size(418, 23);
            this.serverusernametxt.TabIndex = 19;
            // 
            // serverpasswordtxt
            // 
            this.serverpasswordtxt.Location = new System.Drawing.Point(154, 203);
            this.serverpasswordtxt.Name = "serverpasswordtxt";
            this.serverpasswordtxt.Size = new System.Drawing.Size(418, 23);
            this.serverpasswordtxt.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 15);
            this.label3.TabIndex = 21;
            this.label3.Text = "Server Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 15);
            this.label2.TabIndex = 22;
            this.label2.Text = "Server Password";
            // 
            // addserverbutton
            // 
            this.addserverbutton.Location = new System.Drawing.Point(12, 245);
            this.addserverbutton.Name = "addserverbutton";
            this.addserverbutton.Size = new System.Drawing.Size(560, 23);
            this.addserverbutton.TabIndex = 24;
            this.addserverbutton.Text = "Scan for Servers";
            this.addserverbutton.UseVisualStyleBackColor = true;
            this.addserverbutton.Click += new System.EventHandler(this.addserverbutton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 15);
            this.label4.TabIndex = 44;
            this.label4.Text = "Device Name";
            // 
            // devicenametxt
            // 
            this.devicenametxt.Location = new System.Drawing.Point(154, 17);
            this.devicenametxt.Name = "devicenametxt";
            this.devicenametxt.Size = new System.Drawing.Size(418, 23);
            this.devicenametxt.TabIndex = 43;
            // 
            // AddServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 280);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.devicenametxt);
            this.Controls.Add(this.addserverbutton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.serverpasswordtxt);
            this.Controls.Add(this.serverusernametxt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.serverdomaintxt);
            this.Controls.Add(this.serveriptxt);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddServerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox serveriptxt;
        private System.Windows.Forms.TextBox serverdomaintxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox serverusernametxt;
        private System.Windows.Forms.TextBox serverpasswordtxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addserverbutton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox devicenametxt;
    }
}