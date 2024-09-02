
namespace I_Surveillance
{
    partial class UserLoginForm
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
            this.loginbtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.savecredchkbx = new System.Windows.Forms.CheckBox();
            this.passwordtxt = new System.Windows.Forms.TextBox();
            this.usernametxt = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.errorhandlinglabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loginbtn
            // 
            this.loginbtn.Location = new System.Drawing.Point(7, 391);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(296, 46);
            this.loginbtn.TabIndex = 15;
            this.loginbtn.Text = "Log in";
            this.loginbtn.UseVisualStyleBackColor = true;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(142, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Remember Me?";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 34F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(7, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(296, 62);
            this.label3.TabIndex = 13;
            this.label3.Text = "I-Surveillance";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Username";
            // 
            // savecredchkbx
            // 
            this.savecredchkbx.AutoSize = true;
            this.savecredchkbx.Location = new System.Drawing.Point(238, 236);
            this.savecredchkbx.Name = "savecredchkbx";
            this.savecredchkbx.Size = new System.Drawing.Size(15, 14);
            this.savecredchkbx.TabIndex = 10;
            this.savecredchkbx.UseVisualStyleBackColor = true;
            this.savecredchkbx.CheckedChanged += new System.EventHandler(this.savecredchkbx_CheckedChanged);
            // 
            // passwordtxt
            // 
            this.passwordtxt.Location = new System.Drawing.Point(117, 176);
            this.passwordtxt.Name = "passwordtxt";
            this.passwordtxt.Size = new System.Drawing.Size(136, 23);
            this.passwordtxt.TabIndex = 9;
            // 
            // usernametxt
            // 
            this.usernametxt.Location = new System.Drawing.Point(117, 122);
            this.usernametxt.Name = "usernametxt";
            this.usernametxt.Size = new System.Drawing.Size(136, 23);
            this.usernametxt.TabIndex = 8;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(98, 277);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(155, 15);
            this.linkLabel1.TabIndex = 16;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Not registered? sign up here";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // errorhandlinglabel
            // 
            this.errorhandlinglabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.errorhandlinglabel.AutoSize = true;
            this.errorhandlinglabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.errorhandlinglabel.Location = new System.Drawing.Point(7, 306);
            this.errorhandlinglabel.Name = "errorhandlinglabel";
            this.errorhandlinglabel.Size = new System.Drawing.Size(0, 21);
            this.errorhandlinglabel.TabIndex = 17;
            // 
            // UserLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 450);
            this.Controls.Add(this.errorhandlinglabel);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.loginbtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.savecredchkbx);
            this.Controls.Add(this.passwordtxt);
            this.Controls.Add(this.usernametxt);
            this.Name = "UserLoginForm";
            this.Text = "UserLoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginbtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox savecredchkbx;
        private System.Windows.Forms.TextBox passwordtxt;
        private System.Windows.Forms.TextBox usernametxt;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label errorhandlinglabel;
    }
}