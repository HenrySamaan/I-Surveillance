
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.logingroupbox = new System.Windows.Forms.GroupBox();
            this.signupGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.logingroupbox.SuspendLayout();
            this.signupGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginbtn
            // 
            this.loginbtn.Location = new System.Drawing.Point(0, 396);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(290, 46);
            this.loginbtn.TabIndex = 15;
            this.loginbtn.Text = "Log in";
            this.loginbtn.UseVisualStyleBackColor = true;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(135, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Remember Me?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 34F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(0, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(296, 62);
            this.label3.TabIndex = 13;
            this.label3.Text = "I-Surveillance";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Username";
            // 
            // savecredchkbx
            // 
            this.savecredchkbx.AutoSize = true;
            this.savecredchkbx.Location = new System.Drawing.Point(231, 241);
            this.savecredchkbx.Name = "savecredchkbx";
            this.savecredchkbx.Size = new System.Drawing.Size(15, 14);
            this.savecredchkbx.TabIndex = 10;
            this.savecredchkbx.UseVisualStyleBackColor = true;
            this.savecredchkbx.CheckedChanged += new System.EventHandler(this.savecredchkbx_CheckedChanged);
            // 
            // passwordtxt
            // 
            this.passwordtxt.Location = new System.Drawing.Point(110, 181);
            this.passwordtxt.Name = "passwordtxt";
            this.passwordtxt.Size = new System.Drawing.Size(136, 23);
            this.passwordtxt.TabIndex = 9;
            // 
            // usernametxt
            // 
            this.usernametxt.Location = new System.Drawing.Point(110, 127);
            this.usernametxt.Name = "usernametxt";
            this.usernametxt.Size = new System.Drawing.Size(136, 23);
            this.usernametxt.TabIndex = 8;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(91, 282);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(155, 15);
            this.linkLabel1.TabIndex = 16;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Not registered? sign up here";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // errorhandlinglabel
            // 
            this.errorhandlinglabel.AutoSize = true;
            this.errorhandlinglabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.errorhandlinglabel.Location = new System.Drawing.Point(6, 302);
            this.errorhandlinglabel.Name = "errorhandlinglabel";
            this.errorhandlinglabel.Size = new System.Drawing.Size(0, 21);
            this.errorhandlinglabel.TabIndex = 17;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.logingroupbox, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(304, 450);
            this.tableLayoutPanel1.TabIndex = 18;
            // 
            // logingroupbox
            // 
            this.logingroupbox.Controls.Add(this.signupGroupBox);
            this.logingroupbox.Controls.Add(this.label3);
            this.logingroupbox.Controls.Add(this.usernametxt);
            this.logingroupbox.Controls.Add(this.linkLabel1);
            this.logingroupbox.Controls.Add(this.passwordtxt);
            this.logingroupbox.Controls.Add(this.loginbtn);
            this.logingroupbox.Controls.Add(this.savecredchkbx);
            this.logingroupbox.Controls.Add(this.label4);
            this.logingroupbox.Controls.Add(this.label1);
            this.logingroupbox.Controls.Add(this.label2);
            this.logingroupbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logingroupbox.Location = new System.Drawing.Point(3, 3);
            this.logingroupbox.Name = "logingroupbox";
            this.logingroupbox.Size = new System.Drawing.Size(298, 444);
            this.logingroupbox.TabIndex = 0;
            this.logingroupbox.TabStop = false;
            this.logingroupbox.Text = "Login";
            // 
            // signupGroupBox
            // 
            this.signupGroupBox.Controls.Add(this.errorhandlinglabel);
            this.signupGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.signupGroupBox.Location = new System.Drawing.Point(3, 19);
            this.signupGroupBox.Name = "signupGroupBox";
            this.signupGroupBox.Size = new System.Drawing.Size(292, 422);
            this.signupGroupBox.TabIndex = 18;
            this.signupGroupBox.TabStop = false;
            this.signupGroupBox.Text = "Sign Up";
            this.signupGroupBox.Visible = false;
            this.signupGroupBox.Enter += new System.EventHandler(this.signupGroupBox_Enter);
            // 
            // UserLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UserLoginForm";
            this.Text = "I-Surveillance Login";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.logingroupbox.ResumeLayout(false);
            this.logingroupbox.PerformLayout();
            this.signupGroupBox.ResumeLayout(false);
            this.signupGroupBox.PerformLayout();
            this.ResumeLayout(false);

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
        internal System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        internal System.Windows.Forms.GroupBox logingroupbox;
        internal System.Windows.Forms.GroupBox signupGroupBox;
    }
}