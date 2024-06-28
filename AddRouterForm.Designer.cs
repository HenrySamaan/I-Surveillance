
namespace I_Surveillance
{
    partial class AddRouter
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
            this.addrouterbutton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.routerpasswordtxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.routerusernametxt = new System.Windows.Forms.TextBox();
            this.routeriptxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // addrouterbutton
            // 
            this.addrouterbutton.Location = new System.Drawing.Point(12, 159);
            this.addrouterbutton.Name = "addrouterbutton";
            this.addrouterbutton.Size = new System.Drawing.Size(515, 23);
            this.addrouterbutton.TabIndex = 40;
            this.addrouterbutton.Text = "Scan for Routers";
            this.addrouterbutton.UseVisualStyleBackColor = true;
            this.addrouterbutton.Click += new System.EventHandler(this.addrouterbutton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 15);
            this.label2.TabIndex = 39;
            this.label2.Text = "Router Password";
            // 
            // routerpasswordtxt
            // 
            this.routerpasswordtxt.Location = new System.Drawing.Point(167, 110);
            this.routerpasswordtxt.Name = "routerpasswordtxt";
            this.routerpasswordtxt.Size = new System.Drawing.Size(360, 23);
            this.routerpasswordtxt.TabIndex = 38;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 15);
            this.label8.TabIndex = 37;
            this.label8.Text = "Router Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 15);
            this.label1.TabIndex = 36;
            this.label1.Text = "Router IP Address/Range";
            // 
            // routerusernametxt
            // 
            this.routerusernametxt.Location = new System.Drawing.Point(167, 68);
            this.routerusernametxt.Name = "routerusernametxt";
            this.routerusernametxt.Size = new System.Drawing.Size(360, 23);
            this.routerusernametxt.TabIndex = 35;
            // 
            // routeriptxt
            // 
            this.routeriptxt.Location = new System.Drawing.Point(167, 21);
            this.routeriptxt.Name = "routeriptxt";
            this.routeriptxt.Size = new System.Drawing.Size(360, 23);
            this.routeriptxt.TabIndex = 34;
            this.routeriptxt.Text = "XXX.XXX.XXX.XXX OR XXX.XXX.XXX.XXX-XXX.XXX.XXX.XXX";
            // 
            // AddRouter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 198);
            this.Controls.Add(this.addrouterbutton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.routerpasswordtxt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.routerusernametxt);
            this.Controls.Add(this.routeriptxt);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddRouter";
            this.Text = "Add Router";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addrouterbutton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox routerpasswordtxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox routerusernametxt;
        private System.Windows.Forms.TextBox routeriptxt;
    }
}