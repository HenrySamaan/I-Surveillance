
namespace I_Surveillance
{
    partial class AddSwitchForm
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
            this.addswitchbutton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.switchpasswordtxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.switchusernametxt = new System.Windows.Forms.TextBox();
            this.switchiptxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // addswitchbutton
            // 
            this.addswitchbutton.Location = new System.Drawing.Point(12, 155);
            this.addswitchbutton.Name = "addswitchbutton";
            this.addswitchbutton.Size = new System.Drawing.Size(504, 23);
            this.addswitchbutton.TabIndex = 33;
            this.addswitchbutton.Text = "Scan for Switches";
            this.addswitchbutton.UseVisualStyleBackColor = true;
            this.addswitchbutton.Click += new System.EventHandler(this.addswitchbutton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 15);
            this.label2.TabIndex = 32;
            this.label2.Text = "Switch Password";
            // 
            // switchpasswordtxt
            // 
            this.switchpasswordtxt.Location = new System.Drawing.Point(156, 109);
            this.switchpasswordtxt.Name = "switchpasswordtxt";
            this.switchpasswordtxt.Size = new System.Drawing.Size(360, 23);
            this.switchpasswordtxt.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 15);
            this.label8.TabIndex = 28;
            this.label8.Text = "Switch Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 15);
            this.label1.TabIndex = 27;
            this.label1.Text = "Switch IP Address/Range";
            // 
            // switchusernametxt
            // 
            this.switchusernametxt.Location = new System.Drawing.Point(156, 67);
            this.switchusernametxt.Name = "switchusernametxt";
            this.switchusernametxt.Size = new System.Drawing.Size(360, 23);
            this.switchusernametxt.TabIndex = 26;
            // 
            // switchiptxt
            // 
            this.switchiptxt.Location = new System.Drawing.Point(156, 20);
            this.switchiptxt.Name = "switchiptxt";
            this.switchiptxt.Size = new System.Drawing.Size(360, 23);
            this.switchiptxt.TabIndex = 25;
            this.switchiptxt.Text = "XXX.XXX.XXX.XXX OR XXX.XXX.XXX.XXX-XXX.XXX.XXX.XXX";
            // 
            // AddSwitchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 193);
            this.Controls.Add(this.addswitchbutton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.switchpasswordtxt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.switchusernametxt);
            this.Controls.Add(this.switchiptxt);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddSwitchForm";
            this.Text = "Add Switch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addswitchbutton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox switchpasswordtxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox switchusernametxt;
        private System.Windows.Forms.TextBox switchiptxt;
    }
}